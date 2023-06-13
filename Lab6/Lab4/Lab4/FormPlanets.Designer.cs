namespace Lab6 {
    partial class FormPlanets {
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            laserTimer = new System.Windows.Forms.Timer(components);
            labelBack = new Label();
            pictureBoxBack = new PictureBox();
            timerPiratesAttack = new System.Windows.Forms.Timer(components);
            timerDamage = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // labelBack
            // 
            labelBack.AutoSize = true;
            labelBack.BackColor = Color.White;
            labelBack.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBack.ForeColor = SystemColors.ButtonHighlight;
            labelBack.Location = new Point(910, 16);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(59, 25);
            labelBack.TabIndex = 18;
            labelBack.Text = "Back";
            labelBack.Click += labelBack_Click;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Image = Properties.Resources.blue_arrow;
            pictureBoxBack.Location = new Point(872, 12);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(32, 32);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBack.TabIndex = 19;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Tag = "back";
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // timerPiratesAttack
            // 
            timerPiratesAttack.Interval = 1000;
            timerPiratesAttack.Tick += timerPiratesAttack_Tick;
            // 
            // timerDamage
            // 
            timerDamage.Interval = 250;
            timerDamage.Tick += timerDamage_Tick;
            // 
            // FormPlanets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 613);
            Controls.Add(pictureBoxBack);
            Controls.Add(labelBack);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "FormPlanets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCatalinaPlanet";
            FormClosing += FormPlanets_FormClosing;
            Load += FormPlanets_Load;
            Shown += FormPlanets_Shown;
            KeyDown += FormPlanets_KeyDown;
            KeyUp += FormPlanets_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer laserTimer;
        private Label labelBack;
        private PictureBox pictureBoxBack;
        private System.Windows.Forms.Timer timerPiratesAttack;
        private System.Windows.Forms.Timer timerDamage;
    }
}