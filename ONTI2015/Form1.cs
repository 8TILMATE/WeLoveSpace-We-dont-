using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace ONTI2015
{
    public partial class FrmLogare : Form
    {
        public FrmLogare()
        {
            InitializeComponent();
        }
        private double unghi = 0;
        private int R1 = 200;
        private int R2 = 150;
        private async void FrmLogare_Load(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(200+R1/2-pictureBox2.Width/2, 200+R2/2-pictureBox2.Height);
            await Task.Delay(100);
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            g.DrawEllipse(pen, new Rectangle(200, 200, 200, 100));
            g.Dispose();
            AxWindowsMediaPlayer mediaPlayer = new AxWindowsMediaPlayer();
            //mediaPlayer.URL = "sunetFire.mp3";
           // mediaPlayer.openPlayer(mediaPlayer.URL);
            //mediaPlayer.launchURL(mediaPlayer.URL);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            float dreaptax = (float)(Math.Cos(unghi) * R1)+300;
            float dreaptay = (float)(Math.Sin(unghi) * R2)+250;
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 1);
            g.DrawEllipse(pen, new Rectangle(200-R1/2, 200-R2/2, R1*2, R2*2));
            //g.DrawLine(pen, 300, 250, dreaptax, dreaptay);
            pictureBox1.Location=new Point((int)dreaptax, (int)dreaptay);
            unghi += Math.PI/100;
        }
    }
}
