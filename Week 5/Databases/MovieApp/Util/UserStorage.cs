class UserStorage
{
    public Dictionary<int, User> users;
    public int idCounter = 1; //normall start at 1 and then future is idCounter++

    //Making this constructor give us some pre-loaded Accounts to work with.
    public UserStorage()
    {
        User user1 = new User(idCounter, "ryan", "pass1", "user"); idCounter++;
        User user2 = new User(idCounter, "jonathan", "pass2", "user"); idCounter++;
        User user3 = new User(idCounter, "admin", "pass3", "admin"); idCounter++;

        users = [];
        users.Add(user1.Id, user1);
        users.Add(user2.Id, user2);
        users.Add(user3.Id, user3);

        
        
    }
}