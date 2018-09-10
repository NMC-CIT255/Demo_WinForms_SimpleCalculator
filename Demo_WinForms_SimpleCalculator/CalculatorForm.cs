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

        private bool ValidateDimensions(string userInput, double maxValue, out double value, out string userFeedback)
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
                    userFeedback = $"Dimensions must be between 0 and {maxValue}.";
                    return false;
                }
            }
            else
            {
                userFeedback = $"Enter only numbers between 0 and {maxValue}.";
                return false;
            }
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            double value;
            string userFeedback;
            TextBox txtBox = (TextBox)sender;

            if (radBtn_English.Checked == true)
            {
                if (!ValidateDimensions(txtBox.Text, MAX_DIMENSION_FT, out value, out userFeedback))
                {
                    MessageBox.Show(userFeedback);
                    txtBox.Text = null;
                    txtBox.Focus();
                }
            }
            else if (radBtn_Metric.Checked == true)
            {
                if (!ValidateDimensions(txtBox.Text, MAX_DIMENSION_M, out value, out userFeedback))
                {
                    MessageBox.Show(userFeedback);
                    txtBox.Text = null;
                    txtBox.Focus();
                }
            }
        }
    }
}
