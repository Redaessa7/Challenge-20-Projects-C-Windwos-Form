using BMICalculator.Screens;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class MainScreen : Form
    {
        // instatnce of BMICalc Class
        private BMICalc b = new BMICalc();
        private bool isMale;

        public MainScreen()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Gender Male Check by Defult:
            ckBoxMale.Checked = true;
        }

        private void plGenderMouseHover(object sender, EventArgs e)
        {
            plGenderMale.FillColor = Color.WhiteSmoke;
        }

        private void plGenderMouseLeave(object sender, EventArgs e)
        {
            plGenderMale.FillColor = Color.White;
        }


        private void plGendarFemale_MouseHover(object sender, EventArgs e)
        {
            plGendarFemale.FillColor = Color.WhiteSmoke;
        }

        private void plGendarFemale_MouseLeave(object sender, EventArgs e)
        {
            plGendarFemale.FillColor = Color.White;
        }

        private void ckBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxMale.Checked)
            {
                ckBoxFemale.Checked = false;
                plGenderMale.BorderColor = Color.FromArgb(76, 132, 255);
                plGenderMale.BorderThickness = 3;
                isMale = true;
            }
             
            plGendarFemale.BorderColor = Color.WhiteSmoke;
            plGendarFemale.BorderThickness = 2;


        }

        private void ckBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxFemale.Checked)
            {
                ckBoxMale.Checked = false;
                plGendarFemale.BorderColor = Color.FromArgb(255, 95, 139);
                plGendarFemale.BorderThickness = 3;
                isMale = false;
            }

           plGenderMale.BorderColor = Color.WhiteSmoke;
           plGenderMale.BorderThickness = 2;
        }

        private bool intializedObject()
        {
            if (!string.IsNullOrEmpty(txBoxWeight.Text) && !string.IsNullOrEmpty(txBoxHeight.Text))
            {
                b.Weight1 = Convert.ToSingle(txBoxWeight.Text);
                b.Height1 = Convert.ToSingle(txBoxHeight.Text);
                b.Age1 = (float)NUpDownAge.Value;
                b.Gender1 = (isMale ? BMICalc.Gender.Male : BMICalc.Gender.Female);
                return true;

            }
            else 
            {
                MessageBox.Show("Plz Make sure to fill out all fields", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void ResetTextBox()
        {
            txBoxWeight.Clear();
            txBoxHeight.Clear();
            NUpDownAge.Value = 1;

            // Gender Male Check by Defult:
            ckBoxMale.Checked = true;


        }
        private void btnBmiCalc_Click(object sender, EventArgs e)
        {
            if (intializedObject())
            {
                Console.WriteLine("Weight: {0}, Heigth: {1}, Age: {2}, Gender: {3}, BMI Result: {4}, Class: {5} ", b.Weight1, b.Height1, b.Age1, b.Gender1, b.BMIReuslt1, b.getBmiClass());
                ResultScreen result = new ResultScreen(b);
                result.ShowDialog();
                ResetTextBox();
            }

        }

        private void txBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txBoxWeight.Text) || string.IsNullOrEmpty(txBoxHeight.Text))
            {
                btnBmiCalc.Enabled = false;
                return;
            }
            else
            {
                btnBmiCalc.Enabled = true;
            }
        }
    
    
        // Dev Social Media Urls
        private string DevSocialMediaUrl(Guna2Button btn)
        {
            if (btn == btnFaceBook) return "https://www.facebook.com/Red257";
            else if (btn == btnGitHub) return "https://github.com/Redaessa7";
            else if (btn == btnTelegram) return "https://t.me/Redaessa7";
            else return "https://leetcode.com/u/Redaessa/";
        }

        private void btnSocialMedia_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(DevSocialMediaUrl((Guna2Button)sender));
        }
    }
}
