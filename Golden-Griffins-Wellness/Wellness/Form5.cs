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
namespace Wellness
{
    public partial class Form5 : Form
    {
        MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='wellness';username=root;password=");
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader reader;
        DataSet data = new DataSet();

        DataGridViewRow selectedrow;
        DataTable table = new DataTable();
        string savestats = "new";
        int selectedrowindex;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT registration.result,registration.email From registration WHERE email LIKE '%" + label6.Text + "%'", cn);
            cmd.ExecuteNonQuery();

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                label7.Text = (dr.GetString("result"));
            }

            dr.Close();
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        double x=0,y=0;
        int val = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
        




            x = Convert.ToDouble(label7.Text);
            val++;
            progressBar1.Value = val;
            
            if (val > x)
            {

                timer1.Enabled = false; 

            
            }

            

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form6 bay = new Form6();
            bay.label7.Text = label6.Text;
            bay.Show();
            this.Hide();
            

        }
    }
}
