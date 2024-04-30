class Child : Parent
{
    public string FavoriteGame { get; set; }

    public Child()
    {
         FavoriteGame = "";
    }

    public Child(string jobTitle, string favoriteGame) : base(jobTitle) //using base(param) since we are using from parent class
    {
        JobTitle = jobTitle;
        FavoriteGame = favoriteGame;        
    }

    public void Play()
    {
        System.Console.WriteLine("Playing my favorite game: " + FavoriteGame);
    }

    public override void Work() //this is now an overridden method which changes its implementation for this class only
    {
        System.Console.WriteLine("Doing my homework to get good grades!");
    }
}