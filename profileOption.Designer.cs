
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
            // dataflixProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

