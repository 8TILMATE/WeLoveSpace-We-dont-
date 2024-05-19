using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONTI2015
{
    public partial class Rotatielaterala : Form
    {
        private int Stadiu1 = 0;
        private int Stadiu2 = 0;

        public Rotatielaterala()
        {
            InitializeComponent();
        }

        private void Rotatielaterala_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Location.X < 20)
            {
                Stadiu1 = 1;
         

            }
            else if(pictureBox2.Location.X>600)
            {
                Stadiu1 = -1;

            }
                if (Stadiu1 == 1)
            {
                pictureBox2.Location= new Point(pictureBox2.Location.X+10, pictureBox1.Location.Y);
                pictureBox2.SendToBack();
                pictureBox1.BringToFront();
            }
            else
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X - 10, pictureBox1.Location.Y);
                pictureBox1.SendToBack();
                pictureBox2.BringToFront();
            }
        }
    }
}
