
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
            this.components = new System.ComponentModel.Container();
            this.whoLabelText = new System.Windows.Forms.Label();
            this.createNewProfileButton = new System.Windows.Forms.Button();
            this.listProfileBox = new System.Windows.Forms.ListBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.profileAddLabel = new System.Windows.Forms.Label();
            this.inputNameBox = new System.Windows.Forms.TextBox();
            this.addProfileButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.profileEditLabel = new System.Windows.Forms.Label();
            this.AgeEditLabel = new System.Windows.Forms.Label();
            this.nameEditLabel = new System.Windows.Forms.Label();
            this.inputEditNameBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.hiddenAgeListBox = new System.Windows.Forms.ListBox();
            this.birthDateEditPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.createNewProfileButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createNewProfileButton.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewProfileButton.Location = new System.Drawing.Point(656, 12);
            this.createNewProfileButton.Name = "createNewProfileButton";
            this.createNewProfileButton.Size = new System.Drawing.Size(132, 23);
            this.createNewProfileButton.TabIndex = 1;
            this.createNewProfileButton.Text = "profiel aanmaken";
            this.createNewProfileButton.UseVisualStyleBackColor = false;
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
            this.listProfileBox.SelectedIndexChanged += new System.EventHandler(this.listProfileBox_SelectedIndexChanged);
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.PaleGreen;
            this.continueButton.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.continueButton.Location = new System.Drawing.Point(341, 328);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(89, 23);
            this.continueButton.TabIndex = 3;
            this.continueButton.Text = "Verdergaan";
            this.continueButton.UseVisualStyleBackColor = false;
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
            this.addProfileButton.BackColor = System.Drawing.Color.PaleGreen;
            this.addProfileButton.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProfileButton.Location = new System.Drawing.Point(345, 327);
            this.addProfileButton.Name = "addProfileButton";
            this.addProfileButton.Size = new System.Drawing.Size(82, 23);
            this.addProfileButton.TabIndex = 7;
            this.addProfileButton.Text = "Aanmaken";
            this.addProfileButton.UseVisualStyleBackColor = false;
            this.addProfileButton.Visible = false;
            this.addProfileButton.Click += new System.EventHandler(this.addProfileButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButton.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(713, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Terug";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.MistyRose;
            this.deleteButton.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(555, 231);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Verwijderen";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editButton.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(562, 193);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 23);
            this.editButton.TabIndex = 15;
            this.editButton.Text = "Bewerken";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveButton.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.Location = new System.Drawing.Point(353, 328);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Opslaan";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // profileEditLabel
            // 
            this.profileEditLabel.AutoSize = true;
            this.profileEditLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profileEditLabel.Location = new System.Drawing.Point(267, 110);
            this.profileEditLabel.Name = "profileEditLabel";
            this.profileEditLabel.Size = new System.Drawing.Size(249, 31);
            this.profileEditLabel.TabIndex = 17;
            this.profileEditLabel.Text = "Profiel bewerken";
            this.profileEditLabel.Visible = false;
            // 
            // AgeEditLabel
            // 
            this.AgeEditLabel.AutoSize = true;
            this.AgeEditLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgeEditLabel.Location = new System.Drawing.Point(274, 231);
            this.AgeEditLabel.Name = "AgeEditLabel";
            this.AgeEditLabel.Size = new System.Drawing.Size(61, 14);
            this.AgeEditLabel.TabIndex = 21;
            this.AgeEditLabel.Text = "Leeftijd:";
            this.AgeEditLabel.Visible = false;
            // 
            // nameEditLabel
            // 
            this.nameEditLabel.AutoSize = true;
            this.nameEditLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameEditLabel.Location = new System.Drawing.Point(274, 156);
            this.nameEditLabel.Name = "nameEditLabel";
            this.nameEditLabel.Size = new System.Drawing.Size(47, 14);
            this.nameEditLabel.TabIndex = 20;
            this.nameEditLabel.Text = "Naam:";
            this.nameEditLabel.Visible = false;
            // 
            // inputEditNameBox
            // 
            this.inputEditNameBox.Location = new System.Drawing.Point(274, 174);
            this.inputEditNameBox.Name = "inputEditNameBox";
            this.inputEditNameBox.PlaceholderText = "Naam";
            this.inputEditNameBox.Size = new System.Drawing.Size(228, 23);
            this.inputEditNameBox.TabIndex = 18;
            this.inputEditNameBox.Visible = false;
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CustomFormat = "dd-MM-yyyy";
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDatePicker.Location = new System.Drawing.Point(272, 248);
            this.birthDatePicker.MaxDate = new System.DateTime(2021, 4, 21, 0, 0, 0, 0);
            this.birthDatePicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(100, 23);
            this.birthDatePicker.TabIndex = 22;
            this.birthDatePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.birthDatePicker.Visible = false;
            // 
            // hiddenAgeListBox
            // 
            this.hiddenAgeListBox.FormattingEnabled = true;
            this.hiddenAgeListBox.ItemHeight = 15;
            this.hiddenAgeListBox.Location = new System.Drawing.Point(12, 177);
            this.hiddenAgeListBox.Name = "hiddenAgeListBox";
            this.hiddenAgeListBox.Size = new System.Drawing.Size(120, 94);
            this.hiddenAgeListBox.TabIndex = 23;
            this.hiddenAgeListBox.Visible = false;
            // 
            // birthDateEditPicker
            // 
            this.birthDateEditPicker.CustomFormat = "dd-MM-yyyy";
            this.birthDateEditPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateEditPicker.Location = new System.Drawing.Point(272, 248);
            this.birthDateEditPicker.MaxDate = new System.DateTime(2021, 4, 21, 0, 0, 0, 0);
            this.birthDateEditPicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.birthDateEditPicker.Name = "birthDateEditPicker";
            this.birthDateEditPicker.Size = new System.Drawing.Size(100, 23);
            this.birthDateEditPicker.TabIndex = 24;
            this.birthDateEditPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.birthDateEditPicker.Visible = false;
            // 
            // dataflixProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.birthDateEditPicker);
            this.Controls.Add(this.hiddenAgeListBox);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.AgeEditLabel);
            this.Controls.Add(this.nameEditLabel);
            this.Controls.Add(this.inputEditNameBox);
            this.Controls.Add(this.profileEditLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profileAddLabel);
            this.Controls.Add(this.inputNameBox);
            this.Controls.Add(this.addProfileButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.listProfileBox);
            this.Controls.Add(this.createNewProfileButton);
            this.Controls.Add(this.whoLabelText);
            this.Name = "dataflixProfiles";
            this.Text = "Dataflix";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.TextBox inputNameBox;
        private System.Windows.Forms.Button addProfileButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label profileEditLabel;
        private System.Windows.Forms.Label AgeEditLabel;
        private System.Windows.Forms.Label nameEditLabel;
        private System.Windows.Forms.TextBox inputEditNameBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.ListBox hiddenAgeListBox;
        private System.Windows.Forms.DateTimePicker birthDateEditPicker;
    }
}

