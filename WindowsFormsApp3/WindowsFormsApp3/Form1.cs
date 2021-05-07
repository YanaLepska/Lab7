using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            circles = new CCircle[4];
            squares = new CSquare[4];
            sq1 = new CSquare[4];
        }

        CCircle[] circles;
        int CircleCount = 0;
        int CurrentCircleIndex;

        CSquare[] squares;
        int SquareCount = 0;
        int CurrentSquareIndex;
        
        CSquare[] sq1;
        int Sq1Count = 0;
        int CurrentSq1Index;


        private void btnCreateNew_Click(object sender, EventArgs e)
        {

            if (CircleCount >= 3)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }

            Graphics graphics = pnMain.CreateGraphics();
            CurrentCircleIndex = CircleCount;
            
            circles[CurrentCircleIndex] = new CCircle(graphics, pnMain.Width / 2, pnMain.Height / 2, 75);

            circles[CurrentCircleIndex].Show();
            CircleCount++;

            cbEmbl.Items.Add("Емблема № " + (CircleCount - 1).ToString());
            cbEmbl.SelectedIndex = CircleCount - 1;


            if (SquareCount >= 3)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }
          
            CurrentSquareIndex = SquareCount;

            CurrentSquareIndex = SquareCount;
            squares[CurrentSquareIndex] = new CSquare(graphics, pnMain.Width / 2, pnMain.Height / 2, 75);

            squares[CurrentSquareIndex].Show();
            SquareCount++;

           
            if (Sq1Count >= 3)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }

            CurrentSq1Index = Sq1Count;

            CurrentSq1Index = Sq1Count;
            sq1[CurrentSq1Index] = new CSquare(graphics, pnMain.Width / 2, pnMain.Height / 2, 53);

            sq1[CurrentSq1Index].Show();
            Sq1Count++;

        }
         
        private void btnHide_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbEmbl.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;           
            circles[CurrentCircleIndex].Hide();

          
            
            if ((CurrentSquareIndex > SquareCount) || (CurrentSquareIndex < 0))
                return;
            squares[CurrentSquareIndex].Hide();

            
            if ((CurrentSq1Index > Sq1Count) || (CurrentSq1Index < 0))
                return;
            sq1[CurrentSq1Index].Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbEmbl.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            
            circles[CurrentCircleIndex].Show();

            
            if ((CurrentSquareIndex > SquareCount) || (CurrentSquareIndex < 0))
                return;

            squares[CurrentSquareIndex].Show();

            if ((CurrentSq1Index > Sq1Count) || (CurrentSq1Index < 0))
                return;
            sq1[CurrentSq1Index].Show();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbEmbl.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Expand(5);
;
           
            if ((CurrentSquareIndex > SquareCount) || (CurrentSquareIndex < 0))
                return;
            squares[CurrentSquareIndex].Expand(5);

            if ((CurrentSq1Index > Sq1Count) || (CurrentSq1Index < 0))
                return;
            sq1[CurrentSq1Index].Expand(5);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbEmbl.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Collapse(5);

            
            if ((CurrentSquareIndex > SquareCount) || (CurrentSquareIndex < 0))
                return;
            squares[CurrentSquareIndex].Collapse(5);
            if ((CurrentSq1Index > Sq1Count) || (CurrentSq1Index < 0))
                return;
            sq1[CurrentSq1Index].Collapse(5);

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbEmbl.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
           
            circles[CurrentCircleIndex].Move(0, -10);

           
            if ((CurrentSquareIndex > SquareCount) || (CurrentSquareIndex < 0))
                return;

            squares[CurrentSquareIndex].Move(0,-10);

            if ((CurrentSq1Index > Sq1Count) || (CurrentSq1Index < 0))
                return;
            sq1[CurrentSq1Index].Move(0, -10);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbEmbl.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Move(0, 10);

           
            if ((CurrentSquareIndex > SquareCount) || (CurrentSquareIndex < 0))
                return;

            squares[CurrentSquareIndex].Move(0, 10);

            if ((CurrentSq1Index > Sq1Count) || (CurrentSq1Index < 0))
                return;
            sq1[CurrentSq1Index].Move(0, 10);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbEmbl.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Move(-10, 0);

            
            if ((CurrentSquareIndex > SquareCount) || (CurrentSquareIndex < 0))
                return;
            squares[CurrentSquareIndex].Move(-10, 0);

            if ((CurrentSq1Index > Sq1Count) || (CurrentSq1Index < 0))
                return;
            sq1[CurrentSq1Index].Move(-10, 0);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbEmbl.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            circles[CurrentCircleIndex].Move(10, 0);

            
            if ((CurrentSquareIndex > SquareCount) || (CurrentSquareIndex < 0))
                return;

            squares[CurrentSquareIndex].Move(10, 0);

            if ((CurrentSq1Index > Sq1Count) || (CurrentSq1Index < 0))
                return;
            sq1[CurrentSq1Index].Move(10, 0);
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbEmbl.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            
            
            if ((CurrentSquareIndex > SquareCount) || (CurrentSquareIndex < 0))
                return;

            if ((CurrentSq1Index > Sq1Count) || (CurrentSq1Index < 0))
                return;
            

            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(1, 0);
                squares[CurrentSquareIndex].Move(1, 0);
                sq1[CurrentSq1Index].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbEmbl.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
                      
            if ((CurrentSquareIndex > SquareCount) || (CurrentSquareIndex < 0))
                return;

            if ((CurrentSq1Index > Sq1Count) || (CurrentSq1Index < 0))
                return;
            
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(-1, 0);
                squares[CurrentSquareIndex].Move(-1, 0);
                sq1[CurrentSq1Index].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }                    
        }

        private void btnUpFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbEmbl.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
                       
            if ((CurrentSquareIndex > SquareCount) || (CurrentSquareIndex < 0))
                return;
            if ((CurrentSq1Index > Sq1Count) || (CurrentSq1Index < 0))
                return;
            
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(0, -1);
                squares[CurrentSquareIndex].Move(0, -1);
                sq1[CurrentSq1Index].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }           
        }

        private void btnDownFar_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbEmbl.SelectedIndex;
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
                return;
            
            if ((CurrentSquareIndex > SquareCount) || (CurrentSquareIndex < 0))
                return;
            if ((CurrentSq1Index > Sq1Count) || (CurrentSq1Index < 0))
                return;
            
            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(0, 1);
                squares[CurrentSquareIndex].Move(0, 1);
                sq1[CurrentSq1Index].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}
