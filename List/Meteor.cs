using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Meteor
    {
        public int x, y, width, height;//variables for the rectangle
        public Image meteorimage;//variable for the meteor's image
        public Rectangle meteorRec;//variable for a rectangle to place our image in
        Random Meteorspeed = new Random();

        //Create a constructor (initialises the values of the fields)
        public Meteor(int displacement)
        {
            x = displacement;
            y = 10;
            width = 40;
            height = 40;
            meteorimage = Properties.Resources.Meteor;
            meteorRec = new Rectangle(x, y, width, height);
        }
        
    }
}
