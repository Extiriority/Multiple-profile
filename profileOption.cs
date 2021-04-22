using ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            viewProfiles();
        }
        string constring = "Data Source=mssql.fhict.local;Initial Catalog=dbi463189_dataflix;Persist Security Info=True;User ID=dbi463189_dataflix;Password=Spreeuwen11%";
        
        private void createNewProfileButton_Click(object sender, EventArgs e)
        {
            profileCreationUI();
        }
        public void addProfileButton_Click(object sender, EventArgs e)
        {
            string name = inputNameBox.Text;

            if (name != "")
            {
                 SqlConnection conDatabase = new SqlConnection(constring);
                 try
                 {                       
                     conDatabase.Open();

                     string Query = "INSERT INTO GebruikerProfiel (ProfielNaam,Geboortedatum) VALUES ('" + inputNameBox.Text + "','" + birthDatePicker.Text + "');";
                     SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
                     SqlDataReader myReader = cmdDatabase.ExecuteReader();                   
                     profileOptionCreateUI();
                     resetInput();
                     viewProfiles();
                     MessageBox.Show($"Profiel {name} is aangemaakt");

                     while (myReader.Read())
                     {

                     }
                 }
                 finally
                 {
                     conDatabase.Close();
                 }                   
            }
            else
            {
                MessageBox.Show("Naam niet ingevuld!");
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            if (profileAddLabel.Visible == true)
            {
                profileOptionCreateUI();
            }
            else
            {
                profileOptionSaveUI();
            }
            resetInput();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (listProfileBox.Text == "")
            {
                MessageBox.Show($"U heeft geen profiel gekozen {Environment.NewLine}Selecteer of maak een nieuwe profiel aan!");
            }
            else
            {
                MessageBox.Show($"Profiel {listProfileBox.Text} gekozen");
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listProfileBox.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Wilt u uw profiel verwijderen?", $"Profiel verwijderen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection conDatabase = new SqlConnection(constring);
                    try
                    {
                        conDatabase.Open();

                        string Query = "DELETE FROM GebruikerProfiel WHERE ProfielNaam='" + inputEditNameBox.Text + "'";
                        SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
                        SqlDataReader myReader = cmdDatabase.ExecuteReader();
                        viewProfiles();
                        profileOptionSaveUI();
                        resetInput();

                        MessageBox.Show($"Profiel is verwijderd");

                        while (myReader.Read())
                        {

                        }
                    }
                    finally
                    {
                        conDatabase.Close();
                    }
                    deleteButton.Visible = false;
                    editButton.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show($"U heeft geen profiel gekozen {Environment.NewLine}om te verwijderen!");
            }          
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (listProfileBox.Text == "")
            {
                MessageBox.Show($"U heeft geen profiel gekozen {Environment.NewLine}om te bewerken!");
            }
            else
            {
                profileEditUI();
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string age = birthDateEditPicker.Text;
            string name = inputEditNameBox.Text;

            if (name == "" || age == "")
            {
                MessageBox.Show("Naam en/of leeftijd niet ingevuld");
            }
            else
            {
                SqlConnection conDatabase = new SqlConnection(constring);
                try
                {
                    conDatabase.Open();

                    string Query = "UPDATE GebruikerProfiel SET ProfielNaam='" + inputEditNameBox.Text + "' WHERE ProfielNaam='" + listProfileBox.SelectedItem.ToString() + "'";
                    SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
                    SqlDataReader myReader = cmdDatabase.ExecuteReader();
                    viewProfiles();
                    profileOptionSaveUI();
                    resetInput();

                    MessageBox.Show($"Profiel {name} is bewerkt");

                    while (myReader.Read())
                    {

                    }
                }
                finally
                {
                    conDatabase.Close();
                }


            }  
        }
        public void profileCreationUI()
        {
            profileAddLabel.Visible = true;
            nameLabel.Visible = true;
            inputNameBox.Visible = true;
            AgeLabel.Visible = true;
            birthDatePicker.Visible = true;
            addProfileButton.Visible = true;
            backButton.Visible = true;

            createNewProfileButton.Visible = false;
            whoLabelText.Visible = false;
            listProfileBox.Visible = false;
            continueButton.Visible = false;
            editButton.Visible = false;
            deleteButton.Visible = false;
        }
        public void profileOptionUI()
        {
            createNewProfileButton.Visible = true;
            whoLabelText.Visible = true;
            listProfileBox.Visible = true;
            continueButton.Visible = true;
        }
        public void profileOptionCreateUI()
        {
            profileAddLabel.Visible = false;
            nameLabel.Visible = false;
            inputNameBox.Visible = false;
            AgeLabel.Visible = false;
            birthDatePicker.Visible = false;
            addProfileButton.Visible = false;
            backButton.Visible = false;

            profileOptionUI();
        }

        public void profileOptionSaveUI()
        {
            profileEditLabel.Visible = false;
            nameEditLabel.Visible = false;
            inputEditNameBox.Visible = false;
            AgeEditLabel.Visible = false;
            birthDateEditPicker.Visible = false;
            saveButton.Visible = false;
            backButton.Visible = false;
            editButton.Visible = false;
            deleteButton.Visible = false;

            profileOptionUI();
        }

        public void profileEditUI() 
        {
            profileEditLabel.Visible = true;
            nameEditLabel.Visible = true;
            inputEditNameBox.Visible = true;
            AgeEditLabel.Visible = true;
            birthDateEditPicker.Visible = true;
            saveButton.Visible = true;
            backButton.Visible = true;

            editButton.Visible = false;
            deleteButton.Visible = false;
            createNewProfileButton.Visible = false;
            whoLabelText.Visible = false;
            listProfileBox.Visible = false;
            continueButton.Visible = false;
        }

        public void resetInput()
        {
            inputNameBox.Text = "";
            birthDatePicker.Text  = "1-1-2000";
        }

        private void listProfileBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;
            if (list.SelectedIndex != -1)
            {
                listProfileBox.SelectedIndex = list.SelectedIndex;
                hiddenAgeListBox.SelectedIndex = list.SelectedIndex;
                //hiddenIdListBox.SelectedIndex = list.SelectedIndex;

                inputEditNameBox.Text = listProfileBox.SelectedItem.ToString();
                birthDateEditPicker.Value = DateTime.Parse(hiddenAgeListBox.SelectedItem.ToString());
                //hiddenIdNameBox.Text = listProfileBox.SelectedItem.ToString();
            }
            deleteButton.Visible = true;
            editButton.Visible = true;
        }

        private void viewProfiles()
        {
            SqlConnection conDatabase = new SqlConnection(constring);
            try
            {
                listProfileBox.Items.Clear();
                hiddenAgeListBox.Items.Clear();
                //hiddenIdListBox.Items.Clear();

                conDatabase.Open();

                string Query = "SELECT * FROM GebruikerProfiel";
                SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
                SqlDataReader profileView = cmdDatabase.ExecuteReader();
                if (profileView.HasRows)
                {
                    while (profileView.Read())
                    {
                        listProfileBox.Items.Add(profileView["ProfielNaam"].ToString());
                        hiddenAgeListBox.Items.Add(profileView["Geboortedatum"].ToString());
                        //hiddenIdListBox.Items.Add(profileView["ProfielId"].ToString());
                    }
                }
            }
            finally
            {
                conDatabase.Close();
            }
        }
    }
}
