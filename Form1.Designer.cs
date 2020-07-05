namespace COVID_Management
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.covidNewsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.didYouTestPosForCovidLabel = new System.Windows.Forms.Label();
            this.yesCovidPosButton = new System.Windows.Forms.Button();
            this.quarantineScheduleButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toDoLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.goodMorningLabel = new System.Windows.Forms.Label();
            this.covidManagerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyLogoPicture = new System.Windows.Forms.PictureBox();
            this.managerNameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.covidNewsLabel);
            this.groupBox2.Location = new System.Drawing.Point(14, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(547, 356);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // covidNewsLabel
            // 
            this.covidNewsLabel.AutoSize = true;
            this.covidNewsLabel.Font = new System.Drawing.Font("Constantia", 11F);
            this.covidNewsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.covidNewsLabel.Location = new System.Drawing.Point(13, 30);
            this.covidNewsLabel.Name = "covidNewsLabel";
            this.covidNewsLabel.Size = new System.Drawing.Size(528, 324);
            this.covidNewsLabel.TabIndex = 3;
            this.covidNewsLabel.Text = resources.GetString("covidNewsLabel.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.didYouTestPosForCovidLabel);
            this.groupBox1.Controls.Add(this.yesCovidPosButton);
            this.groupBox1.Controls.Add(this.quarantineScheduleButton);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.toDoLabel);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(580, 262);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(444, 356);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // didYouTestPosForCovidLabel
            // 
            this.didYouTestPosForCovidLabel.AutoSize = true;
            this.didYouTestPosForCovidLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.didYouTestPosForCovidLabel.Location = new System.Drawing.Point(16, 162);
            this.didYouTestPosForCovidLabel.Name = "didYouTestPosForCovidLabel";
            this.didYouTestPosForCovidLabel.Size = new System.Drawing.Size(389, 52);
            this.didYouTestPosForCovidLabel.TabIndex = 9;
            this.didYouTestPosForCovidLabel.Text = "Have you done the COVID-19 test within 5 \r\ndays of today?";
            // 
            // yesCovidPosButton
            // 
            this.yesCovidPosButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.yesCovidPosButton.Location = new System.Drawing.Point(20, 229);
            this.yesCovidPosButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yesCovidPosButton.Name = "yesCovidPosButton";
            this.yesCovidPosButton.Size = new System.Drawing.Size(209, 45);
            this.yesCovidPosButton.TabIndex = 10;
            this.yesCovidPosButton.Text = "If yes, click here";
            this.yesCovidPosButton.UseVisualStyleBackColor = false;
            this.yesCovidPosButton.Click += new System.EventHandler(this.yesCovidPosButton_Click);
            // 
            // quarantineScheduleButton
            // 
            this.quarantineScheduleButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quarantineScheduleButton.Location = new System.Drawing.Point(20, 279);
            this.quarantineScheduleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quarantineScheduleButton.Name = "quarantineScheduleButton";
            this.quarantineScheduleButton.Size = new System.Drawing.Size(358, 45);
            this.quarantineScheduleButton.TabIndex = 8;
            this.quarantineScheduleButton.Text = "View my Quarantine Schedule";
            this.quarantineScheduleButton.UseVisualStyleBackColor = false;
            this.quarantineScheduleButton.Click += new System.EventHandler(this.quarantineScheduleButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(20, 71);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(362, 56);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Complete daily COVID work-fitness \r\nquestionnaire";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toDoLabel
            // 
            this.toDoLabel.AutoSize = true;
            this.toDoLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.toDoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toDoLabel.Location = new System.Drawing.Point(16, 30);
            this.toDoLabel.Name = "toDoLabel";
            this.toDoLabel.Size = new System.Drawing.Size(146, 29);
            this.toDoLabel.TabIndex = 16;
            this.toDoLabel.Text = "Daily To-Do";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.dateLabel.Font = new System.Drawing.Font("Constantia", 10F);
            this.dateLabel.Location = new System.Drawing.Point(48, 171);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(121, 24);
            this.dateLabel.TabIndex = 15;
            this.dateLabel.Text = "July 20, 2020";
            // 
            // goodMorningLabel
            // 
            this.goodMorningLabel.AutoSize = true;
            this.goodMorningLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.goodMorningLabel.Font = new System.Drawing.Font("Constantia", 13F);
            this.goodMorningLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.goodMorningLabel.Location = new System.Drawing.Point(47, 129);
            this.goodMorningLabel.Name = "goodMorningLabel";
            this.goodMorningLabel.Size = new System.Drawing.Size(253, 32);
            this.goodMorningLabel.TabIndex = 14;
            this.goodMorningLabel.Text = "Good Morning, John!";
            this.goodMorningLabel.Visible = false;
            // 
            // covidManagerLabel
            // 
            this.covidManagerLabel.AutoSize = true;
            this.covidManagerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.covidManagerLabel.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.covidManagerLabel.Location = new System.Drawing.Point(37, 33);
            this.covidManagerLabel.Name = "covidManagerLabel";
            this.covidManagerLabel.Size = new System.Drawing.Size(653, 88);
            this.covidManagerLabel.TabIndex = 13;
            this.covidManagerLabel.Text = "COVID MANAGER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::COVID_Management.Properties.Resources.Background;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1036, 244);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.companyNameLabel.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(901, 33);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(117, 26);
            this.companyNameLabel.TabIndex = 8;
            this.companyNameLabel.Text = "CANHacks";
            // 
            // companyLogoPicture
            // 
            this.companyLogoPicture.BackColor = System.Drawing.Color.Transparent;
            this.companyLogoPicture.BackgroundImage = global::COVID_Management.Properties.Resources.Maple_Leaf_Image;
            this.companyLogoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.companyLogoPicture.Location = new System.Drawing.Point(911, 63);
            this.companyLogoPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.companyLogoPicture.Name = "companyLogoPicture";
            this.companyLogoPicture.Size = new System.Drawing.Size(96, 89);
            this.companyLogoPicture.TabIndex = 11;
            this.companyLogoPicture.TabStop = false;
            this.companyLogoPicture.Click += new System.EventHandler(this.companyLogoPicture_Click);
            // 
            // managerNameLabel
            // 
            this.managerNameLabel.AutoSize = true;
            this.managerNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.managerNameLabel.Font = new System.Drawing.Font("Constantia", 10F);
            this.managerNameLabel.Location = new System.Drawing.Point(915, 156);
            this.managerNameLabel.Name = "managerNameLabel";
            this.managerNameLabel.Size = new System.Drawing.Size(92, 48);
            this.managerNameLabel.TabIndex = 10;
            this.managerNameLabel.Text = "Manager \r\nJane Doe";
            this.managerNameLabel.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(20, 71);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(407, 253);
            this.loginButton.TabIndex = 21;
            this.loginButton.Text = "Login to see your to-do list";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 650);
            this.Controls.Add(this.managerNameLabel);
            this.Controls.Add(this.covidManagerLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.companyLogoPicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.goodMorningLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label covidNewsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label toDoLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label goodMorningLabel;
        private System.Windows.Forms.Label covidManagerLabel;
        private System.Windows.Forms.Button quarantineScheduleButton;
        private System.Windows.Forms.Button yesCovidPosButton;
        private System.Windows.Forms.Label didYouTestPosForCovidLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.PictureBox companyLogoPicture;
        private System.Windows.Forms.Label managerNameLabel;
        private System.Windows.Forms.Button loginButton;
    }
}

