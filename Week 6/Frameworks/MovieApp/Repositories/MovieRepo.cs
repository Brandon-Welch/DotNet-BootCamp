class MovieRepo
{
    /*
    This class is in the Data Access / Repository Layer of our application.
    So it solely responsible for any data access and management centered
    around our Movie Object.

    4 Major Operations we'd like to manage in this location.
        - CRUD Operations
        - C - Create
        - R - Read
        - U - Update
        - D - Delete
    */

    MovieStorage movieStorage = new();


    public Movie AddMovie(Movie m)
    {
        //We need first ensure that the movie being added has a correct ID.
        //Assume it doesnt...and force it to have a correct ID using our idCounter.
        m.Id = movieStorage.idCounter++; //incrementing the value afterwards, to prep it for the next time it's needed.

        //Add the movie into our collection.
        movieStorage.movies.Add(m.Id, m);
        return m;
    }

    public Movie? GetMovie(int id)
    {
        // Alternative approach that breaks each step down.
        if (movieStorage.movies.ContainsKey(id))
        {
            Movie selectedMovie = movieStorage.movies[id];
            return selectedMovie;
            // return movieStorage.movies[id];
        }
        else
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try Again");
            return null;
        }
    }

    //THIS IS A NEW METHOD!
    //No Parameters because...get everything is get everything. No options to choose.
    public List<Movie> GetAllMovies()
    {
        //I am choosing to return a List because that is a much more common collection to
        //work with. It does mean I have to do a little bit of work here - but its not bad.
        return movieStorage.movies.Values.ToList();
    }


    public Movie? UpdateMovie(Movie updatedMovie)
    {
        //Assuming that the ID is consistent with an ID that exists
        //then we just have to update the value (aka Movie) for said key (ID) within the Dictionary.
        try
        {
            movieStorage.movies[updatedMovie.Id] = updatedMovie;
            //I choose to send the updated movie back as a "response-feedback" system.
            //"Here is me telling you that I have updated the storage with this movie I send back to you"
            return updatedMovie;
        }
        catch (Exception)
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try Again");
            return null;
        }
    }

    public Movie? DeleteMovie(Movie m)
    {
        //If we have the ID -> then simply Remove it from storage
        bool didRemove = movieStorage.movies.Remove(m.Id);

        if (didRemove)
        {
            //now we will return the movie that got deleted.
            return m;
        }
        else
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try Again");
            return null;
        }
    }

}