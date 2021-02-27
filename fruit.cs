using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Fruit
    {
        public int x;
        public int y;
        public int segment;

        public void newFruit()
        {
            Random random = new Random();
            x = random.Next(0, 20) * segment;
            y = random.Next(0, 20) * segment;
        }

        public Fruit(int segment)
        {
            this.segment = segment;
            newFruit();
        }

        public bool ifNewFruit(int xHead, int yHead)
        {
            if(x == xHead && y == yHead)
            {
                newFruit();
                return true;
            }
            return false;
        }
        
        public void drawFruit(Graphics g, Brush b)
        {
            g.FillEllipse(b, x, y, segment, segment);
        }
    }
}
