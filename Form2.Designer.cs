namespace COVID_Management
{
    partial class Form2
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
            this.covidManagerLabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // covidManagerLabel
            // 
            this.covidManagerLabel.AutoSize = true;
            this.covidManagerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.covidManagerLabel.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold);
            this.covidManagerLabel.Location = new System.Drawing.Point(4, 9);
            this.covidManagerLabel.Name = "covidManagerLabel";
            this.covidManagerLabel.Size = new System.Drawing.Size(730, 73);
            this.covidManagerLabel.TabIndex = 14;
            this.covidManagerLabel.Text = "COVID-19 Questionnaire";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Constantia", 11F);
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Fever(feeling hot to the touch, a temperature of 37.8 degrees Celsius or higher)",
            "Chills",
            "Cough that\'s new or worsening(continuous, more than usual)",
            "Barking cough, making a whistling noise when breathing(croup)",
            "Shortness of breath(out of breath, unable to breathe deeply)",
            "Sore throat",
            "Difficulty swallowing",
            "Runny nose(not related to seasonal allergies or other known causes or conditions)" +
                "",
            "Stuffy or congested nose(not related to seasonal allergies or other known causes " +
                "or conditions)",
            "Lost sense of taste or smell",
            "Pink eye(conjunctivitis)",
            "Headache that’s unusual or long lasting",
            "Digestive issues like nausea/vomiting, diarrhea, stomach pain (not related to oth" +
                "er known causes or conditions)",
            "Muscle aches that are unusual or long lasting",
            "Extreme tiredness that is unusual(fatigue, lack of energy)",
            "Falling down often",
            "For young children and infants: sluggishness or lack of appetite",
            "None of the above "});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 145);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(909, 400);
            this.checkedListBox1.TabIndex = 15;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.submitButton.Font = new System.Drawing.Font("Constantia", 11F);
            this.submitButton.Location = new System.Drawing.Point(810, 557);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(88, 29);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Check which of the following  symptoms you currently have";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::COVID_Management.Properties.Resources.Background;
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 95);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(923, 598);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.covidManagerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label covidManagerLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}