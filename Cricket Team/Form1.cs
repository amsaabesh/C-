using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cricket_Team
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bangladesh
            Bangladesh ban = new Bangladesh();
            ban.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //england
            England eng = new England();
            eng.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //australia
            Australia aus = new Australia();
            aus.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //newzeland
            Newzeland nz = new Newzeland();
            nz.ShowDialog();
        }
    }
}
