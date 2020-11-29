using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Mine_Sweeper
{
    public partial class main_game : Form
    {

        int patt = home.pat;
        int tot_but;
        string tim = System.DateTime.Now.ToString("ss");
        int t, c = 0;
        Button[] b;
        public main_game sss;


        public main_game()
        {
            InitializeComponent();

        }

        public void main_Load(object sender, EventArgs e)
        {
            vss cv = new vss();

            if (vss.p1 != "")
                player.Text = vss.p1 + " VS " + vss.p2;
            else
                player.Text = "Mine Sweeper ";

        }
        public void ext_main(main_game er)
        {
            sss = er;
            t = Convert.ToInt32(tim[1].ToString());
            if (t < 5)
                t += 5;

            tot_but = patt * patt;
            b = new Button[tot_but];
            if (patt == 6)
            {

                gp.Size = new Size(240, 240);
                gp.Location = new Point(147, 122);

            }
            else if (patt == 8)
            {
                gp.Size = new Size(280, 280);
                gp.Location = new Point(111, 94);
            }
            else
            {
                gp.Size = new Size(350, 350);
                gp.Location = new Point(84, 60);
            }

            for (int i = 0; i < (patt * patt); i++)
            {
                b[i] = new Button();
                b[i].Tag = (i + 1).ToString();
                b[i].Size = new Size(29, 29);
                b[i].BackColor = Color.Blue;
                b[i].Click += new EventHandler(button_Click);
                gp.Controls.Add(b[i]);
            }

            int di = home.dif;
            if (di == 3)
            {
                hard(t);
                medium(t);
                easy(t);
            }
            else if (di == 2)
            {
                hard(t);
                easy(t);

            }
            else
            {
                easy(t);
            }

            find_cell();

        }

        public void easy(int t)
        {
            string num = "";
            double sum = 0;

            for (int i = 0; i < (patt * patt); i++)
            {
                num = b[i].Tag.ToString();

                if (num.Length > 1)
                    sum = char.GetNumericValue(num[0]) + char.GetNumericValue(num[1]);
                else
                    sum = char.GetNumericValue(num[0]);

                if (sum == t)
                {
                    b[i].Tag = "*";
                }

            }

        }
        public void medium(int t)
        {
            string num = "";
            int inde = 0;
            for (int i = 0; i < (patt * patt); i++)
            {
                num = b[i].Tag.ToString();
                inde = num.IndexOf(t.ToString(), 0);
                if (inde >= 0)
                {
                    b[i].Tag = "*";
                }
            }

        }
        public void hard(int t)
        {
            for (int i = 0; i < (patt * patt); i++)
            {
                if (Convert.ToInt32(b[i].Tag) % t == 0)
                {
                    b[i].Tag = "*";
                }
            }

        }


        private void button_Click(object sender, EventArgs e)
        {

            Button lb = sender as Button;
            string bt = (lb.Tag).ToString();

            if (bt != "*")
            {

                lb.BackColor = Color.Green;
                find_cell();
                if (c == 0)
                {
                    over ov = new over();
                    ov.label1.Text = ". . . WINNER . . . ";
                }

            }
            else
            {
                lb.BackColor = Color.Red;
                for (int i = 0; i < (patt * patt); i++)

                    b[i].Enabled = false;


                timer1.Enabled = true;
                timer2.Enabled = true;
            }
        }

        public void find_cell()
        {
            c = 0;
            for (int i = 0; i < (patt * patt); i++)
            {
                if ((b[i].Tag != "*") && (b[i].BackColor != Color.Green))
                    c++;
            }

            label1.Text = "Freecells : " + c;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string sym = "";
            for (int i = 0; i < (patt * patt); i++)
            {
                sym = b[i].Tag.ToString();
                if (sym == "*")
                {
                    b[i].BackColor = Color.Red;

                }
            }
            timer1.Enabled = false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            over ov = new over();
            ov.Show();
            timer2.Enabled = false;
        }
    }
}
