namespace Lab6 {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBoxCoin = new PictureBox();
            pictureBoxArtifact = new PictureBox();
            labelCoins = new Label();
            labelArtifacts = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArtifact).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.blue_planet;
            pictureBox1.Location = new Point(448, 335);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.orange_planet;
            pictureBox2.Location = new Point(500, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pink_planet;
            pictureBox3.Location = new Point(816, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(135, 131);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.red_planet;
            pictureBox4.Location = new Point(680, 389);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 112);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.yellow_planet;
            pictureBox5.Location = new Point(680, 224);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(205, 106);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.rocket;
            pictureBox6.Location = new Point(12, 259);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(317, 342);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBoxCoin
            // 
            pictureBoxCoin.Image = Properties.Resources.coin;
            pictureBoxCoin.Location = new Point(12, 12);
            pictureBoxCoin.Name = "pictureBoxCoin";
            pictureBoxCoin.Size = new Size(40, 40);
            pictureBoxCoin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCoin.TabIndex = 6;
            pictureBoxCoin.TabStop = false;
            // 
            // pictureBoxArtifact
            // 
            pictureBoxArtifact.Image = Properties.Resources.artifact;
            pictureBoxArtifact.Location = new Point(12, 58);
            pictureBoxArtifact.Name = "pictureBoxArtifact";
            pictureBoxArtifact.Size = new Size(48, 40);
            pictureBoxArtifact.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxArtifact.TabIndex = 7;
            pictureBoxArtifact.TabStop = false;
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.BackColor = Color.White;
            labelCoins.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCoins.ForeColor = SystemColors.ButtonHighlight;
            labelCoins.Location = new Point(68, 20);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(64, 25);
            labelCoins.TabIndex = 8;
            labelCoins.Text = "1000";
            // 
            // labelArtifacts
            // 
            labelArtifacts.AutoSize = true;
            labelArtifacts.BackColor = Color.White;
            labelArtifacts.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelArtifacts.ForeColor = SystemColors.ButtonHighlight;
            labelArtifacts.Location = new Point(68, 65);
            labelArtifacts.Name = "labelArtifacts";
            labelArtifacts.Size = new Size(25, 25);
            labelArtifacts.TabIndex = 9;
            labelArtifacts.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 613);
            Controls.Add(labelArtifacts);
            Controls.Add(labelCoins);
            Controls.Add(pictureBoxArtifact);
            Controls.Add(pictureBoxCoin);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My awesome game";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArtifact).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBoxCoin;
        private PictureBox pictureBoxArtifact;
        private Label labelCoins;
        private Label labelArtifacts;
    }
}