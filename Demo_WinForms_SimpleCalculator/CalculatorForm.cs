using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinForms_SimpleCalculator
{
    public partial class CalculatorForm : Form
    {
        const int MAX_DIMENSION_FT = 12;
        const int MAX_DIMENSION_M = 4;
        //
        // volumes are in cubit meters
        //
        const double VOLUME_S_S = .6;
        const double VOLUME_S_R = .7;
        const double VOLUME_T_S = .8;
        const double VOLUME_T_R = .9;



        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void radBtn_English_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_English.Checked == true)
            {
                lbl_Length.Text = "Length (ft)";
                lbl_Width.Text = "Width (ft)";
                lbl_Height.Text = "Height (ft)";
            }
        }

        private void radBtn_Metric_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_Metric.Checked == true)
            {
                lbl_Length.Text = "Length (m)";
                lbl_Width.Text = "Width (m)";
                lbl_Height.Text = "Height (m)";
            }
        }

        private bool ValidateUserInput(string userInput, double maxValue, out double value, out string userFeedback)
        {
            userFeedback = "";

            if (double.TryParse(userInput, out value))
            {
                if (value > 0 && value <= maxValue)
                {
                    return true;
                }
                else
                {
                    userFeedback = $" must be a number between 0 and {maxValue}.";
                    return false;
                }
            }
            else
            {
                userFeedback = $" must be a number.";
                return false;
            }
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CalculatePeople_Click(object sender, EventArgs e)
        {
            double length, width, height;
            double value;
            double maxDimension;
            string validationFeedback;
            string userMessage = null;

            //
            // validate dimensions and return values
            //
            if (radBtn_English.Checked == true)
            {
                maxDimension = MAX_DIMENSION_FT;
            }
            else
            {
                maxDimension = MAX_DIMENSION_M;
            }

            if (!ValidateUserInput(txtBox_Length.Text, maxDimension, out value, out validationFeedback))
            {
                userMessage += "The Length" + validationFeedback + Environment.NewLine;
                txtBox_Length.Text = null;
            }
            else
            {
                length = value;
            }
            if (!ValidateUserInput(txtBox_Width.Text, maxDimension, out value, out validationFeedback))
            {
                userMessage += "The Width" + validationFeedback + Environment.NewLine;
                txtBox_Width.Text = null;
            }
            else
            {
                width = value;
            }
            if (!ValidateUserInput(txtBox_Height.Text, maxDimension, out value, out validationFeedback))
            {
                userMessage += "The Height" + validationFeedback + Environment.NewLine;
                txtBox_Height.Text = null;
            }
            else
            {
                height = value;
            }

            if (userMessage != null)
            {
                MessageBox.Show(userMessage);
                lbl_ErrorMessage.Text = userMessage;
            }
        }

        private double ValidateDimension(TextBox textBox)
        {
            double value;
            double maxDimension;
            string userFeedback;

            if (radBtn_English.Checked == true)
            {
                maxDimension = MAX_DIMENSION_FT;
            }
            else
            {
                maxDimension = MAX_DIMENSION_M;
            }

            if (!ValidateUserInput(textBox.Text, maxDimension, out value, out userFeedback))
            {
                MessageBox.Show(userFeedback);
                textBox.Text = null;
                textBox.Focus();
            }
            return value;
        }

        private double NumberOfPeople(double length, double width, double height)
        {
            const double CONV_CFT_CM = 0.0283168;

            int numberOfPeople = 0;
            double volumeOfPhoneBooth;

            //
            // convert to metric for calculations if necessary
            //
            if (radBtn_English.Checked == true)
            {
                volumeOfPhoneBooth = (length * width * height) * CONV_CFT_CM;
            }
            else
            {
                volumeOfPhoneBooth = length * width * height;
            }

            switch (cmbBox_BodyType.SelectedItem)
            {
                case ("Tall and Skinny"):
                    numberOfPeople = (int)Math.Truncate(volumeOfPhoneBooth / VOLUME_T_S);
                    break;
            }

            return numberOfPeople;
        }
    }
}
