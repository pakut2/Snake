using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class anakonda
    {
        public int segments;
        public int segment;
        public int[] x = new int[900];
        public int[] y = new int[900];
        public string move;

        public anakonda(int width, int heigth)
        {
            segment = width / 20;
            segments = 3;
            move = "right";
            int xHead = 9 * segment;
            int yHead = 9 * segment;

            for(int i=0; i<segments; i++)
            {
                x[i] = xHead - (i * segment);
                y[i] = yHead;
            }
        }

        public void moveSnake()
        {
            for(int i=segments; i>0; i--)
            {
                x[i] = x[(i - 1)];
                y[i] = y[(i - 1)];
            }

            if(move == "left")
            {
                x[0] = x[0] - segment;
            }
            if(move == "right")
            {
                x[0] = x[0] + segment;
            }
            if (move == "top")
            {
                y[0] = y[0] - segment;
            }
            if (move == "bottom")
            {
                y[0] = y[0] + segment;
            }

            if(x[0] < 0)
            {
                x[0] = segment * 19;
            }
            if (x[0] > segment * 19)
            {
                x[0] = 0;
            }
            if (y[0] < 0)
            {
                y[0] = segment * 19;
            }
            if (y[0] > segment * 19)
            {
                y[0] = 0;
            }
        }
        public void draw(Graphics g, Brush b)
        {
            g.FillRectangle(new SolidBrush(Color.Green), x[0], y[0], segment, segment);
            for(int i=1; i<segments; i++)
            {
                g.FillRectangle(b, x[i], y[i], segment, segment);

            }
        }

        public void add()
        {
            x[segments] = x[segments - 1];
            y[segments] = y[segments - 1];
            segments += 1;
        }

        public bool isAlive()
        {
            for(int i = 1; i < segments; i++)
            {
                if(x[0] == x[i] && y[0] == y[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
