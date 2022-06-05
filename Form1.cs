using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jamb
{
    public partial class Form1 : Form
    {
        Random R = new Random();
        List<int> izvuceni = new List<int>();
        Dictionary<int, int> istiBrojevi = new Dictionary<int, int>();
        int jedan;
        int dva;
        int tri;
        int cetiri;
        int pet;
        int sest;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            jedan = R.Next(1, 7);
            pictureBox1.Image = new Bitmap("../../dices/" + jedan + ".png");

            dva = R.Next(1, 7);
            pictureBox2.Image = new Bitmap("../../dices/" + dva + ".png");

            tri = R.Next(1, 7);
            pictureBox3.Image = new Bitmap("../../dices/" + tri + ".png");

            cetiri = R.Next(1, 7);
            pictureBox4.Image = new Bitmap("../../dices/" + cetiri + ".png");

            pet = R.Next(1, 7);
            pictureBox5.Image = new Bitmap("../../dices/" + pet + ".png");

            sest = R.Next(1, 7);
            pictureBox6.Image = new Bitmap("../../dices/" + sest + ".png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            izvuceni = new List<int>();
            istiBrojevi = new Dictionary<int, int>();

            izvuceni.Add(jedan);
            izvuceni.Add(dva);
            izvuceni.Add(tri);
            izvuceni.Add(cetiri);
            izvuceni.Add(pet);
            izvuceni.Add(sest);

            foreach (int broj in izvuceni)
            {
                if (istiBrojevi.Keys.Contains(broj))
                {
                    istiBrojevi[broj]++;
                }
                else
                {
                    istiBrojevi[broj] = 1;
                }
            }

            if ((izvuceni.Contains(1) && izvuceni.Contains(2) && izvuceni.Contains(3) && izvuceni.Contains(4) && izvuceni.Contains(5)) ||
                (izvuceni.Contains(2) && izvuceni.Contains(3) && izvuceni.Contains(4) && izvuceni.Contains(5) && izvuceni.Contains(6)))
            {
                listBox1.Items.Add("kenta");
            }
            else if (istiBrojevi.ContainsValue(3))
            {
                if (istiBrojevi.ContainsValue(2) || istiBrojevi.Count == 2)
                {
                    listBox1.Items.Add("ful");
                }
                else
                {
                    listBox1.Items.Add("triling");
                }
            }
            else if (istiBrojevi.ContainsValue(4))
            {
                listBox1.Items.Add("poker");
            }
            else if (istiBrojevi.ContainsValue(5) || istiBrojevi.ContainsValue(6))
            {
                listBox1.Items.Add("jamb");
            }
            else
            {
                listBox1.Items.Add("NIŠTA");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
