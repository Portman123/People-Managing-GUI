using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp282_cw2_201319103
{
    public partial class Form1 : Form
    {
        // I decided to add features to the sorting buttons for fun
        //  - Clicking a sort button will sort it in ascending order
        //  - Next click sorts it in descending order
        //  - and so on...
        private bool _sortAscendingName;
        private bool _sortAscendingAge;


        // Create list to store people when they are added
        private List<Person> people = new List<Person>();

        public Form1()
        {
            InitializeComponent();
            _sortAscendingName = true;
            _sortAscendingAge = true;
        }

        // Method to get rid of contents of listbox and update
        private void updateListBox()
        {

            // Get current selection before changing anything =============DELETE==
            //int currentSelection = OutputListBox.SelectedIndex;

            // Clear old content
            OutputListBox.Items.Clear();

            // Add updated content
            foreach(Person item in people)
            {
                OutputListBox.Items.Add(item.Output());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Get contents of entry text boxes for new person's attributes
            string name = NameEntry.Text;
            int age = Int32.Parse(AgeEntry.Text);

            // Add new person to people list 
            people.Add(new Person(name, age));

            // Update display
            updateListBox();

            // Update current selection to the new person
            OutputListBox.SelectedIndex = people.Count -1;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Get users selected index
            int choice = OutputListBox.SelectedIndex;

            // Make sure something is selected before attempting removal
            if (choice != -1)
            {
                // Remove person at choice index from list
                people.RemoveAt(choice);

                // Update display
                updateListBox();

                // check if removed item was the last in the list
                if (choice == people.Count)
                {
                    // Update current selection to new last person in list
                    OutputListBox.SelectedIndex = people.Count - 1;
                } else
                {   // Otherwise selected is same index
                    OutputListBox.SelectedIndex = choice;
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Get contents of entry text boxes for new person's attributes
            string updatedName = NameEntry.Text;
            int updatedAge = Int32.Parse(AgeEntry.Text);

            // Get users selected index
            int choice = OutputListBox.SelectedIndex;

            // Make sure something is selected before attempting Update
            if (choice != -1)
            {
                // Update name and age of selected person
                people[choice].Name = updatedName;
                people[choice].Age = updatedAge;

                // Update display
                updateListBox();

                // Make sure selection stays on user's choice
                OutputListBox.SelectedIndex = choice;
            }
        }

        private void NameSortButton_Click(object sender, EventArgs e)
        {

            // Work out which person is currently selected before any changes
            bool itemIsSelected = false;
            Person selectedPerson = null;
            if (OutputListBox.SelectedIndex > -1)
            {
                selectedPerson = people[OutputListBox.SelectedIndex];
                itemIsSelected = true;
            }
            
            // Check which order to sort in 
            if (_sortAscendingName)
            {
                // Sort in ascending name order
                people.Sort(Person.CompareByName);
            }
            else
            {
                // Sort in descending name order
                people.Sort(Person.CompareByNameReverse);
            }

            _sortAscendingName = !_sortAscendingName;

            // Update display
            updateListBox();

            // Reselect selected person by finding their new index in list
            if (itemIsSelected)
            {
                OutputListBox.SelectedIndex = people.IndexOf(selectedPerson);
            }
        }

        private void AgeSortButton_Click(object sender, EventArgs e)
        {
            // Work out which person is currently selected before any changes
            bool itemIsSelected = false;
            Person selectedPerson = null;
            if (OutputListBox.SelectedIndex > -1)
            {
                selectedPerson = people[OutputListBox.SelectedIndex];
                itemIsSelected = true;
            }

            // Check which order to sort in 
            if (_sortAscendingAge)
            {
                // Sort in ascending age order
                people.Sort(Person.CompareByAge);
            }
            else
            {
                // Sort in descending age order
                people.Sort(Person.CompareByAgeReverse);
            }

            _sortAscendingAge = !_sortAscendingAge;

            // Update display
            updateListBox();

            // Reselect selected person by finding their new index in list
            if (itemIsSelected)
            {
                OutputListBox.SelectedIndex = people.IndexOf(selectedPerson);
            }
        }

        private void OutputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // To ensure consistency between selection and name and age boxes
            if ( OutputListBox.SelectedIndex >= 0 )
            {
                NameEntry.Text = people[OutputListBox.SelectedIndex].Name;
                AgeEntry.Text = people[OutputListBox.SelectedIndex].Age.ToString();
            }
        }
    }
}
