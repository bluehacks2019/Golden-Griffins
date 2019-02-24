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
    public partial class Form8 : Form
    {
        MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='wellness';username=root;password=");
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader reader;
        DataSet data = new DataSet();

        DataGridViewRow selectedrow;
        DataTable table = new DataTable();
        string savestats = "new";
        int selectedrowindex;

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            cn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT tbl_joinquestion.question,tbl_joinquestion.ans1,tbl_joinquestion.ans2,tbl_joinquestion.ans3,tbl_joinquestion.ans4 From tbl_joinquestion WHERE email LIKE '%" + label7.Text + "%' GROUP BY email", cn);
            cmd.ExecuteNonQuery();

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                label2.Text = (dr.GetString("question"));

                radioButton1.Text = (dr.GetString("ans1"));
                radioButton2.Text = (dr.GetString("ans2"));
                radioButton27.Text = (dr.GetString("ans3"));
                radioButton28.Text = (dr.GetString("ans4"));


            }

            dr.Close();


        }

        public void delete()
        {

                cn.Open();
                MySqlCommand command2 = new MySqlCommand("Delete from tbl_joinquestion where email=" + selectedrow.Cells[0].Value, cn);
                command2.ExecuteNonQuery();
            

                try
                {
                }
                catch (Exception)
                {



            
            }

                cn.Close();

        }
        public void update()
        {
            cn.Open();
            if (savestats == "new")
            {

                if ((label1.Text == ""))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (label1.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Student No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    if (savestats == "new")
                    {
                        string Cmdstring = "Update registration set result='" + label1.Text + "' where email='" + label7.Text + "'";
                        com = new MySqlCommand(Cmdstring, cn);
                        com.ExecuteNonQuery();
                        com.Dispose();
                        delete();
                        Form5 add = new Form5();
                        add.label6.Text = label7.Text;
                        add.Show();
                        this.Hide();
                    }
                }
                
            }
            cn.Close();
        }


        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {



            double q1 = 0, q2 = 0, q3 = 0, q4 = 0, total = 0;
            if (radioButton1.Checked == true)
            {
                total = q1;

            }
            if (radioButton2.Checked == true)
            {
                total = q2;

            }
            if (radioButton27.Checked == true)
            {
                total = q3;

            }
            if (radioButton28.Checked == true)
            {
                q4 = 5;
                total = q1;
                label1.Text = total.ToString();
                update();
                delete();           
            }
        }
    }
}
