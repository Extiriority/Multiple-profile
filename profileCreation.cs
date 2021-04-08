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
    public partial class profileCreation : Form
    {
        public profileCreation()
        {
            InitializeComponent();
        }
        private dataflixProfiles mainForm = null;
        public profileCreation(Form callingForm)
        {
            mainForm = callingForm as dataflixProfiles;
            InitializeComponent();
        }
        
        private void addProfileButton_Click(object sender, EventArgs e)
        {
            if (inputNameBox.Text == "" || comboAgeBox.Text == "")
            {
                MessageBox.Show("Naam en/of leeftijd niet ingevuld");
            }
            else
            {
                string profile = $"{inputNameBox.Text} | {comboAgeBox.SelectedItem}";
                this.mainForm.profileList = profile;
                MessageBox.Show($"Profiel {inputNameBox.Text} is aangemaakt");
            }
            
        }
    }
}
