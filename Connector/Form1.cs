using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Connector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DBConnection();
        }
            private void DBConnection()
            {
                string ConnectString = "datasource=localhost;port=3235;username=root;password=;database=criminal_of_war";
                MySqlConnection DBConnect = new MySqlConnection(ConnectString);
                try
                {
                    DBConnect.Open();
                    MessageBox.Show("Kala Pare na");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
       
    }
}
