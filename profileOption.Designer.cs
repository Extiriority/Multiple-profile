
namespace MultipeProfileWinForm
{
    partial class dataflixProfiles
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.whoLabelText = new System.Windows.Forms.Label();
            this.createNewProfileButton = new System.Windows.Forms.Button();
            this.listProfileBox = new System.Windows.Forms.ListBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.profileAddLabel = new System.Windows.Forms.Label();
            this.comboAgeBox = new System.Windows.Forms.ComboBox();
            this.inputNameBox = new System.Windows.Forms.TextBox();
            this.addProfileButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // whoLabelText
            // 
            this.whoLabelText.AutoSize = true;
            this.whoLabelText.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.whoLabelText.Location = new System.Drawing.Point(260, 110);
            this.whoLabelText.Name = "whoLabelText";
            this.whoLabelText.Size = new System.Drawing.Size(256, 31);
            this.whoLabelText.TabIndex = 0;
            this.whoLabelText.Text = "Who is watching?";
            // 
            // createNewProfileButton
            // 
            this.createNewProfileButton.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewProfileButton.Location = new System.Drawing.Point(656, 12);
            this.createNewProfileButton.Name = "createNewProfileButton";
            this.createNewProfileButton.Size = new System.Drawing.Size(132, 23);
            this.createNewProfileButton.TabIndex = 1;
            this.createNewProfileButton.Text = "profiel aanmaken";
            this.createNewProfileButton.UseVisualStyleBackColor = true;
            this.createNewProfileButton.Click += new System.EventHandler(this.createNewProfileButton_Click);
            // 
            // listProfileBox
            // 
            this.listProfileBox.FormattingEnabled = true;
            this.listProfileBox.ItemHeight = 15;
            this.listProfileBox.Location = new System.Drawing.Point(260, 174);
            this.listProfileBox.Name = "listProfileBox";
            this.listProfileBox.Size = new System.Drawing.Size(256, 94);
            this.listProfileBox.TabIndex = 2;
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.continueButton.Location = new System.Drawing.Point(341, 328);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(89, 23);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Verdergaan";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgeLabel.Location = new System.Drawing.Point(272, 231);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(61, 14);
            this.AgeLabel.TabIndex = 12;
            this.AgeLabel.Text = "Leeftijd:";
            this.AgeLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(272, 156);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 14);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Naam:";
            this.nameLabel.Visible = false;
            // 
            // profileAddLabel
            // 
            this.profileAddLabel.AutoSize = true;
            this.profileAddLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profileAddLabel.Location = new System.Drawing.Point(260, 110);
            this.profileAddLabel.Name = "profileAddLabel";
            this.profileAddLabel.Size = new System.Drawing.Size(258, 31);
            this.profileAddLabel.TabIndex = 10;
            this.profileAddLabel.Text = "Profiel toevoegen";
            this.profileAddLabel.Visible = false;
            // 
            // comboAgeBox
            // 
            this.comboAgeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgeBox.FormattingEnabled = true;
            this.comboAgeBox.Items.AddRange(new object[] {
            "<11",
            "12-17",
            "18+"});
            this.comboAgeBox.Location = new System.Drawing.Point(272, 249);
            this.comboAgeBox.Name = "comboAgeBox";
            this.comboAgeBox.Size = new System.Drawing.Size(74, 23);
            this.comboAgeBox.TabIndex = 9;
            this.comboAgeBox.Visible = false;
            // 
            // inputNameBox
            // 
            this.inputNameBox.Location = new System.Drawing.Point(272, 174);
            this.inputNameBox.Name = "inputNameBox";
            this.inputNameBox.PlaceholderText = "Naam";
            this.inputNameBox.Size = new System.Drawing.Size(228, 23);
            this.inputNameBox.TabIndex = 8;
            this.inputNameBox.Visible = false;
            // 
            // addProfileButton
            // 
            this.addProfileButton.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProfileButton.Location = new System.Drawing.Point(345, 327);
            this.addProfileButton.Name = "addProfileButton";
            this.addProfileButton.Size = new System.Drawing.Size(82, 23);
            this.addProfileButton.TabIndex = 7;
            this.addProfileButton.Text = "Aanmaken";
            this.addProfileButton.UseVisualStyleBackColor = true;
            this.addProfileButton.Visible = false;
            this.addProfileButton.Click += new System.EventHandler(this.addProfileButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(713, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Terug";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataflixProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profileAddLabel);
            this.Controls.Add(this.comboAgeBox);
            this.Controls.Add(this.inputNameBox);
            this.Controls.Add(this.addProfileButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.listProfileBox);
            this.Controls.Add(this.createNewProfileButton);
            this.Controls.Add(this.whoLabelText);
            this.Name = "dataflixProfiles";
            this.Text = "Dataflix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label whoLabelText;
        private System.Windows.Forms.Button createNewProfileButton;
        private System.Windows.Forms.ListBox listProfileBox;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label profileAddLabel;
        private System.Windows.Forms.ComboBox comboAgeBox;
        private System.Windows.Forms.TextBox inputNameBox;
        private System.Windows.Forms.Button addProfileButton;
        private System.Windows.Forms.Button backButton;
    }
}

