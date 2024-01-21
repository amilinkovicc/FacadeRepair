using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadeRepairUI
{
    public partial class CreateFacadeForm : Form
    {
        public CreateFacadeForm()
        {
            InitializeComponent();
        }

        private void createFacadeButton_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateForm ()
        {
            bool output = true;

            if (objectNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (objectAddressValue.Text.Length == 0)
            {
                output = false;
            }

            if (objectOwnerValue.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }
    }
}
