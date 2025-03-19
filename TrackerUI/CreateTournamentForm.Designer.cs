namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            createtournamentLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentTeamsListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            removeSelectedTeamButton = new Button();
            removeSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // createtournamentLabel
            // 
            createtournamentLabel.AutoSize = true;
            createtournamentLabel.Font = new Font("Segoe UI", 30F);
            createtournamentLabel.Location = new Point(12, 9);
            createtournamentLabel.Name = "createtournamentLabel";
            createtournamentLabel.Size = new Size(361, 54);
            createtournamentLabel.TabIndex = 2;
            createtournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(12, 112);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(380, 36);
            tournamentNameValue.TabIndex = 14;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 16F);
            tournamentNameLabel.Location = new Point(12, 79);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(193, 30);
            tournamentNameLabel.TabIndex = 13;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(121, 172);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(103, 36);
            entryFeeValue.TabIndex = 16;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 16F);
            entryFeeLabel.Location = new Point(12, 172);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(103, 30);
            entryFeeLabel.TabIndex = 15;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(12, 259);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(380, 38);
            selectTeamDropDown.TabIndex = 18;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 16F);
            selectTeamLabel.Location = new Point(12, 226);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(126, 30);
            selectTeamLabel.TabIndex = 17;
            selectTeamLabel.Text = "Select team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(197, 226);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(178, 30);
            createNewTeamLink.TabIndex = 19;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "Create new team";
            createNewTeamLink.LinkClicked += createNewTeamLink_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            addTeamButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI", 16F);
            addTeamButton.Location = new Point(141, 370);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(151, 46);
            addTeamButton.TabIndex = 20;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            createPrizeButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI", 16F);
            createPrizeButton.Location = new Point(141, 422);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(151, 46);
            createPrizeButton.TabIndex = 21;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.Location = new Point(462, 112);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(332, 154);
            tournamentTeamsListBox.TabIndex = 22;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 16F);
            tournamentPlayersLabel.Location = new Point(462, 82);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(163, 30);
            tournamentPlayersLabel.TabIndex = 23;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // removeSelectedTeamButton
            // 
            removeSelectedTeamButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            removeSelectedTeamButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            removeSelectedTeamButton.FlatStyle = FlatStyle.Flat;
            removeSelectedTeamButton.Font = new Font("Segoe UI", 16F);
            removeSelectedTeamButton.Location = new Point(800, 146);
            removeSelectedTeamButton.Name = "removeSelectedTeamButton";
            removeSelectedTeamButton.Size = new Size(151, 82);
            removeSelectedTeamButton.TabIndex = 24;
            removeSelectedTeamButton.Text = "Remove Selected";
            removeSelectedTeamButton.UseVisualStyleBackColor = true;
            removeSelectedTeamButton.Click += deleteSelectedPlayersButton_Click;
            // 
            // removeSelectedPrizeButton
            // 
            removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            removeSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPrizeButton.Font = new Font("Segoe UI", 16F);
            removeSelectedPrizeButton.Location = new Point(800, 353);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new Size(151, 81);
            removeSelectedPrizeButton.TabIndex = 27;
            removeSelectedPrizeButton.Text = "Remove Selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 16F);
            prizesLabel.Location = new Point(462, 284);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(69, 30);
            prizesLabel.TabIndex = 26;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.Location = new Point(462, 314);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(332, 154);
            prizesListBox.TabIndex = 25;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            createTournamentButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI", 16F);
            createTournamentButton.Location = new Point(313, 508);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(357, 46);
            createTournamentButton.TabIndex = 28;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(964, 566);
            Controls.Add(createTournamentButton);
            Controls.Add(removeSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(removeSelectedTeamButton);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(createtournamentLabel);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createtournamentLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentTeamsListBox;
        private Label tournamentPlayersLabel;
        private Button removeSelectedTeamButton;
        private Button removeSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}