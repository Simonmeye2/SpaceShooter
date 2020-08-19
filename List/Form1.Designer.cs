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
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.LblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.Userame = new System.Windows.Forms.Label();
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.txtuserame = new System.Windows.Forms.TextBox();
            this.stsgame = new System.Windows.Forms.Button();
            this.tmrMissiles = new System.Windows.Forms.Timer(this.components);
            this.txtLives = new System.Windows.Forms.Label();
            this.txtMissiles = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.spaceshipDisplay = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PnlGame = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.spaceshipDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrShoot
            // 
            this.tmrShoot.Enabled = true;
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
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
            this.LblLives.Location = new System.Drawing.Point(403, 9);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(32, 13);
            this.LblLives.TabIndex = 2;
            this.LblLives.Text = "Lives";
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
            // TmrPlanet
            // 
            this.TmrPlanet.Enabled = true;
            this.TmrPlanet.Interval = 10000;
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
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
            // 
            // tmrMissiles
            // 
            this.tmrMissiles.Enabled = true;
            this.tmrMissiles.Interval = 10000;
            this.tmrMissiles.Tick += new System.EventHandler(this.tmrMissiles_Tick);
            // 
            // txtLives
            // 
            this.txtLives.AutoSize = true;
            this.txtLives.BackColor = System.Drawing.Color.Transparent;
            this.txtLives.ForeColor = System.Drawing.SystemColors.Control;
            this.txtLives.Location = new System.Drawing.Point(406, 28);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(19, 13);
            this.txtLives.TabIndex = 11;
            this.txtLives.Text = "00";
            // 
            // txtMissiles
            // 
            this.txtMissiles.AutoSize = true;
            this.txtMissiles.BackColor = System.Drawing.Color.Transparent;
            this.txtMissiles.ForeColor = System.Drawing.SystemColors.Control;
            this.txtMissiles.Location = new System.Drawing.Point(24, 545);
            this.txtMissiles.Name = "txtMissiles";
            this.txtMissiles.Size = new System.Drawing.Size(19, 13);
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
            this.spaceshipDisplay.Location = new System.Drawing.Point(208, 104);
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
            this.PnlGame.Enabled = false;
            this.PnlGame.Location = new System.Drawing.Point(-1, 1);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(917, 628);
            this.PnlGame.TabIndex = 16;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::List.Properties.Resources.orion_nebula_11107_1920;
            this.ClientSize = new System.Drawing.Size(909, 589);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.spaceshipDisplay);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtMissiles);
            this.Controls.Add(this.txtLives);
            this.Controls.Add(this.stsgame);
            this.Controls.Add(this.txtuserame);
            this.Controls.Add(this.Userame);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.PnlGame);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.spaceshipDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.Timer TmrShip;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Label Userame;
        public System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.TextBox txtuserame;
        private System.Windows.Forms.Button stsgame;
        private System.Windows.Forms.Timer tmrMissiles;
        private System.Windows.Forms.Label txtLives;
        private System.Windows.Forms.Label txtMissiles;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.PictureBox spaceshipDisplay;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel PnlGame;
    }
}

