﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.Drawing;


namespace WindowsFormsApp3
{
    class CSquare
    {
        const int DefaultRadius = 50;

        private Graphics graphics;
        private int _radius;
        

        public int X { get; set; } // Координата X центра кола
        public int Y { get; set; } // Координата Y центра кола
        public int Radius
        { // Радіус кола
            get
            {
                return _radius;
            }
            set
            {
                _radius = value >= 200 ? 200 : value;
                _radius = value <= 5 ? 5 : value;
            }
        }

        

        public CSquare(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
           
        }
        private void Draw(Pen pen)
        {
            Rectangle rectangle = new Rectangle(X - Radius, Y - Radius,
           2 * Radius, 2 * Radius);
            graphics.DrawRectangle(pen, rectangle);
        }
        public void Show()
        {
            Draw(Pens.Red);
        }
        public void Hide()
        {
            Draw(Pens.White);
        }
        public void Expand()
        {
            Hide();
            Radius++;
            Show();
        }
        public void Expand(int dR)
        {
            Hide();
            Radius = Radius + dR;
            Show();
        }
        public void Collapse()
        {
            Hide();
            Radius--;
            Show();
        }
        public void Collapse(int dR)
        {
            Hide();
            Radius = Radius - dR;
            Show();
        }
        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }
    }
}
