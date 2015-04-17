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
    public partial class StreamForm : Form
    {
        //PRIVATE INSTANCE VARIABLES ***************************************
        private double _grandTotal;
        private string _movieName;

        //CONSTRUCTOR ***************************************************
        public StreamForm(double grandTotal, string movieName)
        {
            InitializeComponent();
            this._grandTotal = grandTotal;
            this._movieName = movieName;

            //replaces the placeholders in the labels with the values of the movie
            GrandTotalLabel.Text = GrandTotalLabel.Text.Replace("[X dollars]", this._grandTotal.ToString("C"));
            MovieTitleLabel.Text = MovieTitleLabel.Text.Replace("[Your Movie]", this._movieName);
        }

        // PRIVATE METHODS ***************************************************
        // exits the application
        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
