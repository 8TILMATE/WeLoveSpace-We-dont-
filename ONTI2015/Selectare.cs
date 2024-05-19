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
    public partial class Selectare : Form
    {
        public Selectare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pamant = new FrmLogare();
            pamant.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pamant = new Rotatielaterala();
            pamant.ShowDialog();
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pamant = new Meteorit();
            pamant.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pamant = new CampGeoMagnetic();
            pamant.ShowDialog();
            this.Show();

        }
    }
}
