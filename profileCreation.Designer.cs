
namespace MultipeProfileWinForm
{
    partial class profileCreation
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
            this.addProfileButton = new System.Windows.Forms.Button();
            this.inputNameBox = new System.Windows.Forms.TextBox();
            this.comboAgeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addProfileButton
            // 
            this.addProfileButton.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProfileButton.Location = new System.Drawing.Point(182, 246);
            this.addProfileButton.Name = "addProfileButton";
            this.addProfileButton.Size = new System.Drawing.Size(82, 23);
            this.addProfileButton.TabIndex = 0;
            this.addProfileButton.Text = "Aanmaken";
            this.addProfileButton.UseVisualStyleBackColor = true;
            this.addProfileButton.Click += new System.EventHandler(this.addProfileButton_Click);
            // 
            // inputNameBox
            // 
            this.inputNameBox.Location = new System.Drawing.Point(36, 119);
            this.inputNameBox.Name = "inputNameBox";
            this.inputNameBox.PlaceholderText = "Naam";
            this.inputNameBox.Size = new System.Drawing.Size(228, 23);
            this.inputNameBox.TabIndex = 1;
            // 
            // comboAgeBox
            // 
            this.comboAgeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgeBox.FormattingEnabled = true;
            this.comboAgeBox.Items.AddRange(new object[] {
            "<11",
            "12-17",
            "18+"});
            this.comboAgeBox.Location = new System.Drawing.Point(36, 194);
            this.comboAgeBox.Name = "comboAgeBox";
            this.comboAgeBox.Size = new System.Drawing.Size(74, 23);
            this.comboAgeBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Profiel toevoegen";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(36, 101);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 14);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Naam:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgeLabel.Location = new System.Drawing.Point(36, 176);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(61, 14);
            this.AgeLabel.TabIndex = 6;
            this.AgeLabel.Text = "Leeftijd:";
            // 
            // profileCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 304);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAgeBox);
            this.Controls.Add(this.inputNameBox);
            this.Controls.Add(this.addProfileButton);
            this.Name = "profileCreation";
            this.Text = "profileCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProfileButton;
        private System.Windows.Forms.TextBox inputNameBox;
        private System.Windows.Forms.ComboBox comboAgeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label AgeLabel;
    }
}