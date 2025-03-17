namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            TournamentDashboardLabel = new Label();
            loadExistingTournamentDropDown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // TournamentDashboardLabel
            // 
            TournamentDashboardLabel.AutoSize = true;
            TournamentDashboardLabel.Font = new Font("Segoe UI", 30F);
            TournamentDashboardLabel.Location = new Point(51, 9);
            TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            TournamentDashboardLabel.Size = new Size(439, 54);
            TournamentDashboardLabel.TabIndex = 16;
            TournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(80, 130);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(380, 38);
            loadExistingTournamentDropDown.TabIndex = 24;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 16F);
            loadExistingTournamentLabel.Location = new Point(163, 84);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(260, 30);
            loadExistingTournamentLabel.TabIndex = 23;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            loadExistingTournamentLabel.Click += loadExistingTournamentLabel_Click;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            loadTournamentButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI", 16F);
            loadTournamentButton.Location = new Point(163, 184);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(220, 46);
            loadTournamentButton.TabIndex = 25;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            createTournamentButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI", 16F);
            createTournamentButton.Location = new Point(137, 293);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(270, 95);
            createTournamentButton.TabIndex = 28;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(540, 426);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(TournamentDashboardLabel);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentDashboardLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}