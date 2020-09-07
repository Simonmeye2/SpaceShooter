
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace List
{
    class Boss
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image bossImage;//variable for the planet's image

        public Rectangle BossRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Boss()
        {
            x = 20;
            y = 10;
            width = 150;
            height = 150;
            bossImage = Properties.Resources.boss;
            BossRec = new Rectangle(x, y, width, height);
        }
        public void drawBoss(Graphics b)
        {
            bossImage = Properties.Resources.boss;
        }
        // Methods for the Planet class
        public void draw(Graphics b)
        {
            BossRec = new Rectangle(x, y, width, height);
            b.DrawImage(bossImage, BossRec);
        }
    }
}
