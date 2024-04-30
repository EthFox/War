using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace War
{
	public partial class frmWarGame : Form
	{
		private struct Card
		{
			public string card;
			public int value;
		}

		List<Card> deck = new List<Card>();
		List<Card> computerDeck = new List<Card>();
		List<Card> playerDeck = new List<Card>();
		string dirname = "";
		bool Ended = false;
		int warCounter = 0; // temp for getting double war

		// GUI Declarations
		List<PictureBox> compDisplays = new List<PictureBox>();
		List<PictureBox> playDisplays = new List<PictureBox>();
		int compX = 0;
		int compY = 0;
		int playX = 0;
		int playY = 0;

		// (re)start message variables
		Graphics message;
		string messageText = "Press [Space] To Begin";
		int opacity = 0;
		bool increasing = true; // see paint event

		public frmWarGame()
		{
			InitializeComponent();
		}

		private void frmWarGame_Load(object sender, EventArgs e)
		{
			dirname = Directory.GetCurrentDirectory();
			dirname = dirname.Remove(dirname.Length - 9, 9) + "Resources\\"; // getting the directory of the project and removing the end so that we can get to the resources folder

			compDisplays.Add(compCard1); //adding initial 2 cards to lists
			playDisplays.Add(playerCard1);

			createDeck();

			shuffleDeck(out List<Card> shuffledDeck);

			splitDeck(shuffledDeck, out computerDeck, out playerDeck);
		}

		private void frmWarGame_KeyPress(object sender, KeyPressEventArgs e)
		{
			char KeyPressed = e.KeyChar;

			if (KeyPressed == ' ' && Ended == false)
			{
				try
				{
					if (playDisplays.Count > 1) // if war occured last play, remove the cards
					{
						resetWar();
					}

					// stop start message
					if (tmrStartMessage.Enabled == true)
					{
						opacity = 0;
						tmrStartMessage.Enabled = false;
						Invalidate();
					}

					Bitmap compCard1 = new Bitmap(dirname + computerDeck[0].card.Replace(' ', '_') + ".png");
					Bitmap playCard1 = new Bitmap(dirname + playerDeck[0].card.Replace(' ', '_') + ".png");

					playDisplays[0].Image = playCard1;
					compDisplays[0].Image = compCard1;
					playDisplays[0].Visible = true;
					compDisplays[0].Visible = true;
					compDisplays[0].Image.RotateFlip(RotateFlipType.RotateNoneFlipXY); // computer card is flipped vertically

					lblWinLoss.Visible = true;

					if (playerDeck[0].value > computerDeck[0].value) // player wins
					{
						winText();
						normal(ref playerDeck, ref computerDeck); // ORDER MATTERS! Winning deck goes first
					}
					else if (computerDeck[0].value > playerDeck[0].value) // computer wins
					{
						lossText();
						normal(ref computerDeck, ref playerDeck); // ORDER MATTERS! Winning deck goes first
					}
					else // draw, begin war
					{
						drawText();

						compX = compDisplays[0].Location.X; // gets starting card locations so that new cards can be placed relative to them
						compY = compDisplays[0].Location.Y;
						playX = playDisplays[0].Location.X;
						playY = playDisplays[0].Location.Y;

						List<Card> cardsWon = new List<Card>(); // temp cards list to be added to end of winning deck
						warCounter = 0;
						do
						{
							war(ref playerDeck, ref computerDeck, ref cardsWon); // takes top 4 cards in each deck and puts it in the win pile, as in war when 'war' happens, 3 extra cards are drawn face down that go to the winner, leaves the last one that is drawn face up to be tested again
							warGUI();
							++warCounter;
						}
						while (playerDeck[0].value == computerDeck[0].value); // do loop in the case that war starts again
						if (warCounter > 1)
						{
							MessageBox.Show("Stop!"); // temp to find double war
						}

						if (playerDeck[0].value > computerDeck[0].value) // player won war
						{
							playerDeck.AddRange(cardsWon); // add the cards won to the end of the winning deck
							normal(ref playerDeck, ref computerDeck); // give remaining two cards to the winning deck (last two are left off to ensure that there isnt another war)
							winText();
						}
						else // computer won war
						{
							computerDeck.AddRange(cardsWon); // add the cards won to the end of the winning deck
							normal(ref computerDeck, ref playerDeck); // give remaining two cards to the winning deck
							lossText();
						}
					}
					lblCompCount.Text = computerDeck.Count.ToString();
					lblPlayerCount.Text = playerDeck.Count.ToString();
				}
				catch (ArgumentOutOfRangeException)
				{
					EndGame();
				}
				catch (ArgumentException)
				{
					EndGame();
				}
			}
			else if (KeyPressed == '\r' && Ended) // restart
			{
				// changing restart message back into start message
				opacity = 0;
				increasing = true;
				messageText = "Press [Space] To Begin";

				lblWin.Visible = false;
				lblWinMessage.Visible = false;
				lblLose.Visible = false;
				lblLoseMessage.Visible = false;

				playerDeck.Clear();
				computerDeck.Clear();

				shuffleDeck(out List<Card> shuffledDeck); // shuffle new deck

				splitDeck(shuffledDeck, out computerDeck, out playerDeck); // split into new decks

				lblCompCount.Text = "26";
				lblPlayerCount.Text = "26";

				Ended = false;
			}
			else if (KeyPressed == '\u001b') // escape key pressed
			{
				this.Close();
			}
		}

		private void createDeck()
		{
			string[] cardNames = {"2 of ", "3 of ", "4 of ", "5 of ", "6 of ", "7 of ", "8 of ", "9 of ", "10 of ", "jack of ", "queen of ", "king of ", "ace of "};
			string[] suits = { "diamonds", "clubs", "hearts", "spades" };
			int cardValue = 2;
			foreach (string cardName in cardNames) // for each number/face card...
			{
				foreach (string suit in suits) // add each suit of that card then add it to the deck
				{
					Card card = new Card(); // temp card to add to list
					card.card = cardName + suit;
					card.value = cardValue;
					deck.Add(card);
				}
				cardValue++;
			}
		}

		private void shuffleDeck(out List<Card> shuffledDeck)
		{
			Random rng = new Random();
			shuffledDeck = deck.OrderBy(_ => rng.Next()).ToList(); // shuffle the deck
		}

		private static void Split(List<Card> list, int index, out List<Card> first, out List<Card> second)
		{
			first = list.Take(index).ToList();
			second = list.Skip(index).ToList();
		}

		private static void splitDeck(List<Card> fullDeck, out List<Card> firstHalf, out List<Card> secondHalf)
		{
			Split(fullDeck, fullDeck.Count / 2, out firstHalf, out secondHalf);
		}

		private static void normal(ref List<Card> winningDeck, ref List<Card> losingDeck)
		{
			Card winCard = winningDeck[0]; // temp cards that will get transfered to the end of the winning deck
			Card loseCard = losingDeck[0];

			winningDeck.RemoveAt(0); // remove cards from the top of the decks
			losingDeck.RemoveAt(0);

			winningDeck.Add(winCard); // add both to the end of the winning deck
			winningDeck.Add(loseCard);
		}

		private static void war(ref List<Card> Deck1, ref List<Card> Deck2, ref List<Card> cardsWon)
		{
			cardsWon.AddRange(Deck1.Take(4).ToList()); // add cards to temp list, only take 4 for now as the 5th needs to be tested for another possible war again
			cardsWon.AddRange(Deck2.Take(4).ToList());

			Deck1.RemoveRange(0, 4); // removes the 4 cards used from both decks
			Deck2.RemoveRange(0, 4);
		}

		private void warGUI()
		{
			for (int i = 0; i < 2; i++) // for each side (computer and player)...
			{
				Bitmap cardBack = new Bitmap(dirname + "back.png"); // create face down card image
				for (int j = 0; j < 3; j++)
				{
					if (i == 0) // for computer side
					{
						int cardGap = 15; // gap between face down cards
						if (j == 0) cardGap = 83; // first card has a larger gap before the face down cards get stacked

						PictureBox faceDown = new PictureBox();
						faceDown.Location = new Point(compX, compY -= cardGap);
						faceDown.Image = cardBack;
						faceDown.Size = new Size(55, 80);
						faceDown.SizeMode = PictureBoxSizeMode.StretchImage;
						this.Controls.Add(faceDown);
						compDisplays.Add(faceDown);
					}
					else // for player side
					{
						int cardGap = 15;
						if (j == 0) cardGap = 83; // first card has a larger gap before the face down cards get stacked

						PictureBox faceDown = new PictureBox();
						faceDown.Location = new Point(playX, playY += cardGap);
						faceDown.Image = cardBack;
						faceDown.Size = new Size(55, 80);
						faceDown.SizeMode = PictureBoxSizeMode.StretchImage;
						this.Controls.Add(faceDown);
						playDisplays.Add(faceDown);
					}
				}

				if (i == 0) // computer's war card (face up)
				{
					PictureBox war = new PictureBox();
					Bitmap cardImage = new Bitmap(dirname + computerDeck[0].card.Replace(' ', '_') + ".png");
					war.Location = new Point(compX, compY -= 83);
					war.Image = cardImage;
					war.Size = new Size(55, 80);
					war.SizeMode = PictureBoxSizeMode.StretchImage;
					war.BackColor = Color.White;
					war.Image.RotateFlip(RotateFlipType.RotateNoneFlipXY); // computer card is flipped vertically
					this.Controls.Add(war);
					compDisplays.Add(war);
				}
				else // player's war card
				{
					PictureBox war = new PictureBox();
					Bitmap cardImage = new Bitmap(dirname + playerDeck[0].card.Replace(' ', '_') + ".png");
					war.Location = new Point(playX, playY += 83);
					war.Image = cardImage;
					war.Size = new Size(55, 80);
					war.SizeMode = PictureBoxSizeMode.StretchImage;
					war.BackColor = Color.White;
					this.Controls.Add(war);
					playDisplays.Add(war);
				}
			}
				compDisplays[compDisplays.Count - 3].SendToBack(); // layer stacked face down cards correctly
				compDisplays[compDisplays.Count - 4].SendToBack();
				playDisplays[playDisplays.Count - 3].SendToBack();
				playDisplays[playDisplays.Count - 4].SendToBack();
		}

		private void resetWar()
		{
			int playDisplayCount = playDisplays.Count - 1; // needs to be a variable as the count property changes in the for loop, and - 1 as the first label is kept
			for (int i = 0; i < playDisplayCount; i++)
			{
				this.Controls.Remove(playDisplays[1]); // remove from form
				playDisplays[1].Dispose();
				playDisplays.RemoveAt(1); // uses 1 as when an object is removed, everything below shifts up to replace it
			}

			int compDisplayCount = compDisplays.Count - 1;
			for(int i = 0;i < compDisplayCount; i++)
			{
				this.Controls.Remove(compDisplays[1]);
				compDisplays[1].Dispose();
				compDisplays.RemoveAt(1);
			}
			lblWar.Visible = false;
		}

		private void winText()
		{
			lblWinLoss.Text = "Win!";
			lblWinLoss.ForeColor = Color.Lime;
		}

		private void lossText()
		{
			lblWinLoss.Text = "Loss!";
			lblWinLoss.ForeColor = Color.Red;
		}

		private void drawText()
		{
			lblWar.Visible = true;
		}

		private void EndGame()
		{
			resetWar();
			playerCard1.Visible = false;
			compCard1.Visible = false;
			Ended = true;
			messageText = "Press [Enter] To Restart"; // changes the start text into a restart text
			tmrStartMessage.Enabled = true;
			increasing = true;
			
			if (playerDeck.Count > computerDeck.Count)
			{
				lblPlayerCount.Text = "52";
				lblCompCount.Text = "0";
				lblWin.Visible = true;
				lblWinMessage.Visible = true;
				lblWinMessage.BringToFront();
				lblWinLoss.Visible = false;
			}
			else
			{
				lblPlayerCount.Text = "0";
				lblCompCount.Text = "52";
				lblLose.Visible = true;
				lblLoseMessage.Visible = true;
				lblLoseMessage.BringToFront();
				lblWinLoss.Visible = false;
			}
		}

		private void frmWarGame_Paint(object sender, PaintEventArgs e)
		{
			message = e.Graphics;
			message.DrawString(messageText, new Font("Segoe Print", 24, FontStyle.Bold), new SolidBrush(Color.FromArgb(opacity, Color.White)), 295, 786);
		}

		private void tmrStartMessage_Tick(object sender, EventArgs e)
		{
			Invalidate(); // calls paint event

			if (increasing) // increasing determines if 5 will be added or subtracted from the opacity, allowing it to blink back and forth between opaque and transparent
			{
				opacity += 5;
			}
			else
			{
				opacity -= 5;
			}

			if (opacity == 255)
			{
				increasing = false;
			}
			else if (opacity == 0)
			{
				increasing = true;
			}
		}
	}
}