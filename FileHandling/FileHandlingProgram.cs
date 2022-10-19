using System;
using System.IO;
using System.Windows.Forms;

namespace FileHandling
{
    public partial class btnSearch : Form
    {
        // Setting the string path 
        string Path = @"War of the Worlds.txt";

        public btnSearch()
        {
            InitializeComponent();
        }

        // When the 'search' button is pressed
        private void btnSearchText_Click(object sender, EventArgs e)
        {
            // Set all variables to default values
            int LineNumber = 0, Count = 0;
            string AllLineNumbers = "";
            bool FirstNumber = true;

            // Loop through each line in War of the Worlds, checking if it contains the text enetered
            foreach (string line in File.ReadAllLines(Path))
            {
                LineNumber += 1;

                if (line.Contains(txtInput.Text))
                {
                    if (!FirstNumber) { AllLineNumbers += ", "; }       // Add a comma between each line number as long as its not the first one

                    // Add all line numbers to a string
                    AllLineNumbers += LineNumber.ToString();
                    Count += 1;
                    FirstNumber = false;
                }
            }

            // Print the results into the labels
            lblOutput.Text = "Found " + Count.ToString() + " times";
            if (Count > 0) { lblOutput2.Text = "Found on line(s): " + AllLineNumbers; }
        }

        // Unused routines
        private void Form1_Load(object sender, EventArgs e) { }
        private void lblOutput_Click(object sender, EventArgs e) { }
    }
}
