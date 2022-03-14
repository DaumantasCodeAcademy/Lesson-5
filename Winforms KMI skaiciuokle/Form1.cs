using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_KMI_skaiciuokle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateKmiButton_Click(object sender, EventArgs e)
        {
            KmiCalculator calculator = new KmiCalculator();
            decimal bodyMass = Convert.ToDecimal(BodyMassTextBox.Text);
            decimal height = Convert.ToDecimal(HeightTextBox.Text);

            decimal kmi = calculator.CalculateKmi(bodyMass, height);
            CalculatedKmiTextBox.Text = $"{kmi}";

            string conclusion = "";
            switch (kmi)
            {
                case <= 18.5m:
                    conclusion = "Asmuo yra nusilpes ir jo kuno svoris per mazas";
                    break;
                case > 18.5m and <= 25:
                    conclusion = "Idealus kuno mases indeksas";
                    break;
                case > 25 and <= 30:
                    conclusion = "Asmuo turi antsvori";
                    break;
                case > 30:
                    conclusion = "Asmuo yra nutukes";
                    break;
            }

            ConclusionsTextBox.Text = conclusion;
        }
    }
}
