using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileHandling
{
    public partial class btnSearch : Form
    {
        string Path = @"War of the Worlds.txt";

        public btnSearch()
        {
            InitializeComponent();
        }

        // Upon clicking the 'Search' button
        private void button1_Click(object sender, EventArgs e)
        {
            // Initialise local variables
            int LineNumber = 0;
            string AllLineNumbers = "";
            int Count = 0;

            // Loop through each line in the text file found at the path
            foreach (string line in System.IO.File.ReadAllLines(Path))
            {
                // Keep LineNumber as the counter
                LineNumber += 1;
                // Check if user's text is in the text file, then add the line number to the list
                if (line.Contains(txtInput.Text))
                {
                    AllLineNumbers += LineNumber.ToString() + ", ";
                    Count += 1;
                }
                // Display all times that text can be found in the file
                Console.WriteLine(LineNumber);
            }
            // Print to GUI
            lblOutput.Text = "Found " + Count.ToString() + " times";
            lblOutput2.Text = "Found on lines: " + AllLineNumbers;
        }
    }
}
