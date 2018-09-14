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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            lbl_Directions.Text =
                "1) Choose the units. Note the updated form." + Environment.NewLine +
                "2) Input the size of the phone booth. Max. size enforced." + Environment.NewLine +
                "3) Input the body type." + Environment.NewLine +
                "4) Click the Maximum Number of People button." + Environment.NewLine +
                "5) A window will open showing the calculation."
                ;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
