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

        // PRIVATE METHODS ***************************************************
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

        // PUBLIC METHODS ***************************************************
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
