class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
    public bool Available { get; set; } 
    public long ReturnDate { get; set; }

    //User who checks out a movie
    public User RentedUser { get; set; }
    
    public Movie()
    {
        Title = "";
    }

    public Movie(int id, string title, double price, bool available, long returnDate, User rentedUser)
    {
        Id = id;
        Title = title;
        Price = price;
        Available = available;
        ReturnDate = returnDate;
        RentedUser = rentedUser;
    }

    public override string ToString()
    {
        //return "{'id':" + Id + ",'title':" + Title ",'price':" + Price + ",'available':" + Available + "'returnDate':" + ReturnDate + "}";
        return $"id: {Id}, title: '{Title}', price: ${Price}, available: {Available}, returnDate: {ReturnDate}, rentedUser: {RentedUser.ToString()}"; //string interpolation option ALSO could replace  the rentedUser toString to just the UserId RenterdUser.Id
    }
}