class MovieStorage
{
    /*
    This Entire Setup iS TEMPORARY!
    We don't know how to work with Databases yet 
    - by extension - communicate with them

    SO we are going to build some devices for Storing Movies.
    BUT everything is sadly lost everytime the application shuts down.
    */

    public Dictionary<int, Movie> movies;
    public int idCounter = 1;

    //Making this constructor give us some pre-loaded Movies to work with.
    public MovieStorage()
    {
        Movie movie1 = new(idCounter, "Iron Man", 5, true, 0, null); idCounter++;
        Movie movie2 = new(idCounter, "The Avengers", 6, true, 0, null); idCounter++;
        Movie movie3 = new(idCounter, "Ant-Man", 4, true, 0, null); idCounter++;

        movies = []; //Sets the Dictionary to an empty collection.
        movies.Add(movie1.Id, movie1);
        movies.Add(movie2.Id, movie2);
        movies.Add(movie3.Id, movie3);
    }



}