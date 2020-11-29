using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mine_Sweeper
{
    public partial class over : Form
    {
        System.Media.SoundPlayer pl = new System.Media.SoundPlayer();
        public over()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
        }

        private void over_Load(object sender, EventArgs e)
        {

            pl.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "/asset/ra.wav";
            pl.PlayLooping();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pl.Stop();
            this.Close();
            main_game vb = new main_game();
            main_game sam = new main_game();
            sam = sam.sss;
            vb = sam;
            // vb.Close();
            intro ty = new intro();
            ty.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pl.Stop();
            pl.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "/asset/god.wav";
            pl.PlayLooping();
            main_game mg = new main_game();
            mg.ext_main(mg);
            mg.Show();
        }

    }
}
