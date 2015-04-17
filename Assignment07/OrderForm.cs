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

        public OrderForm(Movie selectedMovie)
        {
            InitializeComponent();
            this._selectedMovie = selectedMovie;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
