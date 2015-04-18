///--------------------------------------------------------------------------------------------------
///   Project:              Assignment 07 - Movie Bonanza – Online Streaming
/// 
///   Author:               Mohamad Al-Jaf   
///   
///   Date last modified:   April 17, 2015
///   
///   Program description:  A program that allows the user to select a Movie to view from an online
///                         video streaming service called “Movie Bonanza”. The selected Movie will 
///                         display its category and the cost to stream the movie. The application
///                         will then calculate the cost of the Movie (including taxes) in a separate 
///                         form. The cost will vary according to the category of the movie. The user 
///                         will be given the option to buy the movie and have a DVD copy sent to 
///                         him for an additional charge of $10.00 (including shipping).
///                         
///   Revision History:     2015-04-14: Initial build
///                         2015-04-16: Completed the selection form
///                         2015-04-17: Completed the order form
///                         2015-04-17: Completed StreamForm
///                         2015-04-17: Added documentation
///--------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment07
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        // displays the splash screen for 3 seconds and then loads the selection form
        private void timer1_Tick(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm();

            this.Hide();
            timer1.Enabled = false; //disables the timer to prevent it from looping
            selectionForm.Show();
        }
    }
}
