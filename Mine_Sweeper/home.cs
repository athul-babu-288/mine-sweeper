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
    public partial class home : Form
    {

        public static int pat = 0, dif = 0;


        public home()
        {
            InitializeComponent();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dif = 1;
            }
            else if (radioButton2.Checked)
            {
                dif = 2;
            }
            else if (radioButton3.Checked)
            {
                dif = 3;
            }

            if (radioButton6.Checked)
                pat = 6;
            else if (radioButton5.Checked)
                pat = 8;
            else if (radioButton4.Checked)
                pat = 10;


            this.Close();

            main_game mg = new main_game();
            mg.ext_main(mg);
            mg.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            intro cs = new intro();
            cs.Show();

        }


    }
}
