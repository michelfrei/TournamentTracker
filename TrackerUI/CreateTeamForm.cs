using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using TrackerLibrary;
using TrackerLibrary.models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private bool ValidadeForm()
        {
            bool output = true;

            if(firstNameValue.Text.IsNullOrEmpty() || lastNameValue.Text.IsNullOrEmpty() || emailValue.Text.IsNullOrEmpty() || cellphoneValue.Text.
                IsNullOrEmpty())
            {
                output = false;
            }
                return output;
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidadeForm())
            {
                PersonModel model = new PersonModel(firstNameValue.Text, lastNameValue.Text, emailValue.Text, cellphoneValue.Text);
                GlobalConfig.Connection.CreatePerson(model);

                firstNameValue.Text="";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information, Check and try again");
            }
        }
    }
}
