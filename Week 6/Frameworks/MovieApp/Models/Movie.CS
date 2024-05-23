class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
    public bool Available { get; set; }
    public long ReturnDate { get; set; }

    //User who checks out the Movie:
    public User? Renter { get; set; }

    public Movie()
    {
        Title = "";
    }

    public Movie(int id, string title, double price, bool available, long returnDate, User? renter)
    {
        Id = id;
        Title = title;
        Price = price;
        Available = available;
        ReturnDate = returnDate;
        Renter = renter;
    }

    public override string ToString()
    {
        return "{id:" + Id
        + ",title:'" + Title
        + "',price:" + Price
        + ",available:" + Available
        + ",returnDate:" + ReturnDate
        + ",renter:" + Renter?.ToString() + "}";
    }

}