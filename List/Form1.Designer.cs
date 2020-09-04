namespace List
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
            this.TmrShoot = new System.Windows.Forms.Timer(this.components);
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.LblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.Userame = new System.Windows.Forms.Label();
            this.TmrMeteor = new System.Windows.Forms.Timer(this.components);
            this.txtuserame = new System.Windows.Forms.TextBox();
            this.stsgame = new System.Windows.Forms.Button();
            this.TmrMissiles = new System.Windows.Forms.Timer(this.components);
            this.txtLives = new System.Windows.Forms.Label();
            this.txtMissiles = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.spaceshipDisplay = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.bossframe = new System.Windows.Forms.PictureBox();
            this.TmrBoss = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spaceshipDisplay)).BeginInit();
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bossframe)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrShoot
            // 
            this.TmrShoot.Enabled = true;
            this.TmrShoot.Tick += new System.EventHandler(this.TmrShoot_Tick);
            // 
            // TmrShip
            // 
            this.TmrShip.Enabled = true;
            this.TmrShip.Interval = 50;
            this.TmrShip.Tick += new System.EventHandler(this.TmrShip_Tick);
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.BackColor = System.Drawing.Color.Transparent;
            this.LblScore.ForeColor = System.Drawing.SystemColors.Control;
            this.LblScore.Location = new System.Drawing.Point(12, 9);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(35, 13);
            this.LblScore.TabIndex = 0;
            this.LblScore.Text = "Score";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.ForeColor = System.Drawing.SystemColors.Control;
            this.txtScore.Location = new System.Drawing.Point(21, 29);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(13, 13);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.BackColor = System.Drawing.Color.Transparent;
            this.LblLives.ForeColor = System.Drawing.SystemColors.Control;
            this.LblLives.Location = new System.Drawing.Point(19, 89);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(22, 13);
            this.LblLives.TabIndex = 2;
            this.LblLives.Text = "HP";
            // 
            // Userame
            // 
            this.Userame.AutoSize = true;
            this.Userame.BackColor = System.Drawing.Color.Transparent;
            this.Userame.ForeColor = System.Drawing.SystemColors.Control;
            this.Userame.Location = new System.Drawing.Point(718, 9);
            this.Userame.Name = "Userame";
            this.Userame.Size = new System.Drawing.Size(179, 13);
            this.Userame.TabIndex = 6;
            this.Userame.Text = "UsernName ( is required before start)";
            this.Userame.Click += new System.EventHandler(this.txtUserame_TextChanged);
            // 
            // TmrMeteor
            // 
            this.TmrMeteor.Enabled = true;
            this.TmrMeteor.Interval = 10000;
            this.TmrMeteor.Tick += new System.EventHandler(this.TmrMeteor_Tick);
            // 
            // txtuserame
            // 
            this.txtuserame.Location = new System.Drawing.Point(736, 29);
            this.txtuserame.Name = "txtuserame";
            this.txtuserame.Size = new System.Drawing.Size(100, 20);
            this.txtuserame.TabIndex = 9;
            this.txtuserame.TextChanged += new System.EventHandler(this.txtUserame_TextChanged);
            // 
            // stsgame
            // 
            this.stsgame.Location = new System.Drawing.Point(842, 27);
            this.stsgame.Name = "stsgame";
            this.stsgame.Size = new System.Drawing.Size(37, 23);
            this.stsgame.TabIndex = 10;
            this.stsgame.Text = "Start";
            this.stsgame.UseVisualStyleBackColor = true;
            this.stsgame.Click += new System.EventHandler(this.stsgame_Click);
            this.stsgame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stsgame_KeyDown);
            // 
            // TmrMissiles
            // 
            this.TmrMissiles.Enabled = true;
            this.TmrMissiles.Interval = 10000;
            this.TmrMissiles.Tick += new System.EventHandler(this.TmrMissiles_Tick);
            // 
            // txtLives
            // 
            this.txtLives.AutoSize = true;
            this.txtLives.BackColor = System.Drawing.Color.Transparent;
            this.txtLives.ForeColor = System.Drawing.SystemColors.Control;
            this.txtLives.Location = new System.Drawing.Point(20, 108);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(19, 13);
            this.txtLives.TabIndex = 11;
            this.txtLives.Text = "00";
            // 
            // txtMissiles
            // 
            this.txtMissiles.AutoSize = true;
            this.txtMissiles.BackColor = System.Drawing.Color.Transparent;
            this.txtMissiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMissiles.ForeColor = System.Drawing.SystemColors.Control;
            this.txtMissiles.Location = new System.Drawing.Point(12, 560);
            this.txtMissiles.Name = "txtMissiles";
            this.txtMissiles.Size = new System.Drawing.Size(27, 20);
            this.txtMissiles.TabIndex = 12;
            this.txtMissiles.Text = "20";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.Location = new System.Drawing.Point(717, 291);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Next";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // spaceshipDisplay
            // 
            this.spaceshipDisplay.BackColor = System.Drawing.Color.Transparent;
            this.spaceshipDisplay.BackgroundImage = global::List.Properties.Resources.spaceship_blue;
            this.spaceshipDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.spaceshipDisplay.Location = new System.Drawing.Point(205, 108);
            this.spaceshipDisplay.Name = "spaceshipDisplay";
            this.spaceshipDisplay.Size = new System.Drawing.Size(503, 377);
            this.spaceshipDisplay.TabIndex = 14;
            this.spaceshipDisplay.TabStop = false;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(123, 291);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 15;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Transparent;
            this.PnlGame.Controls.Add(this.healthBar);
            this.PnlGame.Controls.Add(this.bossframe);
            this.PnlGame.Controls.Add(this.spaceshipDisplay);
            this.PnlGame.Controls.Add(this.txtMissiles);
            this.PnlGame.Controls.Add(this.LblLives);
            this.PnlGame.Controls.Add(this.txtLives);
            this.PnlGame.Enabled = false;
            this.PnlGame.Location = new System.Drawing.Point(-1, 0);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(917, 628);
            this.PnlGame.TabIndex = 16;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.Color.Red;
            this.healthBar.Enabled = false;
            this.healthBar.ForeColor = System.Drawing.Color.Lime;
            this.healthBar.Location = new System.Drawing.Point(57, 560);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(841, 21);
            this.healthBar.TabIndex = 17;
            this.healthBar.Value = 100;
            this.healthBar.Visible = false;
            // 
            // bossframe
            // 
            this.bossframe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bossframe.BackColor = System.Drawing.Color.Transparent;
            this.bossframe.BackgroundImage = global::List.Properties.Resources.boss;
            this.bossframe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bossframe.Enabled = false;
            this.bossframe.Location = new System.Drawing.Point(25, 385);
            this.bossframe.Name = "bossframe";
            this.bossframe.Size = new System.Drawing.Size(150, 150);
            this.bossframe.TabIndex = 12;
            this.bossframe.TabStop = false;
            this.bossframe.Visible = false;
            // 
            // TmrBoss
            // 
            this.TmrBoss.Enabled = true;
            this.TmrBoss.Interval = 10;
            this.TmrBoss.Tick += new System.EventHandler(this.TmrBoss_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::List.Properties.Resources.orion_nebula_11107_1920;
            this.ClientSize = new System.Drawing.Size(909, 589);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.stsgame);
            this.Controls.Add(this.txtuserame);
            this.Controls.Add(this.Userame);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.PnlGame);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.spaceshipDisplay)).EndInit();
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bossframe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TmrShoot;
        private System.Windows.Forms.Timer TmrShip;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Label Userame;
        public System.Windows.Forms.Timer TmrMeteor;
        private System.Windows.Forms.TextBox txtuserame;
        private System.Windows.Forms.Button stsgame;
        private System.Windows.Forms.Timer TmrMissiles;
        private System.Windows.Forms.Label txtLives;
        private System.Windows.Forms.Label txtMissiles;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.PictureBox spaceshipDisplay;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrBoss;
        private System.Windows.Forms.PictureBox bossframe;
        private System.Windows.Forms.ProgressBar healthBar;
    }
}

