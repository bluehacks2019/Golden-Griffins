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
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.DesignerServices;
using System.Globalization;
using System.Runtime.InteropServices;


namespace Wellness
{
    public partial class Form7 : Form
    {

        MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='wellness';username=root;password=");
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader reader;
        DataSet data = new DataSet();

        DataGridViewRow selectedrow;
        DataTable table = new DataTable();
        string savestats = "new";
        int selectedrowindex;
        public Form7()
        {
            InitializeComponent();
        }
        private int hour;
        private void Form7_Load(object sender, EventArgs e)
        {
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT tbl_joinquestion.lesson From tbl_joinquestion WHERE email LIKE '%" + label7.Text + "%' GROUP BY email", cn);
            cmd.ExecuteNonQuery();

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                groupBox1.Text = (dr.GetString("lesson"));
               
       

                
            }

            dr.Close();


        }


        private string ConvertTime(int hours)
        {

            return TimeSpan.FromSeconds(hours).ToString(@"hh\:mm\:ss");

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            
            if (MetroFramework.MetroMessageBox.Show(this, "Yes/No", "Are you sure do you want to log out?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            } 
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form8 pass = new Form8();
            pass.label7.Text = label7.Text;
            pass.Show();
            this.Hide();
        }
    }
}
