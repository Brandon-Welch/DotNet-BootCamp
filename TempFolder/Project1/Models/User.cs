class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }

    public User()
    {
        UserName = "";
        Password = "";
        Role = "";
    }

    public User(int id, string username, string password, string role)
    {
        Id = id;
        UserName = username;
        Password = password;
        Role = role;
    }

    public override string ToString()
    {
        return "{id:" + Id + ", username:'" + UserName + "', password:'" + Password + "', role:'" + Role + "'}";
    }

    public string GetUsername()
    {
        return UserName;

    }

    //below we have a method that returns a string representation of the user object
    public string GetPassword()
    {
        return Password;

    }
}