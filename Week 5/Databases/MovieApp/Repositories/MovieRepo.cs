class MovieRepo
{
    //This class is in the Data Access | Repository Layer of our application
    //Solely responsible for any data access and management centered around our movie object

    //4 major operations we would like ot manage in this location
        //CRUD Operations - most basic concepts of what you would like ot do with data
            //C - Create //in movieStorage.cs Dictionary
            //R - Read/Retreive / in Program.cs app
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

        //THIS IS A NEW METHOD!
    //No Parameters because...get everything is get everything. No options to choose.
    public List<Movie> GetAllMovies()
    {
        //I am choosing to return a List because that is a much more common collection to
        //work with. It does mean I have to do a little bit of work here - but its not bad.
        return movieStorage.movies.Values.ToList();
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
            System.Console.WriteLine("Sorry, no movie exists with that ID. Please try again.");
            return null; //Ryans option
        }

        //return movieStorage.movies[id]; //Alternative (shortened) approad to the broken down steps above
    }

    public Movie UpdateMovie(Movie updatedMovie)
    {
        try
        {
            //Assuming that the ID is consistent with an ID that exists, we just have to update the value (aka Movie) for said ID (key) within the dictionary
            movieStorage.movies[updatedMovie.Id] = updatedMovie; //movieStorage.movies accesses the dictionary then need to specify the property you want
            return updatedMovie;   
        }

        catch(Exception e)
        {
            System.Console.WriteLine("Sorry, no movie exists with that ID. Please try again.");
            return null;
        }
    }
    public Movie DeleteMovie(Movie m) //changing parameter so we can display which movie was deleted
    {
        //IF we have the ID > simply Remove it from storage
        bool didRemove = movieStorage.movies.Remove(m.Id);
        
        if (didRemove == true)
        {
            //since we declared the full moview in the parameters (Movie m), we stored all the movie variables so we are able to rturn the movie even after removed
            return m;
        }
        
        else
        {
            System.Console.WriteLine("Sorry, no movie exists with that ID. Please try again.");
            return null;
        }
        
    }
}