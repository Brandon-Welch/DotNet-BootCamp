class MovieStorage
{
    //This Entire Setup is TEMPORARY
    //We dont know how to work with DBs yet 
        //by extension - communicate with them
    //We are going to buuild some devices for Storing Movies
    //BUT everything is sadly lost everytime the application shuts down

    public Dictionary<int, Movie> movies;
    public int idCounter = 4; //normall start at 1 and then future is idCounter++

    //Making this constructor give us some pre-loaded Movies to work with.
    public MovieStorage()
    {
        Movie movie1 = new Movie(1, "Major Leage", 5.99, true, 0);
        Movie movie2 = new Movie(2, "Police Academy", 6.99, true, 0);
        Movie movie3 = new Movie(3, "Major Payne", 4.99, true, 0);
        Movie movie4 = new Movie(idCounter, "Stripes", 7.99, true, 0); idCounter++;

        movies = new(); //sets the dictionary to an empty collection
        movies.Add(1, movie1);
        movies.Add(movie2.Id, movie2); //Alternative, probably more proper syntax here - calls the movie2 object and pulls the ID to assign instead of hardcode
        movies.Add(3, movie3);
        movies.Add(movie4.Id, movie4);

        
        
    }


}