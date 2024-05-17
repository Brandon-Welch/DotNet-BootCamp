class UserRepo
{
    //This class is in the Data Access | Repository Layer of our application
    //Solely responsible for any data access and management centered around our user object

    //4 major operations we would like ot manage in this location
        //CRUD Operations - most basic concepts of what you would like ot do with data
            //C - Create //in userStorage.cs Dictionary
            //R - Read/Retreive / in Program.cs app
            //U - Update
            //D - Delete

    UserStorage userStorage = new();


    public User AddUser(User u) //m is referencing the actual user object, so if we return m, we are returning the actual user object
    {
        //We need to first ensure the user being added has a correct ID
        //Assume it doesnt and force it to have a correct ID using our idCounter (comes from the userStorage Utility)

        u.Id = userStorage.idCounter; //m from the Adduser(user m) above
        userStorage.idCounter++; //increment for next ID to be next in line

        //Add the user to our collection
        userStorage.users.Add(u.Id, u); //user.Id, user
        return u;
    }

        //THIS IS A NEW METHOD!
    //No Parameters because...get everything is get everything. No options to choose.
    public List<User> GetAllUsers()
    {
        //I am choosing to return a List because that is a much more common collection to
        //work with. It does mean I have to do a little bit of work here - but its not bad.
        return userStorage.users.Values.ToList();
    }

    public User GetUser(int id) //ID is the KEY in our dictionary
    {
        //We need to retrieve (return) the user - in our case, we are using the unique identifier i.e. ID which is our key
        if (userStorage.users.ContainsKey(id))
        {
            User selectedUser = userStorage.users[id];
            return selectedUser;
        }
        else
        {
            System.Console.WriteLine("Sorry, no user exists with that ID. Please try again.");
            return null; //Ryans option
        }

        //return userStorage.users[id]; //Alternative (shortened) approad to the broken down steps above
    }

    public User UpdateUser(User updatedUser)
    {
        try
        {
            //Assuming that the ID is consistent with an ID that exists, we just have to update the value (aka user) for said ID (key) within the dictionary
            userStorage.users[updatedUser.Id] = updatedUser; //userStorage.users accesses the dictionary then need to specify the property you want
            return updatedUser;   
        }

        catch(Exception e)
        {
            System.Console.WriteLine("Sorry, no user exists with that ID. Please try again.");
            return null;
        }
    }
    public User DeleteUser(User u) //changing parameter so we can display which user was deleted
    {
        //IF we have the ID > simply Remove it from storage
        bool didRemove = userStorage.users.Remove(u.Id);
        
        if (didRemove == true)
        {
            //since we declared the full userw in the parameters (user m), we stored all the user variables so we are able to rturn the user even after removed
            return u;
        }
        
        else
        {
            System.Console.WriteLine("Sorry, no user exists with that ID. Please try again.");
            return null;
        }
        
    }
}