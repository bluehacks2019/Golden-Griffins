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
    public partial class Form1 : Form
    {
        MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='wellness';username=root;password=");
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader reader;
        DataSet data = new DataSet();

        DataGridViewRow selectedrow;
        DataTable table = new DataTable();
        string savestats = "new";
        int selectedrowindex;



        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer reader1 = new SpeechSynthesizer();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           


            cn.Open();
            try
            {


                MySqlCommand cmd = new MySqlCommand("SELECT registration.name,registration.age,registration.birthday,registration.email,registration.password,registration.status FROM registration WHERE email LIKE '%" + bunifuMetroTextbox3.Text + "%' AND password LIKE '%" + bunifuMetroTextbox2.Text + "%'", cn);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();

                

                if (dr.Read())
                {

                    Form3 recep1 = new Form3();

                    recep1.label1.Text = dr.GetString("name").ToString();
                    recep1.label6.Text = dr.GetString("email").ToString();
                    recep1.label3.Text = dr.GetString("status").ToString();

                    dr.Close();
                    reader1.Speak("Login Succesfully");
                    MetroFramework.MetroMessageBox.Show(this, "Success to Login", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    recep1.Show();
                    this.Hide();
                    reader1.Speak(recep1.label2.Text + recep1.label1.Text);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid Username/Password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bunifuMetroTextbox3.Text = "Username";
                    bunifuMetroTextbox2.isPassword = false;
                    bunifuMetroTextbox2.Text = "Password";

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Message: \n\t" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        

        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form2 show = new Form2();
            show.Show();
            this.Hide();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
