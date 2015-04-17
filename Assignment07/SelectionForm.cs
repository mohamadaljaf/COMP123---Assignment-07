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
    public partial class SelectionForm : Form
    {
        //PRIVATE INSTANCE VARIABLES ***************************************
        private List<Movie> Movies = new List<Movie>();
        int _movieIndex;

        //CONSTRUCTORS ***************************************************
        public SelectionForm()
        {
            InitializeComponent();
            InitializeMovieList();
            InitializeMovieComboBox();
        }

        // Overloaded constructor that calls the default constructor. Is used for when the user hits the back button in OrderForm
        public SelectionForm(Movie selectedMovie) : this()
        {
            this._movieIndex = Movies.FindIndex(i => i.Title.Equals(selectedMovie.Title)); //finds the index of the selected movie from the list
            MovieComboBox.SelectedIndex = this._movieIndex; //selects the movie in the ComboBox
        }

        // PRIVATE METHODS ***************************************************
        // adds the movie titles and categories to the movies list
        private void InitializeMovieList()
        {
            Movies.Add(new Movie("Season of the Witch", "Sci-Fi", "seasonofthewitch"));
            Movies.Add(new Movie("The Green Hornet", "Action", "thegreenhornet"));
            Movies.Add(new Movie("The Dilemma", "Comedy", "thedilemma"));
            Movies.Add(new Movie("Death Race 2", "Action", "deathrace2"));
            Movies.Add(new Movie("Company Men", "Drama", "companymen"));
            Movies.Add(new Movie("No Strings Attached", "Comedy", "nostringsattached"));
            Movies.Add(new Movie("The Way Back", "Drama", "thewayback"));
            Movies.Add(new Movie("The Mechanic", "Action", "themechanic"));
            Movies.Add(new Movie("The Rite", "Horror", "therite"));
            Movies.Add(new Movie("Sanctum", "Action", "sanctum"));
            Movies.Add(new Movie("The Other Woman", "Action", "theotherwoman"));
            Movies.Add(new Movie("The Roommate", "Thriller", "theroommate"));
            Movies.Add(new Movie("Waiting for Forever", "Drama", "waitingforever"));
            Movies.Add(new Movie("Cedar Rapids", "Comedy", "cedarrapids"));
            Movies.Add(new Movie("Gnomeo and Juliet", "Family", "gnomeoandjuliet"));
            Movies.Add(new Movie("Just Go With It", "Comedy", "justgowithit"));
            Movies.Add(new Movie("The Eagle", "Action", "theeagle"));
            Movies.Add(new Movie("I am Number Four", "Sci-Fi", "iamnumberfour"));
            Movies.Add(new Movie("Footloose", "New Release", "footloose"));
            Movies.Add(new Movie("Real Steel", "New Release", "realsteel"));

            Movies.Sort();
        }

        // adds the movie titles in the movies list to the combo box
        private void InitializeMovieComboBox()
        {
            foreach (var movie in Movies)
            {
                MovieComboBox.Items.Add(movie.Title);
            }
        }

        // Updates the textboxes and picture box to match the selected movie
        private void MovieListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._movieIndex = MovieComboBox.SelectedIndex;
            NextButton.Enabled = true;

            MovieTitleTextBox.Text = Movies[this._movieIndex].Title;
            MovieCategoryTextBox.Text = Movies[this._movieIndex].Category;
            MovieCostTextBox.Text = Movies[this._movieIndex].Cost.ToString("C");
            MoviePictureBox.Image =
                Properties.Resources.ResourceManager.GetObject(Movies[this._movieIndex].ImageName) as Image; //loads the image based on the image name from the resources
        }

        // Loads the OrderForm and hides the SelectionForm
        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(Movies[this._movieIndex]);

            this.Hide();
            orderForm.Owner = this;
            orderForm.Show();
        }
    }
}
