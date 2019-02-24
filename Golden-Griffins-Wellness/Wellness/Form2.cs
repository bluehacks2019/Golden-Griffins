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
using System.Speech;
using System.Speech.Synthesis;



namespace Wellness
{
    public partial class Form2 : Form
    {
        MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='wellness';username=root;password=");
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader reader;
        DataSet data = new DataSet();

        DataGridViewRow selectedrow;
        DataTable table = new DataTable();
        string savestats = "new";
        int selectedrowindex;


        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        SpeechSynthesizer reader1 = new SpeechSynthesizer();
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
            cn.Open();
            if (savestats == "new")
            {

                if ((bunifuMetroTextbox1.Text == "") && (bunifuMetroTextbox2.Text == "") && (bunifuMetroTextbox3.Text == "") && (bunifuMetroTextbox4.Text == "") && (bunifuMetroTextbox5.Text == "") && (bunifuMetroTextbox5.Text == ""))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (bunifuMetroTextbox1.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (bunifuMetroTextbox2.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Age.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (bunifuMetroTextbox3.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Birthday.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (bunifuMetroTextbox4.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


                else if (bunifuMetroTextbox5.Text == "")

                {
                    
                    MetroFramework.MetroMessageBox.Show(this, "Input Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }




                else
                {
                    if (savestats == "new")
                    {
                        string Cmdstring = "Insert into registration(name, age, birthday,email,password) Values('" + bunifuMetroTextbox1.Text + "','" + bunifuMetroTextbox2.Text + "','" + bunifuMetroTextbox3.Text + "','" + bunifuMetroTextbox4.Text + "','" + bunifuMetroTextbox5.Text + "')";
                        com = new MySqlCommand(Cmdstring, cn);
                        com.ExecuteNonQuery();
                        com.Dispose();

                        Form1 show = new Form1();
                        show.Show();
                        this.Hide();
                        reader1.Speak("Register Successfully");
                        MetroFramework.MetroMessageBox.Show(this, "Registration Successful", "REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bunifuMetroTextbox1.Text = "";
                        bunifuMetroTextbox2.Text = "";
                        bunifuMetroTextbox3.Text = "";
                        bunifuMetroTextbox4.Text = "";
                        bunifuMetroTextbox5.Text = "";
                        
                    }
                }
                cn.Close();
            }

        }

      
         
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }
    }
}
