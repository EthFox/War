namespace War
{
	partial class frmWarGame
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lblWinLoss = new System.Windows.Forms.Label();
			this.lblCompCount = new System.Windows.Forms.Label();
			this.lblPlayerCount = new System.Windows.Forms.Label();
			this.compCard1 = new System.Windows.Forms.PictureBox();
			this.playerCard1 = new System.Windows.Forms.PictureBox();
			this.lblRemainingTitleComp = new System.Windows.Forms.Label();
			this.RemainingTitlePlayer = new System.Windows.Forms.Label();
			this.lblWar = new System.Windows.Forms.Label();
			this.lblWin = new System.Windows.Forms.Label();
			this.lblLose = new System.Windows.Forms.Label();
			this.lblWinMessage = new System.Windows.Forms.Label();
			this.lblLoseMessage = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tmrStartMessage = new System.Windows.Forms.Timer(this.components);
			this.lblCloseTip = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.compCard1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblWinLoss
			// 
			this.lblWinLoss.BackColor = System.Drawing.Color.Transparent;
			this.lblWinLoss.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWinLoss.ForeColor = System.Drawing.Color.Khaki;
			this.lblWinLoss.Location = new System.Drawing.Point(13, 821);
			this.lblWinLoss.Name = "lblWinLoss";
			this.lblWinLoss.Size = new System.Drawing.Size(220, 57);
			this.lblWinLoss.TabIndex = 3;
			this.lblWinLoss.Text = "Win!";
			this.lblWinLoss.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblWinLoss.Visible = false;
			// 
			// lblCompCount
			// 
			this.lblCompCount.AutoSize = true;
			this.lblCompCount.BackColor = System.Drawing.Color.Transparent;
			this.lblCompCount.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCompCount.ForeColor = System.Drawing.Color.White;
			this.lblCompCount.Location = new System.Drawing.Point(853, 46);
			this.lblCompCount.Name = "lblCompCount";
			this.lblCompCount.Size = new System.Drawing.Size(47, 37);
			this.lblCompCount.TabIndex = 6;
			this.lblCompCount.Text = "26";
			// 
			// lblPlayerCount
			// 
			this.lblPlayerCount.AutoSize = true;
			this.lblPlayerCount.BackColor = System.Drawing.Color.Transparent;
			this.lblPlayerCount.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayerCount.ForeColor = System.Drawing.Color.White;
			this.lblPlayerCount.Location = new System.Drawing.Point(100, 915);
			this.lblPlayerCount.Name = "lblPlayerCount";
			this.lblPlayerCount.Size = new System.Drawing.Size(47, 37);
			this.lblPlayerCount.TabIndex = 7;
			this.lblPlayerCount.Text = "26";
			// 
			// compCard1
			// 
			this.compCard1.BackColor = System.Drawing.Color.White;
			this.compCard1.ImageLocation = "";
			this.compCard1.Location = new System.Drawing.Point(465, 399);
			this.compCard1.Name = "compCard1";
			this.compCard1.Size = new System.Drawing.Size(55, 80);
			this.compCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.compCard1.TabIndex = 9;
			this.compCard1.TabStop = false;
			this.compCard1.Visible = false;
			// 
			// playerCard1
			// 
			this.playerCard1.BackColor = System.Drawing.Color.White;
			this.playerCard1.ImageLocation = "";
			this.playerCard1.Location = new System.Drawing.Point(465, 482);
			this.playerCard1.Name = "playerCard1";
			this.playerCard1.Size = new System.Drawing.Size(55, 80);
			this.playerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.playerCard1.TabIndex = 8;
			this.playerCard1.TabStop = false;
			this.playerCard1.Visible = false;
			// 
			// lblRemainingTitleComp
			// 
			this.lblRemainingTitleComp.AutoSize = true;
			this.lblRemainingTitleComp.BackColor = System.Drawing.Color.Transparent;
			this.lblRemainingTitleComp.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRemainingTitleComp.ForeColor = System.Drawing.Color.White;
			this.lblRemainingTitleComp.Location = new System.Drawing.Point(775, 9);
			this.lblRemainingTitleComp.Name = "lblRemainingTitleComp";
			this.lblRemainingTitleComp.Size = new System.Drawing.Size(203, 37);
			this.lblRemainingTitleComp.TabIndex = 10;
			this.lblRemainingTitleComp.Text = "Remaining Cards:";
			// 
			// RemainingTitlePlayer
			// 
			this.RemainingTitlePlayer.AutoSize = true;
			this.RemainingTitlePlayer.BackColor = System.Drawing.Color.Transparent;
			this.RemainingTitlePlayer.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RemainingTitlePlayer.ForeColor = System.Drawing.Color.White;
			this.RemainingTitlePlayer.Location = new System.Drawing.Point(22, 878);
			this.RemainingTitlePlayer.Name = "RemainingTitlePlayer";
			this.RemainingTitlePlayer.Size = new System.Drawing.Size(203, 37);
			this.RemainingTitlePlayer.TabIndex = 11;
			this.RemainingTitlePlayer.Text = "Remaining Cards:";
			// 
			// lblWar
			// 
			this.lblWar.AutoSize = true;
			this.lblWar.BackColor = System.Drawing.Color.Transparent;
			this.lblWar.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWar.ForeColor = System.Drawing.Color.White;
			this.lblWar.Location = new System.Drawing.Point(-13, 724);
			this.lblWar.Name = "lblWar";
			this.lblWar.Size = new System.Drawing.Size(272, 112);
			this.lblWar.TabIndex = 12;
			this.lblWar.Text = "WAR!!!";
			this.lblWar.Visible = false;
			// 
			// lblWin
			// 
			this.lblWin.AutoSize = true;
			this.lblWin.BackColor = System.Drawing.Color.Transparent;
			this.lblWin.Font = new System.Drawing.Font("Segoe Print", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWin.ForeColor = System.Drawing.Color.Lime;
			this.lblWin.Location = new System.Drawing.Point(240, 60);
			this.lblWin.Name = "lblWin";
			this.lblWin.Size = new System.Drawing.Size(505, 170);
			this.lblWin.TabIndex = 13;
			this.lblWin.Text = "You Win!";
			this.lblWin.Visible = false;
			// 
			// lblLose
			// 
			this.lblLose.AutoSize = true;
			this.lblLose.BackColor = System.Drawing.Color.Transparent;
			this.lblLose.Font = new System.Drawing.Font("Segoe Print", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLose.ForeColor = System.Drawing.Color.Red;
			this.lblLose.Location = new System.Drawing.Point(240, 60);
			this.lblLose.Name = "lblLose";
			this.lblLose.Size = new System.Drawing.Size(522, 170);
			this.lblLose.TabIndex = 14;
			this.lblLose.Text = "You Lose!";
			this.lblLose.Visible = false;
			// 
			// lblWinMessage
			// 
			this.lblWinMessage.AutoSize = true;
			this.lblWinMessage.BackColor = System.Drawing.Color.Transparent;
			this.lblWinMessage.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWinMessage.ForeColor = System.Drawing.Color.Lime;
			this.lblWinMessage.Location = new System.Drawing.Point(325, 188);
			this.lblWinMessage.Name = "lblWinMessage";
			this.lblWinMessage.Size = new System.Drawing.Size(335, 65);
			this.lblWinMessage.TabIndex = 15;
			this.lblWinMessage.Text = "Congratulations!";
			this.lblWinMessage.Visible = false;
			// 
			// lblLoseMessage
			// 
			this.lblLoseMessage.AutoSize = true;
			this.lblLoseMessage.BackColor = System.Drawing.Color.Transparent;
			this.lblLoseMessage.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoseMessage.ForeColor = System.Drawing.Color.Red;
			this.lblLoseMessage.Location = new System.Drawing.Point(258, 188);
			this.lblLoseMessage.Name = "lblLoseMessage";
			this.lblLoseMessage.Size = new System.Drawing.Size(468, 65);
			this.lblLoseMessage.TabIndex = 16;
			this.lblLoseMessage.Text = "Better Luck Next Time!";
			this.lblLoseMessage.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(295, 786);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(394, 57);
			this.label1.TabIndex = 17;
			this.label1.Text = "Press [Space] To Begin";
			this.label1.Visible = false;
			// 
			// tmrStartMessage
			// 
			this.tmrStartMessage.Enabled = true;
			this.tmrStartMessage.Interval = 10;
			this.tmrStartMessage.Tick += new System.EventHandler(this.tmrStartMessage_Tick);
			// 
			// lblCloseTip
			// 
			this.lblCloseTip.AutoSize = true;
			this.lblCloseTip.BackColor = System.Drawing.Color.Transparent;
			this.lblCloseTip.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCloseTip.ForeColor = System.Drawing.Color.White;
			this.lblCloseTip.Location = new System.Drawing.Point(12, 9);
			this.lblCloseTip.Name = "lblCloseTip";
			this.lblCloseTip.Size = new System.Drawing.Size(180, 28);
			this.lblCloseTip.TabIndex = 18;
			this.lblCloseTip.Text = "Press Escape to Close";
			// 
			// frmWarGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LimeGreen;
			this.BackgroundImage = global::War.Properties.Resources.GreenBG;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(984, 961);
			this.Controls.Add(this.lblCloseTip);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblLoseMessage);
			this.Controls.Add(this.lblWinMessage);
			this.Controls.Add(this.lblLose);
			this.Controls.Add(this.lblWin);
			this.Controls.Add(this.lblWar);
			this.Controls.Add(this.RemainingTitlePlayer);
			this.Controls.Add(this.lblRemainingTitleComp);
			this.Controls.Add(this.compCard1);
			this.Controls.Add(this.playerCard1);
			this.Controls.Add(this.lblPlayerCount);
			this.Controls.Add(this.lblCompCount);
			this.Controls.Add(this.lblWinLoss);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "frmWarGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "War";
			this.Load += new System.EventHandler(this.frmWarGame_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmWarGame_Paint);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmWarGame_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.compCard1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblWinLoss;
		private System.Windows.Forms.Label lblCompCount;
		private System.Windows.Forms.Label lblPlayerCount;
		private System.Windows.Forms.PictureBox playerCard1;
		private System.Windows.Forms.PictureBox compCard1;
		private System.Windows.Forms.Label lblRemainingTitleComp;
		private System.Windows.Forms.Label RemainingTitlePlayer;
		private System.Windows.Forms.Label lblWar;
		private System.Windows.Forms.Label lblWin;
		private System.Windows.Forms.Label lblLose;
		private System.Windows.Forms.Label lblWinMessage;
		private System.Windows.Forms.Label lblLoseMessage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer tmrStartMessage;
		private System.Windows.Forms.Label lblCloseTip;
	}
}

