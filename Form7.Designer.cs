namespace COVID_Management
{
    partial class Form7
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
            this.noOutOfCanButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.covidManagerLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.yesOutOfCanButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // noOutOfCanButton
            // 
            this.noOutOfCanButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.noOutOfCanButton.Font = new System.Drawing.Font("Constantia", 11F);
            this.noOutOfCanButton.Location = new System.Drawing.Point(379, 269);
            this.noOutOfCanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noOutOfCanButton.Name = "noOutOfCanButton";
            this.noOutOfCanButton.Size = new System.Drawing.Size(302, 79);
            this.noOutOfCanButton.TabIndex = 24;
            this.noOutOfCanButton.Text = "No, I have not been outside of Canada or have come into close contact with someon" +
    "e who did";
            this.noOutOfCanButton.UseVisualStyleBackColor = false;
            this.noOutOfCanButton.Click += new System.EventHandler(this.noOutOfCanButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(678, 46);
            this.label2.TabIndex = 21;
            this.label2.Text = "Did you recently return from outside of Canada within 14 days or came into close " +
    "\r\ncontact with someone who did? If yes, what day did you return/meet them?";
            // 
            // covidManagerLabel
            // 
            this.covidManagerLabel.AutoSize = true;
            this.covidManagerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.covidManagerLabel.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold);
            this.covidManagerLabel.Location = new System.Drawing.Point(6, 18);
            this.covidManagerLabel.Name = "covidManagerLabel";
            this.covidManagerLabel.Size = new System.Drawing.Size(656, 146);
            this.covidManagerLabel.TabIndex = 20;
            this.covidManagerLabel.Text = "COVID Daily Work-\r\nFitness Questionnaire";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Constantia", 11F);
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 362);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 30);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // yesOutOfCanButton
            // 
            this.yesOutOfCanButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.yesOutOfCanButton.Font = new System.Drawing.Font("Constantia", 11F);
            this.yesOutOfCanButton.Location = new System.Drawing.Point(16, 269);
            this.yesOutOfCanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yesOutOfCanButton.Name = "yesOutOfCanButton";
            this.yesOutOfCanButton.Size = new System.Drawing.Size(297, 79);
            this.yesOutOfCanButton.TabIndex = 26;
            this.yesOutOfCanButton.Text = "Yes, I have been outside of Canada or have come into close contact with someone w" +
    "ho did";
            this.yesOutOfCanButton.UseVisualStyleBackColor = false;
            this.yesOutOfCanButton.Click += new System.EventHandler(this.yesOutOfCanButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::COVID_Management.Properties.Resources.Background;
            this.pictureBox1.Location = new System.Drawing.Point(-24, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 184);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(723, 421);
            this.Controls.Add(this.yesOutOfCanButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.noOutOfCanButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.covidManagerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noOutOfCanButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label covidManagerLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button yesOutOfCanButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}