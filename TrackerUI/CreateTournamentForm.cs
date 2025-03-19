using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpList();
        }

        private void WireUpList()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        // Team ----------
        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpList();
            }

        }
        private void deleteSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)tournamentTeamsListBox.SelectedItem;
            if (p != null)
            {
                selectedTeams.Remove(p);
                availableTeams.Add(p);

                WireUpList();
            }
        }
        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // call the createprizeform
            CreateTeamForm form = new CreateTeamForm(this);
            form.Show();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpList();
        }

        // Prize ----------
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm form = new CreatePrizeForm(this); // o this nesse caso é sobre essa instancia em especifico
            form.Show();
        }
        public void PrizeComplete(PrizeModel model)
        {
            //get back from the form a prizemodel
            //take the prizemodel and put it into out list of selected prizes
            selectedPrizes.Add(model);
            WireUpList();
        }
        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpList();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee); //se o parse for bem sucedido ele vai atribuir (out) o valor dentro da variavel fee
            // se não, ele vai passar o valor 0 para fee e o feeAcceptable vai ser um false

            if (!feeAcceptable) 
            {
                MessageBox.Show("You need to enter a valid entry fee", "Invalid fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // CREATE TOURNAMENT MODEL
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;

            //foreach (PrizeModel prize in selectedPrizes){tm.Prizes.Add(prize);} posso fazer assim ou assim vvvv
            tm.Prizes = selectedPrizes; //isso basicamente atribuo itens de uma lista (selectedPrizes) em uma variavel do tipo lista (oq é a mesma coisa q o comando acima)
            tm.EnteredTeams = selectedTeams;

            // WIRE CREATE MATCHUPS
            TournamentLogic.CreateRounds(tm);

            // CREATE TOURNAMENT ENTRY
            // CREATE ALL THE PRIZE ENTRIES
            // CREATE ALL OF TEAM ENTRIES
            GlobalConfig.Connection.CreateTournament(tm);
        }
    }
}