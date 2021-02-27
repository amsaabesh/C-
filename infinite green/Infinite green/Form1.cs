using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infinite_green
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

        private void button3_Click(object sender, EventArgs e)
        {
            Seed seed1 = new Seed();
            seed1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tree t1 = new Tree();
            t1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SFM sfm1 = new SFM();
            sfm1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tools t1 = new Tools();
            t1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Plan execute = new Plan();
            execute.ShowDialog();
        }
    }
}
