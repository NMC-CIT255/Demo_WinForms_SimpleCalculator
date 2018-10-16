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

        /// <summary>
        /// set units labels on form based on radio buttons
        /// </summary>
        private void radBtn_English_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_English.Checked == true)
            {
                lbl_Length.Text = "Length (ft)";
                lbl_Width.Text = "Width (ft)";
                lbl_Height.Text = "Height (ft)";
            }
        }

        /// <summary>
        /// set units labels on form based on radio buttons
        /// </summary>
        private void radBtn_Metric_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_Metric.Checked == true)
            {
                lbl_Length.Text = "Length (m)";
                lbl_Width.Text = "Width (m)";
                lbl_Height.Text = "Height (m)";
            }
        }

        /// <summary>
        /// validate user input in text boxes, return value or user feedback
        /// </summary>
        /// <param name="userInput">text box content</param>
        /// <param name="maxValue">maximum value</param>
        /// <param name="value">returned value</param>
        /// <param name="userFeedback">returned feedback</param>
        /// <returns>validated input status</returns>
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

        /// <summary>
        /// close form button event
        /// </summary>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// calculate the number of people who fit
        /// </summary>
        private void btn_CalculatePeople_Click(object sender, EventArgs e)
        {
            double length = 0, width = 0, height = 0;
            double value;
            double maxDimension;
            int numberOfPeople;
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

            //
            // validate each user input and build out the feedback message
            //
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
                //lbl_ErrorMessage.Text = userMessage;
                MessageBox.Show(userMessage);
            }
            //
            // open the SolutionForm
            //
            else
            {
                numberOfPeople = NumberOfPeople(length, width, height);

                Form solutionForm = new form_Solution(new SolutionFormInfo(numberOfPeople, cmbBox_BodyType.Text));
                solutionForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                solutionForm.MaximizeBox = false;
                solutionForm.MinimizeBox = false;
                solutionForm.ShowDialog();
                solutionForm.Dispose();
            }
        }

        /// <summary>
        /// calculate the number of people who fit
        /// </summary>
        /// <param name="length">length of phone booth</param>
        /// <param name="width">width of phone booth</param>
        /// <param name="height">height of phone booth</param>
        /// <returns>calculated number of people</returns>
        private int NumberOfPeople(double length, double width, double height)
        {
            const double CONV_CFT_CM = 0.0283168; // cubic feet to cubic meters

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
                case ("Tall and Robust"):
                    numberOfPeople = (int)Math.Truncate(volumeOfPhoneBooth / VOLUME_T_R);
                    break;
                case ("Short and Skinny"):
                    numberOfPeople = (int)Math.Truncate(volumeOfPhoneBooth / VOLUME_S_S);
                    break;
                case ("Short and Robust"):
                    numberOfPeople = (int)Math.Truncate(volumeOfPhoneBooth / VOLUME_S_R);
                    break;
            }

            return numberOfPeople;
        }

        /// <summary>
        /// set up form on load event
        /// </summary>
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            cmbBox_BodyType.SelectedIndex = 1;
        }

        /// <summary>
        /// open help dialog box
        /// </summary>
        private void btn_Help_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            helpForm.MinimizeBox = false;
            helpForm.MaximizeBox = false;
            helpForm.ShowDialog();
            helpForm.Dispose();
        }
    }
}
