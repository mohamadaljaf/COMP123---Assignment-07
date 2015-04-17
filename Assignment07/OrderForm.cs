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
    public partial class OrderForm : Form
    {
        //private instance variables
        private Movie _selectedMovie;
        private double _cost, _subTotal, _salesTax, _grandTotal;
        private const double _orderDVDCost = 10.00; // constant double cost of order dvd

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
            StreamForm streamForm = new StreamForm();

            this.Hide();
            streamForm.Owner = this;
            streamForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        // updates the cost information and also changes the visiblity of the order dvd label and textbox
        private void OrderDVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.CalculateCost();
        }
    }
}
