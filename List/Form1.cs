﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Text;
using System.Globalization;

namespace List
{
    public partial class Form1 : Form
    {
        Spaceship spaceship = new Spaceship();
        Boss boss = new Boss();

        List<Missile> missiles = new List<Missile>();
        List<Planet> planets = new List<Planet>();

        bool left, right, stop;
        string move;
        int score = 0;
        int spaceshipID = 1;
        int lives = 10;
        int Missiles = 20;
        //int bossy = 0;
        int bossMove;
        public int x, y, width, height;//variables for the rectangle
        bool checkMissileCount = true;
        bool otherCheckMissileCount = true;
        bool Startgame = false;
        //bool Bosslevel = false;
        bool NextWave = false;
        bool planetenable = true;
        int wave = 1;

        Random planetspeed = new Random();
        Random yspeed = new Random();
        Random bossMovement = new Random();

        Image bossImage;
        Rectangle bossRect;

        Image laserImage;
        Rectangle laserRect;

        public Form1()
        {

            bossImage = Properties.Resources.boss;
            bossRect = new Rectangle(ClientSize.Width / 2, 0, 150, 150);

            laserImage = Properties.Resources.laser;
            laserRect = new Rectangle(bossRect.X, 0, 100, 600);

            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            for (int i = 0; i < 20; i++)
            {
                int displacement = 10 + (i * 70);
                y = planetspeed.Next(1, 5);
                planets.Add(new Planet(displacement));

            }
            TmrBoss.Enabled = false;

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(bossImage, bossRect);

            g.DrawImage(laserImage, laserRect);

            if (Startgame == true)
            {
                spaceship.drawSpaceship(g, spaceshipID);
                foreach (Missile m in missiles)
                {
                    if (otherCheckMissileCount == true)
                    {
                        m.draw(g);
                    }
                }
            }
            if (planetenable == true)
            {
                bossRect.Location = new Point(-150, -150);
                laserRect.Location = new Point(-150, -250);

                foreach (Planet p in planets)
                {
                    if (Startgame == true)
                    {
                        p.draw(g);//Draw the planet
                        p.movePlanet(g);//move the planet
                    }
                    //if the planet reaches the bottom of the form relocate it back to the top
                    if (p.y >= ClientSize.Height && stop == false)
                    {
                        p.y = -20;
                    }
                    if (p.planetRec.IntersectsWith(spaceship.spaceRec) && stop == false)
                    {
                        //reset planet[i] back to top of panel
                        p.y = 30; // set  y value of planetRec
                        lives -= 1;// lose a life
                        txtLives.Text = lives.ToString();// display number of lives
                        CheckLives();
                    }
                    if (Missiles <= 0)
                    {
                        p.y = -50;
                        break;
                    }
                }
            }
        }
        private void Checkmissiles()
        {
            if (Missiles == 0 && checkMissileCount == true)
            {
                NextWave = true;
                if (Missiles == 0 && NextWave == true)
                {
                    wave++;
                    MessageBox.Show("Wave " + wave);
                    checkMissileCount = false;
                    otherCheckMissileCount = true;

                    Missiles = 20;

                    if (wave == 2) //stupid retard boss level
                    {
                        bossRect.Location = new Point(ClientSize.Width / 4, 0);

                        healthBar.Enabled = true;
                        healthBar.Visible = true;

                        Missiles = 30;
                        NextWave = false;
                        planetenable = false;
                        TmrBoss.Enabled = true;
                        if (Missiles == 0)
                        {
                            MessageBox.Show("The End");
                        }
                    }
                }
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            spaceship.moveSpaceship(e.X);

        }
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(spaceship.spaceRec));

                Missiles -= 1;
                txtMissiles.Text = Missiles.ToString();// display number of missiles
                Checkmissiles();
            }
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Enter) { Startgame = true; }
            if (e.KeyData == Keys.Space)
            {
                missiles.Add(new Missile(spaceship.spaceRec));
                Missiles -= 1;
                txtMissiles.Text = Missiles.ToString();// display number of missiles
                Checkmissiles();
            }
        }
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Enter) { Startgame = false; }
        }
        private void txtUserame_TextChanged(object sender, EventArgs e)

        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtuserame.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                txtuserame.Text.Remove(txtuserame.Text.Length - 5);
            }
        }
        private void stsgame_Click(object sender, EventArgs e)
        {
            Startgame = true;
            txtuserame.Visible = false;
            Userame.Visible = false;
            stsgame.Visible = false;
            spaceshipDisplay.Visible = false;
            BtnBack.Visible = false;
            
        }
        private void TmrMissiles_Tick(object sender, EventArgs e)
        {
            if (Missiles <= 1)
            {
                for (int i = 0; i < 14; i++)
                {
                    int displacement = 20 + (i * 140);
                    y = planetspeed.Next(1, 20);
                    planets.Add(new Planet(displacement));
                }
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (spaceshipID == 2)
            {
                spaceshipDisplay.BackgroundImage = Properties.Resources.spaceship_blue;
                spaceshipID = 1;
            }
            else if (spaceshipID == 3)
            {
                spaceshipDisplay.BackgroundImage = Properties.Resources.spaceship_gray;
                spaceshipID = 2;
            }
            else if (spaceshipID == 4)
            {
                spaceshipDisplay.BackgroundImage = Properties.Resources.spaceship_green;
                spaceshipID = 3;
            }
            else if (spaceshipID == 1)
            {
                spaceshipDisplay.BackgroundImage = Properties.Resources.spaceship_red;
                spaceshipID = 4;
            }
        }
        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TmrBoss_Tick(object sender, EventArgs e)
        {
            bossMove = bossMovement.Next(-40, 40);
            if (bossRect.Location.X <= ClientSize.Width)
            {
                bossRect.X += bossMove;
                laserRect.X = bossRect.X + 24;
                laserRect.Y = bossRect.Y + 50;
            }
        }
        private void stsgame_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void btnChange_Click_2(object sender, EventArgs e)
        {
            if (spaceshipID == 1)
            {
                spaceshipDisplay.BackgroundImage = Properties.Resources.spaceship_gray;
                spaceshipID = 2;
            }
            else if (spaceshipID == 2)
            {
                spaceshipDisplay.BackgroundImage = Properties.Resources.spaceship_green;
                spaceshipID = 3;
            }
            else if (spaceshipID == 3)
            {
                spaceshipDisplay.BackgroundImage = Properties.Resources.spaceship_red;
                spaceshipID = 4;
            }
            else if (spaceshipID == 4)
            {
                spaceshipDisplay.BackgroundImage = Properties.Resources.spaceship_blue;
                spaceshipID = 1;
            }
        }
        private void TmrShip_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                spaceship.MoveSpaceship(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                spaceship.MoveSpaceship(move);
            }
        }
        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrMeteor.Enabled = false;
                TmrShip.Enabled = false;
                stop = true;
                Missiles = 0;
                this.Close();
            }
        }
        private void TmrMeteor_Tick(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtLives.Text = lives.ToString();// display number of lives
        }
        private void TmrShoot_Tick(object sender, EventArgs e)
        {
            foreach (Planet p in planets)
            {

                foreach (Missile m in missiles)
                {
                    if (p.planetRec.IntersectsWith(m.missileRec))
                    {
                        p.y = -20;// relocate planet to the top of the form
                        missiles.Remove(m);
                        score = score + 5;
                        txtScore.Text = score.ToString();
                        break;
                    }
                    if (bossRect.IntersectsWith(m.missileRec))
                    {
                        healthBar.Value -= 2;
                        missiles.Remove(m);
                        break;
                    }
                    if (laserRect.IntersectsWith(spaceship.spaceRec))
                    {    
                        TmrBoss.Enabled = false;
                        TmrShip.Enabled = false;
                        planetenable = false;
                        txtLives.Text = "00";

                        laserRect.Location = new Point(0, 5000);
                        MessageBox.Show("Game Over");
                        healthBar.Visible = false;
                    }

                }
            }
            this.Invalidate();
        }
    }
}