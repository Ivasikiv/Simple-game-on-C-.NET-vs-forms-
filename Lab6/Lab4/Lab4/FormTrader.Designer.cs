namespace Lab6 {
    partial class FormTrader {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelArtifacts = new Label();
            labelCoins = new Label();
            pictureBoxArtifact = new PictureBox();
            pictureBoxCoin = new PictureBox();
            pictureBox3 = new PictureBox();
            labelBack = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            labelUpgradePower = new Label();
            labelUpgradeProtection = new Label();
            labelUpgradeCritHit = new Label();
            buttonUpgradePower = new Button();
            buttonUpgradeProtection = new Button();
            buttonUpgradeCritHit = new Button();
            pictureBoxArtifactSell = new PictureBox();
            labelArtifactsValue = new Label();
            buttonSellArtifacts = new Button();
            labelArtifactAmount = new Label();
            buttonAddArtifact = new Button();
            buttonRemoveArtifact = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArtifact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArtifactSell).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.trader;
            pictureBox1.Location = new Point(618, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 405);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.monitor;
            pictureBox2.Location = new Point(-4, 139);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(631, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
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
            labelArtifacts.TabIndex = 13;
            labelArtifacts.Text = "0";
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
            labelCoins.TabIndex = 12;
            labelCoins.Text = "1000";
            // 
            // pictureBoxArtifact
            // 
            pictureBoxArtifact.Image = Properties.Resources.artifact;
            pictureBoxArtifact.Location = new Point(12, 58);
            pictureBoxArtifact.Name = "pictureBoxArtifact";
            pictureBoxArtifact.Size = new Size(48, 40);
            pictureBoxArtifact.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxArtifact.TabIndex = 11;
            pictureBoxArtifact.TabStop = false;
            // 
            // pictureBoxCoin
            // 
            pictureBoxCoin.Image = Properties.Resources.coin;
            pictureBoxCoin.Location = new Point(12, 12);
            pictureBoxCoin.Name = "pictureBoxCoin";
            pictureBoxCoin.Size = new Size(40, 40);
            pictureBoxCoin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCoin.TabIndex = 10;
            pictureBoxCoin.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.blue_arrow;
            pictureBox3.Location = new Point(868, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // labelBack
            // 
            labelBack.AutoSize = true;
            labelBack.BackColor = Color.White;
            labelBack.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBack.ForeColor = SystemColors.ButtonHighlight;
            labelBack.Location = new Point(906, 20);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(59, 25);
            labelBack.TabIndex = 16;
            labelBack.Text = "Back";
            labelBack.Click += labelBack_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.blaster;
            pictureBox4.Location = new Point(52, 210);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.shield;
            pictureBox5.Location = new Point(43, 298);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.criticalHit;
            pictureBox6.Location = new Point(52, 393);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(61, 62);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // labelUpgradePower
            // 
            labelUpgradePower.AutoSize = true;
            labelUpgradePower.BackColor = Color.Black;
            labelUpgradePower.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUpgradePower.ForeColor = SystemColors.ButtonHighlight;
            labelUpgradePower.Location = new Point(133, 210);
            labelUpgradePower.Name = "labelUpgradePower";
            labelUpgradePower.Size = new Size(124, 25);
            labelUpgradePower.TabIndex = 20;
            labelUpgradePower.Text = "Power lvl: 0";
            // 
            // labelUpgradeProtection
            // 
            labelUpgradeProtection.AutoSize = true;
            labelUpgradeProtection.BackColor = Color.Black;
            labelUpgradeProtection.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUpgradeProtection.ForeColor = SystemColors.ButtonHighlight;
            labelUpgradeProtection.Location = new Point(133, 298);
            labelUpgradeProtection.Name = "labelUpgradeProtection";
            labelUpgradeProtection.Size = new Size(161, 25);
            labelUpgradeProtection.TabIndex = 21;
            labelUpgradeProtection.Text = "Protection: 0 ss";
            // 
            // labelUpgradeCritHit
            // 
            labelUpgradeCritHit.AutoSize = true;
            labelUpgradeCritHit.BackColor = Color.Black;
            labelUpgradeCritHit.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUpgradeCritHit.ForeColor = SystemColors.ButtonHighlight;
            labelUpgradeCritHit.Location = new Point(133, 393);
            labelUpgradeCritHit.Name = "labelUpgradeCritHit";
            labelUpgradeCritHit.Size = new Size(152, 25);
            labelUpgradeCritHit.TabIndex = 22;
            labelUpgradeCritHit.Text = "Critical hit: 0%";
            // 
            // buttonUpgradePower
            // 
            buttonUpgradePower.BackColor = SystemColors.Window;
            buttonUpgradePower.FlatStyle = FlatStyle.Flat;
            buttonUpgradePower.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpgradePower.Location = new Point(133, 243);
            buttonUpgradePower.Name = "buttonUpgradePower";
            buttonUpgradePower.Size = new Size(194, 29);
            buttonUpgradePower.TabIndex = 23;
            buttonUpgradePower.Text = "Upgrade: 250 coins";
            buttonUpgradePower.UseVisualStyleBackColor = false;
            buttonUpgradePower.Click += buttonUpgradePower_Click;
            // 
            // buttonUpgradeProtection
            // 
            buttonUpgradeProtection.BackColor = SystemColors.Window;
            buttonUpgradeProtection.FlatStyle = FlatStyle.Flat;
            buttonUpgradeProtection.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpgradeProtection.Location = new Point(133, 331);
            buttonUpgradeProtection.Name = "buttonUpgradeProtection";
            buttonUpgradeProtection.Size = new Size(194, 29);
            buttonUpgradeProtection.TabIndex = 24;
            buttonUpgradeProtection.Text = "Upgrade: 250 coins";
            buttonUpgradeProtection.UseVisualStyleBackColor = false;
            buttonUpgradeProtection.Click += buttonUpgradeProtection_Click;
            // 
            // buttonUpgradeCritHit
            // 
            buttonUpgradeCritHit.BackColor = SystemColors.Window;
            buttonUpgradeCritHit.FlatStyle = FlatStyle.Flat;
            buttonUpgradeCritHit.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpgradeCritHit.Location = new Point(133, 426);
            buttonUpgradeCritHit.Name = "buttonUpgradeCritHit";
            buttonUpgradeCritHit.Size = new Size(194, 29);
            buttonUpgradeCritHit.TabIndex = 25;
            buttonUpgradeCritHit.Text = "Upgrade: 250 coins";
            buttonUpgradeCritHit.UseVisualStyleBackColor = false;
            buttonUpgradeCritHit.Click += buttonUpgradeCritHit_Click;
            // 
            // pictureBoxArtifactSell
            // 
            pictureBoxArtifactSell.BackColor = SystemColors.Control;
            pictureBoxArtifactSell.Image = Properties.Resources.artifact;
            pictureBoxArtifactSell.Location = new Point(439, 210);
            pictureBoxArtifactSell.Name = "pictureBoxArtifactSell";
            pictureBoxArtifactSell.Size = new Size(84, 62);
            pictureBoxArtifactSell.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxArtifactSell.TabIndex = 26;
            pictureBoxArtifactSell.TabStop = false;
            // 
            // labelArtifactsValue
            // 
            labelArtifactsValue.AutoSize = true;
            labelArtifactsValue.BackColor = Color.Black;
            labelArtifactsValue.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelArtifactsValue.ForeColor = SystemColors.ButtonHighlight;
            labelArtifactsValue.Location = new Point(403, 298);
            labelArtifactsValue.Name = "labelArtifactsValue";
            labelArtifactsValue.Size = new Size(146, 25);
            labelArtifactsValue.TabIndex = 27;
            labelArtifactsValue.Text = "Value: 0 coins";
            // 
            // buttonSellArtifacts
            // 
            buttonSellArtifacts.BackColor = SystemColors.Window;
            buttonSellArtifacts.FlatStyle = FlatStyle.Flat;
            buttonSellArtifacts.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSellArtifacts.Location = new Point(439, 392);
            buttonSellArtifacts.Name = "buttonSellArtifacts";
            buttonSellArtifacts.Size = new Size(74, 29);
            buttonSellArtifacts.TabIndex = 28;
            buttonSellArtifacts.Text = "Sell";
            buttonSellArtifacts.UseVisualStyleBackColor = false;
            buttonSellArtifacts.Click += buttonSellArtifacts_Click;
            // 
            // labelArtifactAmount
            // 
            labelArtifactAmount.AutoSize = true;
            labelArtifactAmount.BackColor = Color.Black;
            labelArtifactAmount.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelArtifactAmount.ForeColor = SystemColors.ButtonHighlight;
            labelArtifactAmount.Location = new Point(403, 344);
            labelArtifactAmount.Name = "labelArtifactAmount";
            labelArtifactAmount.Size = new Size(49, 25);
            labelArtifactAmount.TabIndex = 31;
            labelArtifactAmount.Text = "0    ";
            // 
            // buttonAddArtifact
            // 
            buttonAddArtifact.FlatStyle = FlatStyle.Flat;
            buttonAddArtifact.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddArtifact.Location = new Point(476, 344);
            buttonAddArtifact.Name = "buttonAddArtifact";
            buttonAddArtifact.Size = new Size(32, 25);
            buttonAddArtifact.TabIndex = 32;
            buttonAddArtifact.Text = "+";
            buttonAddArtifact.UseVisualStyleBackColor = true;
            buttonAddArtifact.Click += buttonAddArtifact_Click;
            // 
            // buttonRemoveArtifact
            // 
            buttonRemoveArtifact.FlatStyle = FlatStyle.Flat;
            buttonRemoveArtifact.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemoveArtifact.Location = new Point(514, 344);
            buttonRemoveArtifact.Name = "buttonRemoveArtifact";
            buttonRemoveArtifact.Size = new Size(32, 25);
            buttonRemoveArtifact.TabIndex = 33;
            buttonRemoveArtifact.Text = "-";
            buttonRemoveArtifact.UseVisualStyleBackColor = true;
            buttonRemoveArtifact.Click += buttonRemoveArtifact_Click;
            // 
            // FormTrader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RockerBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 613);
            Controls.Add(buttonRemoveArtifact);
            Controls.Add(buttonAddArtifact);
            Controls.Add(labelArtifactAmount);
            Controls.Add(buttonSellArtifacts);
            Controls.Add(labelArtifactsValue);
            Controls.Add(pictureBoxArtifactSell);
            Controls.Add(buttonUpgradeCritHit);
            Controls.Add(buttonUpgradeProtection);
            Controls.Add(buttonUpgradePower);
            Controls.Add(labelUpgradeCritHit);
            Controls.Add(labelUpgradeProtection);
            Controls.Add(labelUpgradePower);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(labelBack);
            Controls.Add(pictureBox3);
            Controls.Add(labelArtifacts);
            Controls.Add(labelCoins);
            Controls.Add(pictureBoxArtifact);
            Controls.Add(pictureBoxCoin);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "FormTrader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTrader";
            Shown += FormTrader_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArtifact).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArtifactSell).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelArtifacts;
        private Label labelCoins;
        private PictureBox pictureBoxArtifact;
        private PictureBox pictureBoxCoin;
        private PictureBox pictureBox3;
        private Label labelBack;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label labelUpgradePower;
        private Label labelUpgradeProtection;
        private Label labelUpgradeCritHit;
        private Button buttonUpgradePower;
        private Button buttonUpgradeProtection;
        private Button buttonUpgradeCritHit;
        private PictureBox pictureBoxArtifactSell;
        private Label labelArtifactsValue;
        private Button buttonSellArtifacts;
        private Label labelArtifactAmount;
        private Button buttonAddArtifact;
        private Button buttonRemoveArtifact;
    }
}