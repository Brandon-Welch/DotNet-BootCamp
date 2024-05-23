class UserService
{
    /*
    Services:
        - Register
        -Log In
    */

    UserRepo ur;

    public UserService(UserRepo ur)
    {
        this.ur = ur;
    }


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


    //Log IN
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
        //System.Console.WriteLine("Username or Password does not match. Please try again");
        return null; //reject the login
    }

/*
    public User? LoginUser(string username, string password)

{
    //This is where we would do some validation.
    //For example, we could check if the email is already in use.
    //We could also check if the password is strong enough
    //We could also check if the username is already in use.
    //We could also check if the email and password match.

    //What I will actually be doing is:
    //get all users
    //check if the username exists
    //if so they login -> return the user

    List<User> allUsers = ur.GetAllUsers();

    foreach (User user in allUsers)
    {
        if (user.Username == username && user.Password == password) //BOTH username and password must match to login. the && is the AND operator and checks to make sure both sides are true.
        {
            return user;
        }

    }

    System.Console.WriteLine("Invalid Username or Password");
    return null; //if the foreach loop completes and no user is found, then the user does not exist in the system.
}
*/
   
}