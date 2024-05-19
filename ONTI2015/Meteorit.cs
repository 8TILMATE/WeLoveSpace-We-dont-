using ONTI2015.Properties;
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
    public partial class Meteorit : Form
    {
        public Meteorit()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y+10);
            if(pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds)&&pictureBox2.Image==null)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, -10);
                this.BackgroundImage = Resources._889b86dfb255824f611c12f367f69cb6;
                pictureBox2.Image = Resources.Ice_Water_PNG_HD_Image;
            }
            else if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                pictureBox1.Hide();
               Graphics g =  pictureBox2.CreateGraphics();
                g.FillEllipse(new SolidBrush(Color.Black), pictureBox1.Location.X,0,pictureBox1.Width,pictureBox1.Height);
                g.Dispose();
                timer1.Stop();
            }
        }
    }
}
