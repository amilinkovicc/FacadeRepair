using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacadeRepairLibrary;
using FacadeRepairLibrary.DataAccess;
using FacadeRepairLibrary.Model;

namespace FacadeRepairUI
{
    public partial class CreatePolygonForm : Form
    {
        public CreatePolygonForm()
        {
            InitializeComponent();
        }

        private void createPolygonButton_Click(object sender, EventArgs e)
        {

        }

        private void addPointButton_Click(object sender, EventArgs e)
        {
            if (ValidatePoint())
            {
                PointModel model = new PointModel(xValue.Text, yValue.Text);

                GlobalConfig.Connection.CreatePoint(model);

                xValue.Text = "";
                yValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        /// <summary>
        /// Checks if the coordinates of the point are valid.
        /// </summary>
        /// <returns></returns>
        private bool ValidatePoint()
        {
            bool output = true;
            int x = 0, y = 0;

            if (!(int.TryParse(xValue.Text, out x)))
            {
                // You can just return false in every if and at the end return true.
                // This way if you add messages that explain what is wrong with the input, user will get all messages at once instead one by one.
                // TODO - Add messages
                output = false;
            }

            if (!(int.TryParse(yValue.Text, out y)))
            {
                output = false;
            }

            if (x < 0 || y < 0)
            {
                output = false;
            }

            // TODO - It shouldn't be possible to add point out of facade.

            return output;
        }
    }
}
