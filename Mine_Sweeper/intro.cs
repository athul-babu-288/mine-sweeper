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
    public partial class intro : Form
    {
        public static int use_count = 0;
        home h = new home();
        System.Media.SoundPlayer pl = new System.Media.SoundPlayer();
        public intro()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            use_count = 1;
            h.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            use_count = 2;
            vss vs = new vss();
            vs.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pl.Stop();
            Application.Exit();
        }

        private void intro_Load(object sender, EventArgs e)
        {

            pl.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "/asset/god.wav";
            pl.PlayLooping();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l1.Visible = !l1.Visible;
        }

    }
}
