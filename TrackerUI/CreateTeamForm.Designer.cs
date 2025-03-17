namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            createteamLabel = new Label();
            addMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addNewMemberBox = new GroupBox();
            createMemberButton = new Button();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(12, 112);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(380, 23);
            teamNameValue.TabIndex = 17;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 16F);
            teamNameLabel.Location = new Point(12, 79);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(125, 30);
            teamNameLabel.TabIndex = 16;
            teamNameLabel.Text = "Team name";
            // 
            // createteamLabel
            // 
            createteamLabel.AutoSize = true;
            createteamLabel.Font = new Font("Segoe UI", 30F);
            createteamLabel.Location = new Point(12, 9);
            createteamLabel.Name = "createteamLabel";
            createteamLabel.Size = new Size(241, 54);
            createteamLabel.TabIndex = 15;
            createteamLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            addMemberButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI", 16F);
            addMemberButton.Location = new Point(84, 200);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(220, 46);
            addMemberButton.TabIndex = 23;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(12, 171);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(380, 23);
            selectTeamMemberDropDown.TabIndex = 22;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 16F);
            selectTeamMemberLabel.Location = new Point(12, 138);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(215, 30);
            selectTeamMemberLabel.TabIndex = 21;
            selectTeamMemberLabel.Text = "Select team member";
            // 
            // addNewMemberBox
            // 
            addNewMemberBox.Controls.Add(createMemberButton);
            addNewMemberBox.Controls.Add(cellphoneValue);
            addNewMemberBox.Controls.Add(cellphoneLabel);
            addNewMemberBox.Controls.Add(emailValue);
            addNewMemberBox.Controls.Add(emailLabel);
            addNewMemberBox.Controls.Add(lastNameValue);
            addNewMemberBox.Controls.Add(lastNameLabel);
            addNewMemberBox.Controls.Add(firstNameValue);
            addNewMemberBox.Controls.Add(firstNameLabel);
            addNewMemberBox.Font = new Font("Segoe UI", 20F);
            addNewMemberBox.Location = new Point(12, 252);
            addNewMemberBox.Name = "addNewMemberBox";
            addNewMemberBox.Size = new Size(380, 287);
            addNewMemberBox.TabIndex = 24;
            addNewMemberBox.TabStop = false;
            addNewMemberBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            createMemberButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI", 16F);
            createMemberButton.Location = new Point(82, 226);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(185, 46);
            createMemberButton.TabIndex = 25;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneValue
            // 
            cellphoneValue.Font = new Font("Segoe UI", 16F);
            cellphoneValue.Location = new Point(129, 169);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(245, 36);
            cellphoneValue.TabIndex = 32;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI", 16F);
            cellphoneLabel.Location = new Point(6, 172);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(111, 30);
            cellphoneLabel.TabIndex = 31;
            cellphoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.Font = new Font("Segoe UI", 16F);
            emailValue.Location = new Point(129, 127);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(245, 36);
            emailValue.TabIndex = 30;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 16F);
            emailLabel.Location = new Point(6, 130);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(73, 30);
            emailLabel.TabIndex = 29;
            emailLabel.Text = "E-mail";
            // 
            // lastNameValue
            // 
            lastNameValue.Font = new Font("Segoe UI", 16F);
            lastNameValue.Location = new Point(129, 85);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(245, 36);
            lastNameValue.TabIndex = 28;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 16F);
            lastNameLabel.Location = new Point(6, 88);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(114, 30);
            lastNameLabel.TabIndex = 27;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Font = new Font("Segoe UI", 16F);
            firstNameValue.Location = new Point(129, 43);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(245, 36);
            firstNameValue.TabIndex = 26;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 16F);
            firstNameLabel.Location = new Point(6, 46);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(117, 30);
            firstNameLabel.TabIndex = 25;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.Location = new Point(419, 112);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(341, 364);
            teamMembersListBox.TabIndex = 25;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            deleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedMemberButton.Font = new Font("Segoe UI", 16F);
            deleteSelectedMemberButton.Location = new Point(486, 490);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(234, 49);
            deleteSelectedMemberButton.TabIndex = 26;
            deleteSelectedMemberButton.Text = "Delete Selected";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            createTeamButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI", 16F);
            createTeamButton.Location = new Point(311, 570);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(220, 46);
            createTeamButton.TabIndex = 27;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(778, 628);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createteamLabel);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberBox.ResumeLayout(false);
            addNewMemberBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label createteamLabel;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberBox;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}