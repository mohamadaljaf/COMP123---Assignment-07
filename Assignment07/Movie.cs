using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07
{
    // MOVIE CLASS
    public class Movie : IComparable<Movie>
    {
        // PRIVATE INSTANCE VARIABLES ***********************************************
        private string _title;
        private string _category;
        private string _imageName;
        private double _cost;

        // PUBLIC PROPERTIES ***********************************************
        public string Title
        {
            get { return this._title; } // Read-Only
        }
        public string Category
        {
            get { return this._category; } // Read-Only
        }
        public string ImageName
        {
            get { return this._imageName; } // Read-Only
        }

        public double Cost
        {
            get { return this._cost; } // Read-Only
        }

        // CONSTRUCTOR ***********************************************
        public Movie(string title, string category, string image)
        {
            this._title = title;
            this._category = category;
            this._imageName = image;
            this.CategoryCost(); //gets the cost of the movie based on the category
        }

        // assigns a cost based on the category of the movie
        private void CategoryCost()
        {
            switch (this._category)
            {
                case "Comedy":
                case "Drama":
                case "Thriller":
                    this._cost = 1.99;
                    break;
                case "Action":
                case "Sci-Fi":
                case "Horror":
                    this._cost = 2.99;
                    break;
                case "Family":
                    this._cost = 0.99;
                    break;
                case "New Release":
                    this._cost = 4.99;
                    break;
            }
        }

        // PUBLIC METHODS
        // Default comparer for Movie type - compares the title property
        public int CompareTo(Movie compareMovie)
        {
            // A null value means that this object is greater. 
            if (compareMovie == null)
                return 1;

            else
                return this._title.CompareTo(compareMovie._title);
        }
    }
}
