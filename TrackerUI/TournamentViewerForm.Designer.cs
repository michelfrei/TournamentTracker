namespace TrackerUI
{
    partial class TournamentViewerForm
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
            tournamentLabel = new Label();
            tournamentNameLabel = new Label();
            roundLabel = new Label();
            teamoneScoreLabel = new Label();
            teamoneNameLabel = new Label();
            teamtwoNameLabel = new Label();
            teamtwoScoreLabel = new Label();
            versusLabel = new Label();
            roundComboBox = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            scoreButton = new Button();
            teamoneScoreText = new TextBox();
            teamtwoScoreText = new TextBox();
            SuspendLayout();
            // 
            // tournamentLabel
            // 
            tournamentLabel.AutoSize = true;
            tournamentLabel.Font = new Font("Segoe UI", 30F);
            tournamentLabel.Location = new Point(12, 9);
            tournamentLabel.Name = "tournamentLabel";
            tournamentLabel.Size = new Size(244, 54);
            tournamentLabel.TabIndex = 0;
            tournamentLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 30F);
            tournamentNameLabel.Location = new Point(243, 9);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(167, 54);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 16F);
            roundLabel.Location = new Point(12, 94);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(75, 30);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // teamoneScoreLabel
            // 
            teamoneScoreLabel.AutoSize = true;
            teamoneScoreLabel.Font = new Font("Segoe UI", 16F);
            teamoneScoreLabel.Location = new Point(372, 192);
            teamoneScoreLabel.Name = "teamoneScoreLabel";
            teamoneScoreLabel.Size = new Size(68, 30);
            teamoneScoreLabel.TabIndex = 3;
            teamoneScoreLabel.Text = "Score";
            // 
            // teamoneNameLabel
            // 
            teamoneNameLabel.AutoSize = true;
            teamoneNameLabel.Font = new Font("Segoe UI", 16F);
            teamoneNameLabel.Location = new Point(372, 162);
            teamoneNameLabel.Name = "teamoneNameLabel";
            teamoneNameLabel.Size = new Size(135, 30);
            teamoneNameLabel.TabIndex = 4;
            teamoneNameLabel.Text = "<team one>";
            // 
            // teamtwoNameLabel
            // 
            teamtwoNameLabel.AutoSize = true;
            teamtwoNameLabel.Font = new Font("Segoe UI", 16F);
            teamtwoNameLabel.Location = new Point(372, 317);
            teamtwoNameLabel.Name = "teamtwoNameLabel";
            teamtwoNameLabel.Size = new Size(134, 30);
            teamtwoNameLabel.TabIndex = 5;
            teamtwoNameLabel.Text = "<team two>";
            // 
            // teamtwoScoreLabel
            // 
            teamtwoScoreLabel.AutoSize = true;
            teamtwoScoreLabel.Font = new Font("Segoe UI", 16F);
            teamtwoScoreLabel.Location = new Point(372, 347);
            teamtwoScoreLabel.Name = "teamtwoScoreLabel";
            teamtwoScoreLabel.Size = new Size(68, 30);
            teamtwoScoreLabel.TabIndex = 6;
            teamtwoScoreLabel.Text = "Score";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 16F);
            versusLabel.Location = new Point(372, 250);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(69, 30);
            versusLabel.TabIndex = 7;
            versusLabel.Text = "- VS -";
            // 
            // roundComboBox
            // 
            roundComboBox.FormattingEnabled = true;
            roundComboBox.Location = new Point(152, 101);
            roundComboBox.Name = "roundComboBox";
            roundComboBox.Size = new Size(121, 23);
            roundComboBox.TabIndex = 8;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.Location = new Point(152, 130);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(104, 19);
            unplayedOnlyCheckBox.TabIndex = 9;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.Location = new Point(12, 162);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(261, 244);
            matchupListBox.TabIndex = 10;
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            scoreButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI", 16F);
            scoreButton.Location = new Point(573, 242);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(151, 46);
            scoreButton.TabIndex = 11;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // teamoneScoreText
            // 
            teamoneScoreText.Location = new Point(446, 199);
            teamoneScoreText.Name = "teamoneScoreText";
            teamoneScoreText.Size = new Size(100, 23);
            teamoneScoreText.TabIndex = 12;
            // 
            // teamtwoScoreText
            // 
            teamtwoScoreText.Location = new Point(446, 356);
            teamtwoScoreText.Name = "teamtwoScoreText";
            teamtwoScoreText.Size = new Size(100, 23);
            teamtwoScoreText.TabIndex = 13;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(777, 469);
            Controls.Add(teamtwoScoreText);
            Controls.Add(teamoneScoreText);
            Controls.Add(scoreButton);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundComboBox);
            Controls.Add(versusLabel);
            Controls.Add(teamtwoScoreLabel);
            Controls.Add(teamtwoNameLabel);
            Controls.Add(teamoneNameLabel);
            Controls.Add(teamoneScoreLabel);
            Controls.Add(roundLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(tournamentLabel);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentLabel;
        private Label tournamentNameLabel;
        private Label roundLabel;
        private Label teamoneScoreLabel;
        private Label teamoneNameLabel;
        private Label teamtwoNameLabel;
        private Label teamtwoScoreLabel;
        private Label versusLabel;
        private ComboBox roundComboBox;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Button scoreButton;
        private TextBox teamoneScoreText;
        private TextBox teamtwoScoreText;
    }
}