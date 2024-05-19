class Account
{
    public int Id { get; set; }
    public decimal Balance { get; set; }
    //public int UserId { get; set; } //Required foreign key property
    //public User User { get; set; } = null!; //Rquired Reference navigation to User principal
    public string Type { get; set; }
    public double Price { get; set; }
    public bool Available { get; set; }
    //public long ReturnDate { get; set; }


    public Account()
    {

    }

    //public Account(int id, decimal balance, int userId)
    public Account(int id, decimal balance)
    {
        Id = id;
        Balance = balance;
        //UserId = userId;
    }

    //public Account(int id, decimal balance, int userId, string type, double price, bool available, long returnDate)
    public Account(int id, decimal balance, string type, double price, bool available)
    {
        Id = id;
        Balance = balance;
        //UserId = userId;
        Type = type;
        Price = price;
        Available = available;
        //ReturnDate = returnDate;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Type: {Type}, Balance: {Balance.ToString("C")}"; //string interpolation to provide Account ID, Account Type and Account Balance to List of Accounts
    }
}