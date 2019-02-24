using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech;
using System.Speech.Synthesis;
using MySql.Data.MySqlClient;

namespace Wellness
{
    public partial class Form3 : Form
    {
        MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='wellness';username=root;password=");
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader reader;
        DataSet data = new DataSet();

        DataGridViewRow selectedrow;
        DataTable table = new DataTable();
        string savestats = "new";
        int selectedrowindex;


        public Form3()
        {
            InitializeComponent();
        }

        SpeechSynthesizer reader1 = new SpeechSynthesizer();
        private void Form3_Load(object sender, EventArgs e)
        {
            if (label3.Text == "1")
            {
                bunifuImageButton3.Enabled = false;
                label5.Enabled = false;
                bunifuThinButton21.Show();

            }

            else {

                bunifuImageButton3.Show();
                bunifuThinButton21.Hide();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            reader1.Speak("Are you Sure? Do you want to Logout?");
            
            if (MetroFramework.MetroMessageBox.Show(this, "Yes/No", "Are you sure do you want to log out?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            } 
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

            cn.Open();
            if (savestats == "new")
            {

                if ((label6.Text == ""))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (label6.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Student No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                else
                {
                    if (savestats == "new")
                    {
                        string Cmdstring = "Update registration set status='" +label7.Text + "' where email='" + label6.Text + "'";
                        com = new MySqlCommand(Cmdstring, cn);
                        com.ExecuteNonQuery();
                        com.Dispose();

                        Form4 show = new Form4();
                        show.label10.Text = label6.Text;
                        show.Show();
                        this.Hide();

                        reader1.Speak("you choose Emotion");
                        reader1.Speak("Question number 1. Are you enjoying your life right now?");
            
                    }
                }
                cn.Close();
            }

            
            
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form7 view = new Form7();
            view.label7.Text = label6.Text;
            view.Show();
            this.Hide();
        }
    }
}
