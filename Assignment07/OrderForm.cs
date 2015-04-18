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
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment07
{
    public partial class OrderForm : Form
    {
        //PRIVATE INSTANCE VARIABLES ***************************************
        private Movie _selectedMovie;
        private double _cost, _subTotal, _salesTax, _grandTotal;
        private const double _orderDVDCost = 10.00; // double constant - cost of ordering a dvd

        //CONSTRUCTOR ***************************************************
        public OrderForm(Movie selectedMovie)
        {
            InitializeComponent();
            this._selectedMovie = selectedMovie;
            this._cost = this._selectedMovie.Cost;

            //loads and displays the movie's information
            TitleTextBox.Text = this._selectedMovie.Title;
            CategoryTextBox.Text = this._selectedMovie.Category;
            CostTextBox.Text = this._cost.ToString("C");
            MoviePictureBox.Image = Properties.Resources.ResourceManager.GetObject(this._selectedMovie.ImageName) as Image;

            CalculateCost();
        }

        // PRIVATE METHODS ***************************************************
        // Calculates the cost of the movie and displays it onto the textboxes
        private void CalculateCost()
        {
            if (OrderDVDCheckBox.Checked) //if the user has ordered a dvd
            {
                this._subTotal = this._cost + _orderDVDCost;
                this.OrderDVDCostLabel.Visible = true;
                this.OrderDVDCostTextBox.Visible = true;
            }
            else
            {
                // the user has not ordered a dvd or has changed their minds
                this._subTotal = this._cost;
                this.OrderDVDCostLabel.Visible = false;
                this.OrderDVDCostTextBox.Visible = false;
            }

            this._salesTax = this._subTotal*0.13;
            this._grandTotal = this._subTotal + this._salesTax;

            //displays the calculations in the textboxes
            SubTotalTextBox.Text = this._subTotal.ToString("C");
            SalesTaxTextBox.Text = this._salesTax.ToString("C");
            GrandTotalTextBox.Text = this._grandTotal.ToString("C");
        }

        // goes back to the selectionForm with the selectedMovie passed and hides this form
        private void BackButton_Click(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm(this._selectedMovie);

            this.Hide();
            selectionForm.Owner = this;
            selectionForm.Show();
        }

        // Exits the application
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Loads the streamForm and hides this form
        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm streamForm = new StreamForm(this._grandTotal, this._selectedMovie.Title);

            this.Hide();
            streamForm.Owner = this;
            streamForm.Show();
        }

        // shows the about box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        // updates the cost information and also changes the visiblity of the order dvd label and textbox
        private void OrderDVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.CalculateCost();
        }

        // print previews the form
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = PrintAction.PrintToPreview;
            printForm1.Print();
        }
    }
}
