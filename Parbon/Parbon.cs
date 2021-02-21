using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parbon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wedding w1 = new Wedding();
            w1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Holud h1 = new Holud();
            h1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Beddec b1 = new Beddec();
            b1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Community c1 = new Community();
            c1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Khatna k1 = new Khatna();
            k1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Birthday b1 = new Birthday();
            b1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Food f1 = new Food();
            f1.ShowDialog();
        }
    }
}
