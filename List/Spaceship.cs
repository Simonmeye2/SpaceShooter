using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace List
{
    class Spaceship
    {
        public int x, y, width, height;//variables for the rectangle
        public Image spaceship;//variable for the spaceship's image

        public Rectangle spaceRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Spaceship()
        {
            x = 10;
            y = 520;
            width = 73;
            height = 69;
            
            spaceRec = new Rectangle(x, y, width, height);
        }

        public void drawSpaceship(Graphics g, int spaceshipID)
        {
            if (spaceshipID == 1)
            {
                spaceship = Properties.Resources.spaceship_blue;
            }
            else if (spaceshipID == 2)
            {
                spaceship = Properties.Resources.spaceship_gray;
               
            }
            else if (spaceshipID == 3)
            {
                spaceship = Properties.Resources.spaceship_green;

            }
            else if (spaceshipID == 4)
            {
                spaceship = Properties.Resources.spaceship_red;
            }

            g.DrawImage(spaceship, spaceRec);
        }

        public void moveSpaceship(int mouseX)
        {
            spaceRec.X = mouseX - (spaceRec.Width / 2);

        }
        public void MoveSpaceship(string move)
        {
            spaceRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (spaceRec.Location.X > 450) // is spaceship within 50 of right side
                {

                    x = 450;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    spaceRec.Location = new Point(x, y);
                }

            }


            if (move == "left")
            {
                if (spaceRec.Location.X < 10) // is spaceship within 10 of left side
                {

                    x = 10;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 5;
                    spaceRec.Location = new Point(x, y);
                }

            }

        }

    }
}
