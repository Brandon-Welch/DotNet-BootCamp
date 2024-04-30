using System.ComponentModel.Design;
using System.Dynamic;

namespace Media
{
    class Movie
        {
            public string Title { get; set; }
            public int Rating { get; set; }
            public double Price { get; set; }
            
            public Movie ()
            {
                Title = "";
            }

            public Movie (string title, int rating, double price)
            {
                Title = title;
                Rating = rating;
                Price = price;
            }
        }
}