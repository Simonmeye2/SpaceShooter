using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace List
{
    public partial class Form1 : Form
    {
        Graphics g; //declare a graphics object called g
        Spaceship spaceship = new Spaceship();//create object called spaceship 
                                              //declare a list  missiles from the missile class
        List<Missile> missiles = new List<Missile>();
        // declare space for an array of 7 objects called planet 
        List<Planet> planets = new List<Planet>();
        Random yspeed = new Random();


        bool left, right,stop;
        string move;
        int score = 0;
        int spaceshipID = 1;
        int lives = 10;
        int Missiles = 20;
        int level = 1;
        public int x, y, width, height;//variables for the rectangle
        bool checkMissileCount = true;
        bool otherCheckMissileCount = true;
        bool Startgame = false;
        
        Random planetspeed = new Random();






        public Form1()
        {

            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            for (int i = 0; i < 20; i++)
            {
                int displacement = 10 + (i * 70);
                y = planetspeed.Next(1, 5);
                planets.Add(new Planet(displacement));

            }

        
        }

            private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
                g = e.Graphics;
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



                foreach (Planet p in planets)
                {
                if (Startgame == true)
                {
                    p.draw(g);//Draw the planet
                    p.movePlanet(g);//move the planet\
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
                        p.y = -30;
                    break;
                    }
                }
            }
        
        private void Checkmissiles()
        {
            if (Missiles == 0 && checkMissileCount == true)
            { 
                checkMissileCount = false;
                MessageBox.Show("next level");
                level += 1;




            }
            if (Missiles == 0 && checkMissileCount == false)
            {
                otherCheckMissileCount = false;
            }
            txtMissiles.Text = Missiles.ToString();// display number of missiles

            if (Missiles == 0 && TmrPlanet.Enabled == true)
            {
                TmrPlanet.Enabled = false;
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
                txtuserame.Text.Remove(txtuserame.Text.Length -5);
               
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
            btnChange.Visible = false;
           
            
        }

        private void tmrMissiles_Tick(object sender, EventArgs e)
        {
            if( Missiles <= 1)
            {
                for (int i = 0; i < 14; i++)
                {
                    int displacement = 20 + (i * 140);
                    y = planetspeed.Next(1, 20);
                    planets.Add(new Planet(displacement));

                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
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
            else if( spaceshipID == 4)
            {
                spaceshipDisplay.BackgroundImage = Properties.Resources.spaceship_blue;
                spaceshipID = 1;

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
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                stop = true;
                Missiles = 0;
                MessageBox.Show("Game Over");
                this.Close();

            }
        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
           
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            txtLives.Text = lives.ToString();// display number of lives
          
           
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
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
                    if (m.missileRec.IntersectsWith(p.planetRec))
                    {
                        m.y = -20;// relocate planet to the top of the form
                        planets.Remove(p);
                        score = score + 5;
                        txtScore.Text = score.ToString();
                        break;
                    }

                }
            }
            
            this.Invalidate();
           
        }

        
    }
}
