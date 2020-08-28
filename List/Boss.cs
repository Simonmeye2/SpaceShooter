using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List
{
    class Boss
    { // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image BossCraft;//variable for the planet's image

        public Rectangle BossRec;//variable for a rectangle to place our image in
        Random bossy = new Random();

        //Create a constructor (initialises the values of the fields)
        public Boss()
        {
            x = ((925-75) / 2);
            y = 10;
            width = 75;
            height = 75;
            BossCraft = Properties.Resources.Boss;
            BossRec = new Rectangle(x, y, width, height);

           
        }
        public void drawBosscraft(Graphics g)
        {
            BossRec = new Rectangle(x, y, width, height);
            g.DrawImage(BossCraft, BossRec);
        }
        public void moveBoss(Graphics g)
        {
            y = bossy.Next(10, 300);
            BossRec.Location = new Point(x, y);
        }
    }
}
