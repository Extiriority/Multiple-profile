using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipeProfileWinForm
{
    public partial class dataflixProfiles : Form
    {
        
        public dataflixProfiles()
        {
            InitializeComponent();
        }

        private void createNewProfileButton_Click(object sender, EventArgs e)
        {
            profileCreationUI();
        }
        public void addProfileButton_Click(object sender, EventArgs e)
        {
            string age = comboAgeBox.Text;
            string name = inputNameBox.Text;

            if (name == "" || age == "")
            {
                MessageBox.Show("Naam en/of leeftijd niet ingevuld");
            }
            else
            {
                string profile = $"{name} | {age}";
                
                if (listProfileBox.Items.Contains(profile))
                {
                    MessageBox.Show($"U heeft al een naam die {name} heet");
                }
                else
                {
                    listProfileBox.Items.Add(profile);
                    MessageBox.Show($"Profiel {name} is aangemaakt");
                    profileOptionUI();
                    resetInput();
                }
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            profileOptionUI();
            resetInput();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (listProfileBox.Text == "")
            {
                MessageBox.Show($"U heeft geen profiel gekozen {Environment.NewLine}Selecteer of maak een nieuwe profiel aan");
            }
            else
            {
                MessageBox.Show($"Profiel {listProfileBox.Text} gekozen");
            }
        }

        public void profileCreationUI()
        {
            profileAddLabel.Visible = true;
            nameLabel.Visible = true;
            inputNameBox.Visible = true;
            AgeLabel.Visible = true;
            comboAgeBox.Visible = true;
            addProfileButton.Visible = true;
            backButton.Visible = true;

            createNewProfileButton.Visible = false;
            whoLabelText.Visible = false;
            listProfileBox.Visible = false;
            continueButton.Visible = false;
            
        }

        public void profileOptionUI()
        {
            profileAddLabel.Visible = false;
            nameLabel.Visible = false;
            inputNameBox.Visible = false;
            AgeLabel.Visible = false;
            comboAgeBox.Visible = false;
            addProfileButton.Visible = false;
            backButton.Visible = false;

            createNewProfileButton.Visible = true;
            whoLabelText.Visible = true;
            listProfileBox.Visible = true;
            continueButton.Visible = true;
        }

        public void resetInput()
        {
            inputNameBox.Text = "";
            comboAgeBox.SelectedIndex = -1;
        }
    }
}
