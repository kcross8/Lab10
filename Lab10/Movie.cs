using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Movie
    {
        //fields
        private string title;
        private string category;

        //properties
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        //constructors
        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }
        public Movie() //default
        {
            title = "Movie";
            category = "Film";
        }

        //methods
        public void PrintMovieTitle(string input)
        {
            if (input == category)
            {
                Console.WriteLine($"{title}");
            }            
        }


    }
}
