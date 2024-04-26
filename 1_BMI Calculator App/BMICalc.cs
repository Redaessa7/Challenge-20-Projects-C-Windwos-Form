using System;

namespace BMICalculator
{
    public class BMICalc
    {
        // enum Gender
        public enum Gender
        {
            Female = 0,
            Male = 1,
        }
        public enum BmiClass
        {
            SevereThinness = 0,
            ModerateThinness = 1,
            MildThinness = 2,
            Normal = 3,
            Overweight = 4,
            ObeseClass1 = 5,
            ObeseClass2 = 6,
            ObeseClass3 = 7,
            Nothing = 8,
        }

        private float Weight;
        private float Height;
        private float BMIReuslt;
        private float Age;
        private Gender gender;

        // Prooerties Setters And Getters
        public float Weight1 { get => Weight; set => Weight = value; }
        public float Height1 { get => Height; set => Height = value; }
        public float BMIReuslt1 {
            get
            {
                BMIReuslt = BmiCalcaltor(Weight, Height);
                return BMIReuslt;
            }
        }

        public float Age1 { get => Age; set => Age = value; }
        public Gender Gender1 { get => gender; set => gender = value; }




        // Constructors

        // Defualt Constructor
        public BMICalc() 
        {
            Weight = 0.0f;
            Height = 0.0f;
            Age = 1;
            gender = Gender.Male;
            BMIReuslt = 0.0f;
        }
        // Parametrized Construcator
        public BMICalc(float weight, float height, float age, Gender gen) 
        {
            this.Weight = weight;
            this.Height = height;
            this.Age = age;
            this.gender = gen;
        }

        // Methods

        private static float BmiCalcaltor(float weight, float height)
        {
            // BMI = weight(KG) / Height^2(M)
            return (float)Math.Round((weight / Math.Pow(height,2)));
        }

        public static float BMICalcaltor(float weight, float height)
        {
            return BmiCalcaltor(weight, height);
        }

        public BmiClass getBmiClass()
        {
            return getClassification(BMIReuslt);
        }
        public static BmiClass getClassification(float bmiResult)
        {
            //string[] BmiClass = { "Severe Thinness", "Moderate Thinness", "Mild Thinness", "Normal", "Overweight", "Obese class Ⅰ", "Obese class ⅠⅠ", "Obese class ⅠⅠⅠ" };

            if (bmiResult < 16) return BmiClass.SevereThinness;
            else if (bmiResult >= 16 && bmiResult < 17) return BmiClass.ModerateThinness;
            else if (bmiResult >= 17 && bmiResult < 18.5) return BmiClass.MildThinness;
            else if (bmiResult >= 18.5 && bmiResult < 25) return BmiClass.Normal;
            else if (bmiResult >= 25 && bmiResult < 30) return BmiClass.Overweight;
            else if (bmiResult >= 30 && bmiResult < 35) return BmiClass.ObeseClass1;
            else if (bmiResult >= 35 && bmiResult < 40) return BmiClass.ObeseClass2;
            else if (bmiResult > 40) return BmiClass.ObeseClass3;
            else return BmiClass.Nothing;
        }
    }
}
