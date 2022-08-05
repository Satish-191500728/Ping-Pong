
namespace Ping_Pong
{
    partial class PingPong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingPong));
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Ball1 = new System.Windows.Forms.PictureBox();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Winner1 = new System.Windows.Forms.Label();
            this.Winner2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball1)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Gray;
            this.Player1.Location = new System.Drawing.Point(1, 252);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(17, 108);
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Gray;
            this.Player2.Location = new System.Drawing.Point(1140, 252);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(17, 108);
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            // 
            // Ball1
            // 
            this.Ball1.BackColor = System.Drawing.Color.LightGray;
            this.Ball1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ball1.InitialImage = null;
            this.Ball1.Location = new System.Drawing.Point(562, 302);
            this.Ball1.Name = "Ball1";
            this.Ball1.Size = new System.Drawing.Size(15, 15);
            this.Ball1.TabIndex = 2;
            this.Ball1.TabStop = false;
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.BackColor = System.Drawing.Color.Silver;
            this.playerScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerScoreLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.Location = new System.Drawing.Point(173, 102);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(23, 30);
            this.playerScoreLabel.TabIndex = 5;
            this.playerScoreLabel.Text = "0";
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.BackColor = System.Drawing.Color.Silver;
            this.cpuScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpuScoreLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuScoreLabel.Location = new System.Drawing.Point(977, 102);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(23, 30);
            this.cpuScoreLabel.TabIndex = 6;
            this.cpuScoreLabel.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Winner1
            // 
            this.Winner1.AutoSize = true;
            this.Winner1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Winner1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Winner1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Winner1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner1.ForeColor = System.Drawing.Color.Red;
            this.Winner1.Location = new System.Drawing.Point(96, 23);
            this.Winner1.Name = "Winner1";
            this.Winner1.Size = new System.Drawing.Size(216, 64);
            this.Winner1.TabIndex = 7;
            this.Winner1.Text = "WINNER !!";
            // 
            // Winner2
            // 
            this.Winner2.AutoSize = true;
            this.Winner2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Winner2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Winner2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Winner2.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner2.ForeColor = System.Drawing.Color.Red;
            this.Winner2.Location = new System.Drawing.Point(853, 23);
            this.Winner2.Name = "Winner2";
            this.Winner2.Size = new System.Drawing.Size(216, 64);
            this.Winner2.TabIndex = 8;
            this.Winner2.Text = "WINNER !!";
            // 
            // PingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 697);
            this.Controls.Add(this.Winner2);
            this.Controls.Add(this.Winner1);
            this.Controls.Add(this.cpuScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.Ball1);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1173, 736);
            this.MinimumSize = new System.Drawing.Size(1173, 736);
            this.Name = "PingPong";
            this.Text = " PingPong";
            this.Load += new System.EventHandler(this.PingPong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PingPong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PingPong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.PictureBox Ball1;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label cpuScoreLabel;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label Winner1;
        private System.Windows.Forms.Label Winner2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

