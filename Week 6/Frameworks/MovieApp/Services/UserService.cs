class UserService
{
    /*
    Services:
        - Register
        -Log In
    */

    UserRepo ur = new();


    public User RegisterUser(User u)
    {
        //let not let them register if the role is anything other than "user"
        if(u.Role != "user")
        {
            //reject the user from registering
            System.Console.WriteLine("We are unable to register you at this time due to invalid role. Please try again.");
            return null;
        }

        //lets not let them register if the username is already taken
        //need to first get all users
        List<User> allUsers = ur.GetAllUsers();
        //then check if new username matches any of the usernames on all of the users
        foreach(User user in allUsers)
        {
            if(user.UserName == u.UserName)
            {
                System.Console.WriteLine("Username already taken. Please try again.");
                return null; //reject them
            }
        }

        //IF we make it this far, we are saying the role AND username are both good to register with
            //Using same returns as below.

        //If we dont care about any validation - this is but a simple/trivial service method
        return ur.AddUser(u);
    }


    //Loing
    public User LoginUser(string username, string password)
    {
        //Get all users
        List<User> allUsers = ur.GetAllUsers();
        
        //check each one to see if we find a match
        foreach(User user in allUsers)
        {
            if(user.UserName == username && user.Password == password)
            {
                return user; //Login - > by returning the user it indicates successful
            }
        }
        
        //If we make it this far (ran through all users in the IF with no match), we need to rejct outside the foreach
        System.Console.WriteLine("Username or Password does not match. Please try again");
        return null; //reject the login
    }
   
}