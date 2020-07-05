namespace COVID_Management
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.IThinkIHaveCovidLabel = new System.Windows.Forms.Label();
            this.ITestedPosForCovid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IThinkIHaveCovidLabel
            // 
            this.IThinkIHaveCovidLabel.AutoSize = true;
            this.IThinkIHaveCovidLabel.Font = new System.Drawing.Font("Constantia", 11F);
            this.IThinkIHaveCovidLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IThinkIHaveCovidLabel.Location = new System.Drawing.Point(22, 34);
            this.IThinkIHaveCovidLabel.Name = "IThinkIHaveCovidLabel";
            this.IThinkIHaveCovidLabel.Size = new System.Drawing.Size(361, 437);
            this.IThinkIHaveCovidLabel.TabIndex = 9;
            this.IThinkIHaveCovidLabel.Text = resources.GetString("IThinkIHaveCovidLabel.Text");
            // 
            // ITestedPosForCovid
            // 
            this.ITestedPosForCovid.AutoSize = true;
            this.ITestedPosForCovid.Font = new System.Drawing.Font("Constantia", 11F);
            this.ITestedPosForCovid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ITestedPosForCovid.Location = new System.Drawing.Point(413, 34);
            this.ITestedPosForCovid.Name = "ITestedPosForCovid";
            this.ITestedPosForCovid.Size = new System.Drawing.Size(355, 414);
            this.ITestedPosForCovid.TabIndex = 10;
            this.ITestedPosForCovid.Text = resources.GetString("ITestedPosForCovid.Text");
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.ITestedPosForCovid);
            this.Controls.Add(this.IThinkIHaveCovidLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IThinkIHaveCovidLabel;
        private System.Windows.Forms.Label ITestedPosForCovid;
    }
}