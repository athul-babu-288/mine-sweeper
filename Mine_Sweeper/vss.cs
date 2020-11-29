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
    public partial class vss : Form
    {
        public static string p1 = "", p2 = "";
        public vss()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            p1 = textBox1.Text;
            p2 = textBox2.Text;
            if (p1 == "" || p2 == "")
            {
                MessageBox.Show("Please Fill The Form !");
            }
            else
            {
                home h = new home();
                this.Close();
                h.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            intro cs = new intro();
            cs.Show();
        }


    }
}
