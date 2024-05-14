using System.Reflection.Metadata.Ecma335;

class MovieService
{
    /*
    Services:
        - Check Out Movies
        - Check In Movies
        - Get (Your*) Checked Out Movies
        - Get Available Movies
    
    Trivial Services:
        - Remember why we organize our application into layers.
            - It allows us to organize and clearly conceptualize the flow of operations
                within the application at any given moment of time.
        - We like to have the app ALWAYS flow Up and Down one Layer at a time!
    */

    MovieRepo mr = new();


    public Movie CheckIn(Movie m)
    {
        //Now lets do the same, but opposite tested logic.
        if (m.Available || m.ReturnDate == 0)
        {
            System.Console.WriteLine("Movie Currently not Checked Out");
            return null; //Movie doesnt get checked in
        }

        //Update the fields
        m.Available = true;
        m.ReturnDate = 0;

        //Make these changes permanent in the data storage
        mr.UpdateMovie(m);

        return m;
    }    
    public Movie CheckOut(Movie m) // m is the movie we want to attempt to check out
    {
        // Let's first check to see if the movie is Avaiable - OR return null if its not available - get that out of the way
        //this simplified version just check if its NOT available, return null, else proceed to checkout 
        if(m.Available == false) //shortened version if(!m.Available) -> ! is a null/not operator
        {
            System.Console.WriteLine("Movie is not currently available.");
            return null; // Movie cannot be checked out
        }
        
        //Happy Path Execution -> Movie is available and can be checked out
            //What does it actuallyt mean to checkout?
            // 1) the movie becomes unavailable
            // 2) a returnDate is set
            // 3) (optional) - its set to a particular user - future iteration
                // Need to make sure to update the data storage with these changes
        
        //Move becomes unavailable
        m.Available = false; 

        //Return Date Set for 2 weeks later
        m.ReturnDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + (60 * 60 * 24 * 14); //seconds * mins * hours * days to get 2 weeks (since UnixTimeSeconds, have to take seconds up to weeks)
        
        //Update the data storage with the changes
        mr.UpdateMovie(m);
        return m; //returning the checked out movie

        /* alternative method with If/Else w/shortened version... 
        if(m.Available == true)
        {
            // Then Perform Checkout
        }
        else
        {
            System.Console.WriteLine("Movie is not currently available.");
            return null; // Movie cannot be checked out
        }
        */
    }
    public List<Movie> GetAvailableMovies()
    {
        //Get All Movies
        List<Movie> allMovies = mr.GetAllMovies();
        
        //Then Filter Out Unavailable Movies (or whatever movies you dont want)
        List<Movie> availableMovies = new(); //create new list that will be come filtered list
        
        //To filter: Run a loop over all movies to determine if they are available to be added to the filtered list
        foreach(Movie m in allMovies)
        {
            if(m.Available == true)
            {
                availableMovies.Add(m);
            }
        }

        //Return Filtered List
        return availableMovies;
    } 

    //Ew, a Trivial Service!
    public Movie? GetMovie(int id)
    {
        return mr.GetMovie(id);
    }
}
