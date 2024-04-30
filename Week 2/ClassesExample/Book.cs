/*
General structure to Models:
    - fields (properties)
    - constructors
    - methods
*/

// Enxapsulation
//  -Hiding/Protecting our data to further control who has access
//  -this is not to "secure/encrypt" our data, its only meant to minimize manipulation
//      - Make "private" fields
//      - Make "public" methods for accessing and manipulating those fields
//          -Acccessing the field: Accessors aka Getters
//          -Modifying the field: Modifiers aka Mutators aka Setters

class Book
{
    // //Fields----------------------
    // string title;
    // string author;
    // int pages;

    //Alternative - Properties (Alt to Fields)
    public string Title { get; set; } //creates underlying field title (private) and getters/setters (public)
    public string Author { get; set; }
    public int Pages { get; set; }
    
    //Constructors------------------

    public Book()
    {

    }

    public Book(string title, string author, int pages)
    {
        Title = title; //capital is property, lowercase is parameter
        Author = author;
        Pages = pages;
    }


    //Methods-------------------




/*
    //Getters and Setters (OUTDATED - preferred to use )
    public string getTitle()
    {
        return title;
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }

*/

    //ToSring------------------





}