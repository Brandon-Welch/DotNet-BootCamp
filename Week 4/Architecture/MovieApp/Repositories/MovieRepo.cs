class MovieRepo
{
    //This class is in the Data Access | Repository Layer of our application
    //Solely responsible for any data access and management centered around our movie object

    //4 major operations we would like ot manage in this location
        //CRUD Operations - most basic concepts of what you would like ot do with data
            //C - Create
            //R - Read/Retreive
            //U - Update
            //D - Delete

    MovieStorage movieStorage = new();


    public Movie AddMovie(Movie m) //m is referencing the actual Movie object, so if we return m, we are returning the actual Movie object
    {
        //We need to first ensure the movie being added has a correct ID
        //Assume it doesnt and force it to have a correct ID using our idCounter (comes from the MovieStorage Utility)

        m.Id = movieStorage.idCounter; //m from the AddMovie(Movie m) above
        movieStorage.idCounter++; //increment for next ID to be next in line

        //Add the movie to our collection
        movieStorage.movies.Add(m.Id, m); //Movie.Id, Movie
        return m;
    }

    public Movie GetMovie(int id) //ID is the KEY in our dictionary
    {
        //We need to retrieve (return) the movie - in our case, we are using the unique identifier i.e. ID which is our key
        if (movieStorage.movies.ContainsKey(id))
        {
            Movie selectedMovie = movieStorage.movies[id];
            return selectedMovie;
        }
        else
        {
            System.Console.WriteLine("Sorry, no movie exists with that ID.");
            return null; //Ryans option
        }

        //return movieStorage.movies[id]; //Alternative (shortened) approad to the broken down steps above
    }
}