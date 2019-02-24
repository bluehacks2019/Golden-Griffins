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
using MySql.Data.MySqlClient;
namespace Wellness
{
    public partial class Form4 : Form
    {
        MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='wellness';username=root;password=");
        MySqlCommand com = new MySqlCommand();
        MySqlDataReader reader;
        DataSet data = new DataSet();

        DataGridViewRow selectedrow;
        DataTable table = new DataTable();
        string savestats = "new";
        int selectedrowindex;

        public Form4()
        {
            InitializeComponent();
        }

        SpeechSynthesizer reader1 = new SpeechSynthesizer();

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //bunifuThinButton22.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked == true)
            {
                groupBox1.Hide();
                groupBox2.Show();
                reader1.Speak("Question number two. In the past week, which emotion did you feel most often?");
                
            }
       
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked == true)
            {
                groupBox1.Hide();
                groupBox2.Show();
                reader1.Speak("Question number two. In the past week, which emotion did you feel most often?");
                
            }
       

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                groupBox2.Hide();
                groupBox3.Show();
                reader1.Speak("Question number 3.Which response below best describes you?");

            }
       
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton6.Checked == true)
            {
                groupBox2.Hide();
                groupBox3.Show();
                reader1.Speak("Question number 3.Which response below best describes you?");

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton5.Checked == true)
            {
                groupBox2.Hide();
                groupBox3.Show();
                reader1.Speak("Question number 3.Which response below best describes you?");

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton3.Checked == true)
            {
                groupBox2.Hide();
                groupBox3.Show();
                reader1.Speak("Question number 3.Which response below best describes you?");

            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked== true)
            {
                groupBox3.Hide();
                groupBox4.Show();
                reader1.Speak("Question number 4.which one would produce the most negative emotional response in you?");

            }
       
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                groupBox3.Hide();
                groupBox4.Show();
                reader1.Speak("Question number 4.which one would produce the most negative emotional response in you?");

            }
       
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                groupBox3.Hide();
                groupBox4.Show();
                reader1.Speak("Question number 4.which one would produce the most negative emotional response in you?");

            }
       
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                groupBox3.Hide();
                groupBox4.Show();
                reader1.Speak("Question number 4.which one would produce the most negative emotional response in you?");

            }
       
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked== true)
            {
                groupBox4.Hide();
                groupBox5.Show();
                reader1.Speak("Question number five what do you think causes the most positive reaction in you?");

            }
       
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                groupBox4.Hide();
                groupBox5.Show();
                reader1.Speak("Question number five what do you think causes the most positive reaction in you?");

            }
       
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                groupBox4.Hide();
                groupBox5.Show();
                reader1.Speak("Question number five what do you think causes the most positive reaction in you?");

            }
       
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                groupBox4.Hide();
                groupBox5.Show();
                reader1.Speak("Question number five what do you think causes the most positive reaction in you?");

            }
       
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked== true)
            {
                groupBox5.Hide();
                groupBox6.Show();
                reader1.Speak("Question number six What makes you emotional??");

            }
       
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked == true)
            {
                groupBox5.Hide();
                groupBox6.Show();
                reader1.Speak("Question number six What makes you emotional??");

            }
       
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                groupBox5.Hide();
                groupBox6.Show();
                reader1.Speak("Question number six What makes you emotional??");

            }
       
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                groupBox5.Hide();
                groupBox6.Show();
                reader1.Speak("Question number six What makes you emotional??");

            }
       
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton22.Checked == true)
            {
                groupBox6.Hide();
                groupBox7.Show();
                reader1.Speak("Question number seven How do you have fun?");

            }
       
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked == true)
            {
                groupBox6.Hide();
                groupBox7.Show();
                reader1.Speak("Question number seven How do you have fun?");

            }
       
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked == true)
            {
                groupBox6.Hide();
                groupBox7.Show();
                reader1.Speak("Question number seven How do you have fun?");

            }
       
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked == true)
            {
                groupBox6.Hide();
                groupBox7.Show();
                reader1.Speak("Question number seven How do you have fun?");

            }
       
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton26.Checked == true)
            {
                groupBox7.Hide();
                groupBox9.Show();
                reader1.Speak("Question number eight Who inspire you?");

            }
       
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton25.Checked == true)
            {
                groupBox7.Hide();
                groupBox9.Show();
                reader1.Speak("Question number eight Who inspire you?");

            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton24.Checked == true)
            {
                groupBox7.Hide();
                groupBox9.Show();
                reader1.Speak("Question number eight Who inspire you?");

            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton23.Checked == true)
            {
                groupBox7.Hide();
                groupBox9.Show();
                reader1.Speak("Question number eight Who inspire you?");

            }
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton34.Checked == true)
            {
                groupBox9.Hide();
                groupBox10.Show();
                reader1.Speak("Question number nine How could you create more balance in your life?");

            }
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton33.Checked == true)
            {
                groupBox9.Hide();
                groupBox10.Show();
                reader1.Speak("Question number nine How could you create more balance in your life?");

            }
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton32.Checked == true)
            {
                groupBox9.Hide();
                groupBox10.Show();
                reader1.Speak("Question number nine How could you create more balance in your life?");

            }
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton31.Checked == true)
            {
                groupBox9.Hide();
                groupBox10.Show();
                reader1.Speak("Question number nine How could you create more balance in your life?");

            }
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton38.Checked == true)
            {
                groupBox10.Hide();
                groupBox11.Show();
                reader1.Speak("Question number ten What something you're really proud of?");

            }
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton37.Checked == true)
            {
                groupBox10.Hide();
                groupBox11.Show();
                reader1.Speak("Question number ten What something you're really proud of?");

            }
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton36.Checked == true)
            {
                groupBox10.Hide();
                groupBox11.Show();
                reader1.Speak("Question number ten What something you're really proud of?");

            }
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton35.Checked == true)
            {
                groupBox10.Hide();
                groupBox11.Show();
                reader1.Speak("Question number ten What something you're really proud of?");

            }
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton42.Checked == true)
            {
                bunifuThinButton22.Show();

            }
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton41.Checked == true)
            {
                bunifuThinButton22.Show();
            }
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton40.Checked == true)
            {
                bunifuThinButton22.Show();
            }
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton39.Checked == true)
            {
                bunifuThinButton22.Show();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            double ans1 = 0, ans2 = 0, ans3 = 0, ans4 = 0, ans5 = 0, ans6 = 0, ans7 = 0, ans8 = 0, ans9 = 0, ans10 = 0, ans11 = 0, ans12 = 0, ans13 = 0, ans14 = 0, ans15 = 0,
                ans16 = 0, ans17 = 0, ans18 = 0, ans19 = 0, ans20 = 0, ans21 = 0, ans22 = 0, ans23 = 0, ans24 = 0, ans25 = 0, ans26 = 0, ans27 = 0, ans28 = 0, ans29 = 0
            , ans30 = 0, ans31 = 0, ans32 = 0, ans33 = 0, ans34 = 0, ans35 = 0, ans36 = 0, ans37 = 0, ans38 = 0, total=0,ans39=0,ans40=0 ,asd = 0;
             

            if(radioButton1.Checked == true)
            {
                ans1 = 1;
                total = +ans1;
            }

            if (radioButton2.Checked == true)
            {
                ans2 = 4;

                total = total + ans2;
            }

            if (radioButton4.Checked == true)
            {
                ans3 = 1;

                total = total + ans3;
            }

            if (radioButton6.Checked == true)
            {
                ans4 = 2;

                total = total + ans4;
            }

            if (radioButton5.Checked == true)
            {
                ans5 = 3;

                total = total + ans5;
            }

            if (radioButton3.Checked == true)
            {
                ans6 = 4;

                total = total + ans6;
            }




            if (radioButton8.Checked == true)
            {
                ans7 = 4;

                total = total + ans7;
            }

            if (radioButton7.Checked == true)
            {
                ans8 = 2;

                total = total + ans8;
            }
            if (radioButton9.Checked == true)
            {
                ans9 = 3;

                total = total + ans9;
            }
            if (radioButton10.Checked == true)
            {
                ans10 = 1;

                total = total + ans10;
            }
            if (radioButton14.Checked == true)
            {
                ans11 = 3;

                total = total + ans11;
            }
            if (radioButton13.Checked == true)
            {
                ans12 = 4;

                total = total + ans12;
            }
            if (radioButton12.Checked == true)
            {
                ans13 = 2;

                total = total + ans13;
            }
            if (radioButton11.Checked == true)
            {
                ans14 = 1;

                total = total + ans14;
            }
            if (radioButton18.Checked == true)
            {
                ans15 = 3;

                total = total + ans18;
            }
            if (radioButton17.Checked == true)
            {
                ans16 = 1;

                total = total + ans16;
            }
            if (radioButton16.Checked == true)
            {
                ans17 = 4;

                total = total + ans17;
            }
            if (radioButton15.Checked == true)
            {
                ans18 = 2;

                total = total + ans18;
            }
            if (radioButton22.Checked == true)
            {
                ans19 = 1;

                total = total + ans19;
            }
            if (radioButton21.Checked == true)
            {
                ans20 = 2;

                total = total + ans20;
            }
            if (radioButton20.Checked == true)
            {
                ans21 = 4;

                total = total + ans21;
            }
            if (radioButton19.Checked == true)
            {
                ans22 = 3;

                total = total + ans22;
            }
            if (radioButton26.Checked == true)
            {
                ans23 = 1;

                total = total + ans23;
            }
            if (radioButton25.Checked == true)
            {
                ans24 = 4;

                total = total + ans24;
            }
            if (radioButton24.Checked == true)
            {
                ans25 = 3;

                total = total + ans25;
            }
            if (radioButton23.Checked == true)
            {
                ans26 = 2;

                total = total + ans26;
            }
            if (radioButton34.Checked == true)
            {
                ans27 = 2;

                total = total + ans27;
            }
            if (radioButton33.Checked == true)
            {
                ans28 = 3;

                total = total + ans28;
            }
            if (radioButton32.Checked == true)
            {
                ans29 = 1;

                total = total + ans29;
            }
            if (radioButton31.Checked == true)
            {
                ans30 = 4;

                total = total + ans30;
            }
            if (radioButton38.Checked == true)
            {
                ans31 = 2;

                total = total + ans31;
            }
            if (radioButton37.Checked == true)
            {
                ans32 = 3;

                total = total + ans32;
            }
            if (radioButton36.Checked == true)
            {
                ans33 = 4;

                total = total + ans33;
            }
            if (radioButton35.Checked == true)
            {
                ans34 = 1;

                total = total + ans34;
            }
            if (radioButton42.Checked == true)
            {
                ans35 = 4;

                total = total + ans35;
            }
            if (radioButton41.Checked == true)
            {
                ans36 = 3;

                total = total + ans36;
            }
            if (radioButton40.Checked == true)
            {
                ans37 = 1;

                total = total + ans37;
            }
            if (radioButton39.Checked == true)
            {
                ans38 = 2;

                total = total + ans38;
            }

            if (radioButton27.Checked == true)
            {
                ans39 = 3;

                total = total + ans39;
            }

            if (radioButton28.Checked == true)
            {
                ans40 = 2;

                total = total + ans40;
            }
            double total1;

            total1 = total;
            asd = ((total1 / 40) * 100); 
            
            Form5 hehe = new Form5();
            hehe.label7.Text = asd.ToString();
            hehe.label6.Text = label10.Text;



            cn.Open();
            if (savestats == "new")
            {

                if ((label10.Text == ""))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (label10.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Student No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    if (savestats == "new")
                    {
                        string Cmdstring = "Update registration set result='" + label7.Text  + "' where email='" + label10.Text + "'";
                        com = new MySqlCommand(Cmdstring, cn);
                        com.ExecuteNonQuery();
                        com.Dispose();

                        
                    }
                }
                cn.Close();

            }




                        
            hehe.Show();
            this.Hide();
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton27.Checked || radioButton2.Checked == true)
            {
                groupBox1.Hide();
                groupBox2.Show();
                reader1.Speak("Question number two. In the past week, which emotion did you feel most often?");

            }
       
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton28.Checked || radioButton2.Checked == true)
            {
                groupBox1.Hide();
                groupBox2.Show();
                reader1.Speak("Question number two. In the past week, which emotion did you feel most often?");

            }
       
        }
    }
}
