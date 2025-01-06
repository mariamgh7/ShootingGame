namespace ShootingGameHM
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.balloon4 = new System.Windows.Forms.PictureBox();
            this.balloon3 = new System.Windows.Forms.PictureBox();
            this.balloon2 = new System.Windows.Forms.PictureBox();
            this.balloon1 = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.cloud3 = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.cloud5 = new System.Windows.Forms.PictureBox();
            this.cloud4 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cloud1
            // 
            this.cloud1.BackColor = System.Drawing.Color.Transparent;
            this.cloud1.Image = global::ShootingGameHM.Properties.Resources.cloud;
            this.cloud1.Location = new System.Drawing.Point(477, 5);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(320, 225);
            this.cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud1.TabIndex = 6;
            this.cloud1.TabStop = false;
            this.cloud1.Tag = "cloud";
            // 
            // balloon4
            // 
            this.balloon4.BackColor = System.Drawing.Color.Transparent;
            this.balloon4.Image = global::ShootingGameHM.Properties.Resources.balloon4;
            this.balloon4.Location = new System.Drawing.Point(693, 27);
            this.balloon4.Name = "balloon4";
            this.balloon4.Size = new System.Drawing.Size(58, 154);
            this.balloon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon4.TabIndex = 5;
            this.balloon4.TabStop = false;
            this.balloon4.Tag = "enemy";
            // 
            // balloon3
            // 
            this.balloon3.BackColor = System.Drawing.Color.Transparent;
            this.balloon3.Image = global::ShootingGameHM.Properties.Resources.balloon3;
            this.balloon3.Location = new System.Drawing.Point(593, 294);
            this.balloon3.Name = "balloon3";
            this.balloon3.Size = new System.Drawing.Size(58, 154);
            this.balloon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon3.TabIndex = 4;
            this.balloon3.TabStop = false;
            this.balloon3.Tag = "enemy";
            // 
            // balloon2
            // 
            this.balloon2.BackColor = System.Drawing.Color.Transparent;
            this.balloon2.Image = global::ShootingGameHM.Properties.Resources.balloon2;
            this.balloon2.Location = new System.Drawing.Point(371, 148);
            this.balloon2.Name = "balloon2";
            this.balloon2.Size = new System.Drawing.Size(58, 154);
            this.balloon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon2.TabIndex = 3;
            this.balloon2.TabStop = false;
            this.balloon2.Tag = "enemy";
            // 
            // balloon1
            // 
            this.balloon1.BackColor = System.Drawing.Color.Transparent;
            this.balloon1.Image = global::ShootingGameHM.Properties.Resources.balloon1;
            this.balloon1.Location = new System.Drawing.Point(559, 76);
            this.balloon1.Name = "balloon1";
            this.balloon1.Size = new System.Drawing.Size(58, 154);
            this.balloon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balloon1.TabIndex = 2;
            this.balloon1.TabStop = false;
            this.balloon1.Tag = "enemy";
            // 
            // bird
            // 
            this.bird.Image = global::ShootingGameHM.Properties.Resources.thisbird;
            this.bird.Location = new System.Drawing.Point(411, 55);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(92, 67);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            this.bird.Tag = "bird";
            // 
            // player
            // 
            this.player.Image = global::ShootingGameHM.Properties.Resources._11182385111;
            this.player.Location = new System.Drawing.Point(-21, 150);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(192, 144);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // cloud3
            // 
            this.cloud3.BackColor = System.Drawing.Color.Transparent;
            this.cloud3.Image = global::ShootingGameHM.Properties.Resources.cloud;
            this.cloud3.Location = new System.Drawing.Point(262, 76);
            this.cloud3.Name = "cloud3";
            this.cloud3.Size = new System.Drawing.Size(277, 200);
            this.cloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud3.TabIndex = 7;
            this.cloud3.TabStop = false;
            this.cloud3.Tag = "cloud";
            // 
            // cloud2
            // 
            this.cloud2.BackColor = System.Drawing.Color.Transparent;
            this.cloud2.Image = global::ShootingGameHM.Properties.Resources.cloud;
            this.cloud2.Location = new System.Drawing.Point(468, 223);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(320, 225);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud2.TabIndex = 8;
            this.cloud2.TabStop = false;
            this.cloud2.Tag = "cloud";
            // 
            // cloud5
            // 
            this.cloud5.BackColor = System.Drawing.Color.Transparent;
            this.cloud5.Image = global::ShootingGameHM.Properties.Resources.cloud;
            this.cloud5.Location = new System.Drawing.Point(83, 234);
            this.cloud5.Name = "cloud5";
            this.cloud5.Size = new System.Drawing.Size(320, 225);
            this.cloud5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud5.TabIndex = 9;
            this.cloud5.TabStop = false;
            this.cloud5.Tag = "cloud";
            // 
            // cloud4
            // 
            this.cloud4.BackColor = System.Drawing.Color.Transparent;
            this.cloud4.Image = global::ShootingGameHM.Properties.Resources.cloud;
            this.cloud4.Location = new System.Drawing.Point(36, -27);
            this.cloud4.Name = "cloud4";
            this.cloud4.Size = new System.Drawing.Size(340, 225);
            this.cloud4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud4.TabIndex = 10;
            this.cloud4.TabStop = false;
            this.cloud4.Tag = "cloud";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.IndianRed;
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(151, 46);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "Score : 0";
            // 
            // lblOver
            // 
            this.lblOver.AutoSize = true;
            this.lblOver.BackColor = System.Drawing.Color.Transparent;
            this.lblOver.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOver.ForeColor = System.Drawing.Color.Brown;
            this.lblOver.Location = new System.Drawing.Point(160, 182);
            this.lblOver.Name = "lblOver";
            this.lblOver.Size = new System.Drawing.Size(472, 85);
            this.lblOver.TabIndex = 12;
            this.lblOver.Text = "GAME OVER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.balloon4);
            this.Controls.Add(this.balloon3);
            this.Controls.Add(this.balloon2);
            this.Controls.Add(this.balloon1);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.player);
            this.Controls.Add(this.cloud1);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.cloud3);
            this.Controls.Add(this.cloud4);
            this.Controls.Add(this.cloud5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox balloon1;
        private System.Windows.Forms.PictureBox balloon2;
        private System.Windows.Forms.PictureBox balloon3;
        private System.Windows.Forms.PictureBox balloon4;
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.PictureBox cloud3;
        private System.Windows.Forms.PictureBox cloud2;
        private System.Windows.Forms.PictureBox cloud5;
        private System.Windows.Forms.PictureBox cloud4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblOver;
    }
}

