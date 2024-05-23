using System;
using System.Linq;

class Program
{//---Start of Class Program---

    static IUserRepo ur;
    static void Main(string[] args)
    {//---Start of Main Method---

       //Test out LINQ and Lambda Expressions
       //LambdaTest();

       using AppDBContext context = new();
       ur = new UserRepo(context);

    //    //Create a user Object
    //    User newUser = new(0,"brandon", "pass1", "user");
    //    ur.AddUser(newUser);
    //    ur.Save();
    //    System.Console.WriteLine("User added successfully");

    //    //Get User By ID
    //    User u = ur.GetUser(1);
    //    if(u != null)
    //    {
    //     System.Console.WriteLine(u);
    //    }
    //    else
    //    {
    //     System.Console.WriteLine("User not found!");
    //    }

    //    //Update User
    //    User u = ur.GetUser(1);
    //    u.Password = "pass123";
    //    ur.UpdateUser(u);
    //    ur.Save();
    //    //Easy to see if changes happened
    //    System.Console.WriteLine(ur.GetUser(1));

       //Delete User
       ur.DeleteUser(1);
       ur.Save();
       //Check that user1 isnt in all users
       List<User> allUsers = ur.GetAllUsers();
       List<User> allUserWithId0 = allUsers.Where(user => user.Id == 1).ToList();
       System.Console.WriteLine(allUserWithId0.Count == 0);
       

    }//---End of Main Method---

    public static void LambdaTest()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8];
        List<string> words = ["Hello", "Hey", "Hi", "Goodbye"];
        
        List<int> evenNumbers = numbers.Where(num => num % 2 == 0).ToList();
        var hWords = words.Where(word => word.Substring(0, 1) == "H");
        
        foreach (int num in evenNumbers)
        {
            System.Console.WriteLine(num);
        }

        foreach (string word in words)
        {
            System.Console.WriteLine(word);
        }

        evenNumbers.ForEach(num => System.Console.WriteLine(num));

        evenNumbers = evenNumbers.OrderBy(x => x).ToList();
        System.Console.WriteLine("===========");
        evenNumbers.ForEach(num => System.Console.WriteLine(num));
    }
}//---End of Class Program---