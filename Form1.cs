using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colliding_objects
{
    public partial class frmColliding : Form
    {
        public Rectangle RectangleOne;
        public Rectangle RectangleTwo;
        public frmColliding()
        {
            InitializeComponent();
            RectangleOne = new Rectangle(20, 20, 120, 120);
            RectangleTwo= new Rectangle (250, 250, 90, 90);
        }

        private void frmColliding_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, RectangleOne);
            e.Graphics.FillRectangle(Brushes.Blue, RectangleTwo);

            if (RectangleOne.IntersectsWith(RectangleTwo))
            {
                tmrMoving.Stop();
                
            }
            else
                tmrMoving.Start();



        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            RectangleOne.X += 5;
            Invalidate();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            RectangleTwo.Y -= 5;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void frmColliding_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            RectangleOne.Location = new Point(20, 20);
            RectangleTwo.Location = new Point(250, 250);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            RectangleTwo.X += 5;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            RectangleTwo.X -= 5;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            RectangleTwo.Y += 5;
        }



        
    }
}
