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
    public partial class CampGeoMagnetic : Form
    {
        public CampGeoMagnetic()
        {
            InitializeComponent();
        }

        private void CampGeoMagnetic_Load(object sender, EventArgs e)
        {
            Task.Delay(1000);
        }
        private void DrawMGField()
        {

            Graphics g = this.CreateGraphics();
            //g.DrawCurve(new Pen(Color.Orange), curvature);
            int R1 = 100, R2 = 50;
            for (int I = 1; I < 4; I++)
            {
                g.DrawEllipse(new Pen(Color.Orange), 624+R1*I, 236-R2*I/4, -R1*I, R2*I/2);
                g.DrawEllipse(new Pen(Color.Orange), 624 - R1 * I, 236+R2*I/2, R1 * I, -R2*I);
            }
            for(int i=4;i<7;i++)
            {
                g.DrawEllipse(new Pen(Color.Orange), 624 + R1 * i, 236 - R2 * i / 2, -R1 * i, R2 * i);
            }
            g.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DrawMGField();
        }
    }
}
