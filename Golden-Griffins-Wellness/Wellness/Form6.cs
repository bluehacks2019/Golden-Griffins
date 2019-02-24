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
    public partial class Form6 : Form
    {
        MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='wellness';username=root;password=");
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader reader;
        DataSet data = new DataSet();

        DataGridViewRow selectedrow;
        DataTable table = new DataTable();
        string savestats = "new";
        int selectedrowindex;


        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            


            cn.Open();
            com.CommandText = "SELECT * FROM randomemotion ORDER BY RAND() LIMIT 1";
            com.Connection = cn;


            reader = com.ExecuteReader();

            while (reader.Read())
            {
                groupBox1.Text = (reader[5].ToString());
                label2.Text = (reader[0].ToString());
                label1.Text = (reader[1].ToString());
                label3.Text = (reader[2].ToString());
                label5.Text = (reader[3].ToString());
                label6.Text = (reader[4].ToString());
                
            }




            reader.Close();
            cn.Close();
        
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            cn.Open();
            if (savestats == "new")
            {
                if ((groupBox1.Text == "") && (label2.Text == "") && (label1.Text == "") && (label3.Text == "") && (label5.Text == "") && (label6.Text == ""))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (label2.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "User_id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                else if (label3.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (label1.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Lastname", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (label5.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Department", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (label6.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                else if (label7.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Lastname", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }



                else
                {
                    if (savestats == "new")
                    {

                        string Cmdstring = "Insert into tbl_joinquestion(email, question, ans1, ans2, ans3, ans4,lesson,timer) Values('" + label7.Text + "','" + label2.Text + "','" + label1.Text + "','" + label3.Text + "','" + label5.Text + "','" + label6.Text + "','" + groupBox1.Text + "','" + label9.Text + "')";
                        com = new MySqlCommand(Cmdstring, cn);
                        com.ExecuteNonQuery();
                        com.Dispose();

                        Form1 logout = new Form1();
                        logout.Show();
                        this.Hide();

                        
                    }
                }

                cn.Close();
                



            }

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }
    }
}
