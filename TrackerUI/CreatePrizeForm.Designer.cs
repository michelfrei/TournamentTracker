namespace TrackerUI
{
    partial class CreatePrizeForm
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
            createPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            prizeAmountValue = new TextBox();
            priceAmountLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizePercentageValue = new TextBox();
            pricePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI", 30F);
            createPrizeLabel.Location = new Point(111, 9);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(234, 54);
            createPrizeLabel.TabIndex = 16;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Font = new Font("Segoe UI", 16F);
            placeNumberValue.Location = new Point(176, 108);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(245, 36);
            placeNumberValue.TabIndex = 30;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 16F);
            placeNumberLabel.Location = new Point(21, 111);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(149, 30);
            placeNumberLabel.TabIndex = 29;
            placeNumberLabel.Text = "Place Number";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Font = new Font("Segoe UI", 16F);
            prizeAmountValue.Location = new Point(176, 222);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(245, 36);
            prizeAmountValue.TabIndex = 32;
            prizeAmountValue.Text = "0";
            // 
            // priceAmountLabel
            // 
            priceAmountLabel.AutoSize = true;
            priceAmountLabel.Font = new Font("Segoe UI", 16F);
            priceAmountLabel.Location = new Point(21, 225);
            priceAmountLabel.Name = "priceAmountLabel";
            priceAmountLabel.Size = new Size(143, 30);
            priceAmountLabel.TabIndex = 31;
            priceAmountLabel.Text = "Prize Amount";
            // 
            // placeNameValue
            // 
            placeNameValue.Font = new Font("Segoe UI", 16F);
            placeNameValue.Location = new Point(176, 165);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(245, 36);
            placeNameValue.TabIndex = 34;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 16F);
            placeNameLabel.Location = new Point(21, 168);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(127, 30);
            placeNameLabel.TabIndex = 33;
            placeNameLabel.Text = "Place Name";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Font = new Font("Segoe UI", 16F);
            prizePercentageValue.Location = new Point(201, 357);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(220, 36);
            prizePercentageValue.TabIndex = 36;
            prizePercentageValue.Text = "0";
            // 
            // pricePercentageLabel
            // 
            pricePercentageLabel.AutoSize = true;
            pricePercentageLabel.Font = new Font("Segoe UI", 16F);
            pricePercentageLabel.Location = new Point(21, 360);
            pricePercentageLabel.Name = "pricePercentageLabel";
            pricePercentageLabel.Size = new Size(174, 30);
            pricePercentageLabel.TabIndex = 35;
            pricePercentageLabel.Text = "Price Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 16F);
            orLabel.Location = new Point(192, 298);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(73, 30);
            orLabel.TabIndex = 37;
            orLabel.Text = "- OR -";
            orLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            createPrizeButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI", 16F);
            createPrizeButton.Location = new Point(118, 428);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(220, 46);
            createPrizeButton.TabIndex = 38;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click_1;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(457, 524);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(pricePercentageLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(priceAmountLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox prizeAmountValue;
        private Label priceAmountLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizePercentageValue;
        private Label pricePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}