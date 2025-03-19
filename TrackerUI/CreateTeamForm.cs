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
        private List<PersonModel> availableTeamMemebers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingform;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingform = caller;

            WireUpLists();
        }

        private void WireUpLists()
        {
            //TODO  Arrumar uma forma melhor de fazer isso
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = availableTeamMemebers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private bool ValidadeForm()
        {
            bool output = true;

            if (firstNameValue.Text.IsNullOrEmpty() || lastNameValue.Text.IsNullOrEmpty() || emailValue.Text.IsNullOrEmpty() || cellphoneValue.Text.
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
                model = GlobalConfig.Connection.CreatePerson(model); //colocando o model antes, conseguimos pegar de volta todos os dados que foram enviados + o ID

                selectedTeamMembers.Add(model);

                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information, Check and try again");
            }
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMemebers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMemebers.Add(p);

                WireUpLists();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            if (!teamNameValue.Text.IsNullOrEmpty() && selectedTeamMembers.Count > 0) {
                t.TeamName = teamNameValue.Text;
                t.TeamMembers = selectedTeamMembers;

                GlobalConfig.Connection.CreateTeam(t);
            }
            callingform.TeamComplete(t);
            this.Close();
        }
    }
}
