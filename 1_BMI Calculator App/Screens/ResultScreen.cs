using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BMICalculator.Screens
{
    public partial class ResultScreen : Form
    {
        private BMICalc bmi;
        public ResultScreen(BMICalc bm)
        {
            InitializeComponent();
            this.bmi = bm;
        }

        // load BMI Classification from json file
        private List<BMIClassification> Classifications;
        private void getBMIClassification()
        {
            string jsonFileContaint = File.ReadAllText(@"../../BMI_Classifications.json");
            Classifications = JsonConvert.DeserializeObject<List<BMIClassification>>(jsonFileContaint);
        }

        // change progress bar color based on bmi result
        private void changeProgressColor(short bmiClassResult)
        {
            switch (bmiClassResult)
            {
                case 0:cirProgressBar.ProgressColor2  =   Color.FromArgb(213, 47, 46); break;
                case 1: cirProgressBar.ProgressColor2 = Color.FromArgb(246, 81, 28); break;
                case 2: cirProgressBar.ProgressColor2 =  Color.FromArgb(254, 160, 4); break;
                case 3: cirProgressBar.ProgressColor2 =  Color.FromArgb(0, 167, 192); break;
                case 4: cirProgressBar.ProgressColor2 = Color.FromArgb(0, 147, 136); break;
                case 5: cirProgressBar.ProgressColor2 = Color.FromArgb(254, 160, 4); break;
                case 6: cirProgressBar.ProgressColor2 = Color.FromArgb(246, 81, 28); break;
                case 7: cirProgressBar.ProgressColor2 = Color.FromArgb(212, 47, 46); break;
            }
        }

        // get index of catogry BMI Classifications
        private short getCatogryBMI(short ResultbmiClass)
        {
            switch(ResultbmiClass) 
            {
                case 0: case 1: case 2: return 0;
                case 3: return 1;
                case 4: return 2;
                case 5: return 3;
                case 6: return 4;
                default: return 5;
            }
        }

        private void ResultScreen_Load(object sender, EventArgs e)
        {
            BMICalc.BmiClass b = bmi.getBmiClass();
            lblBMIResult.Text = bmi.BMIReuslt1.ToString();
            changeProgressColor((short)b);
            picBoxClassImage.Image = imageListClass.Images[(int)b];
            lblBMIClass.Text = b.ToString();
            cirProgressBar.Value = (int)bmi.BMIReuslt1;

            // load BMI Classifications
            getBMIClassification();

            short getIndexCatogry = getCatogryBMI((short)b);
            BMIClassification Bc = Classifications[getIndexCatogry];
            lblCatogryBMIClass.Text = "Catogry: " + Bc.Category + ", BMI Range: " + Bc.BMI;
            lblMoreInfoBMIClass.Text = Bc.Description;

        }

        private void btnReCalcutror_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShareBMI_Click(object sender, EventArgs e)
        {
            //Copy the text to the clipboard
            Clipboard.SetText("Your BMI Score: " + bmi.BMIReuslt1.ToString()+ " Kg/M²");
            MessageBox.Show("BMI Score Copy");
        }
    }









    // BMI Classification
    public class BMIClassification 
    {
        public string Category { get; set; }
        public string BMI { get; set; }
        public string Description { get; set; }
    }

}
