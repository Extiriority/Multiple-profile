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
            profileCreation profileCreationWindow = new profileCreation(this);
            profileCreationWindow.Show();
        }

        public string profileList
        {
            get 
            { 
                return listProfileBox.Text; 
            }
            set 
            {
                listProfileBox.Text = value;
                listProfileBox.Items.Add(listProfileBox.Text);
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Ingelogd in {listProfileBox.Text}");
        }
    }
}
