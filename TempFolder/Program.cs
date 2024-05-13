using System;
using System.Collections.Generic;

class Program
{//---Start of Class Program---

    static Dictionary<string, double> accountBalances = new Dictionary<string, double>();
    static void Main(string[] args)
    {//---Start of Main Method---

       //Creating accounts for two users
        accountBalances.Add("user1", 0);
        accountBalances.Add("user2", 0);

        bool exit = false;
        do
        {
            System.Console.WriteLine("Welcome to .Net Bootcamp Banking!");
            System.Console.WriteLine("1. Login");
            System.Console.WriteLine("2. Exit");
            System.Console.Write("Please choose an option: ");
            int choice = int.Parse(System.Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    Login();
                    break;
                }

                case 2:
                {
                    exit = true;
                    System.Console.WriteLine("Have a great day!");
                    break;
                }

                default:
                {
                    System.Console.WriteLine("Invalid option selected. Please try again.");;
                    break;
                }
            }

        }

        while (!exit);

    }//---End of Main Method---

//Methods
    static void Login()
    {
        System.Console.Write("Enter username: ");
        string username = System.Console.ReadLine();
        System.Console.Write("Enter password: ");
        string password = System.Console.ReadLine();

        //Authentication
        string user1 = "John";
        string password1 = "test";
        string user2 = "Jane";
        string password2 = "test";
        
        if (username == user1 && password == password1)
        {
            UserMenu(username);
        }

        else if (username == user2 && password == password2)
        {
            UserMenu(username);
        }

        else
        {
            System.Console.WriteLine("Invalid username or password.");
        }
    }

    static void UserMenu(string username)
    {
        bool logout = false;

        do
        {
            System.Console.WriteLine("Welcome, " + username + "!");
            System.Console.WriteLine("1. Deposit");
            System.Console.WriteLine("2. Withdrawl");
            System.Console.WriteLine("3. Check Balance");
            System.Console.WriteLine("4. Logout");
            int choice = int.Parse(System.Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    Deposit(username);
                    break;
                }

                case 2:
                {
                    Withdrawl(username);
                    break;
                }
                
                case 3:
                {
                    CheckBalance(username);
                    break;
                }

                case 4:
                {
                    logout = true;
                    break;
                }

                default:
                {
                    System.Console.WriteLine("Invalid option selected. Please try again.");
                    break;
                }
            }
        }

        while (!logout);
    }

    static void Deposit(string username)
    {
        System.Console.Write("Enter amount to deposit: ");
        if (double.TryParse(Console.ReadLine(), out double amount))
        {
            accountBalances[username] += amount;
            System.Console.WriteLine("You have successfully deposited $" + amount + "!");
            System.Console.WriteLine("Your new balance: $" + accountBalances[username]);
        }

        else
        {
            System.Console.WriteLine("You attempted to deposit an invalid amount. Unable to process request.");
        }
    }

    static void Withdrawl(string username)
    {
        System.Console.Write("Enter amount to withdraw: ");
        if (double.TryParse(Console.ReadLine(), out double amount))
        {
            if (amount <= accountBalances[username])
            {
                accountBalances[username] -= amount;
                System.Console.WriteLine("You have successfully withdrawn $" + amount + "!");
                System.Console.WriteLine("Your new balance: $" + accountBalances[username]);
            }

            else
            {
                System.Console.WriteLine("Insufficient funds. Unable to process request.");
            }        
        }

        else
        {
            System.Console.WriteLine("You attempted to desposit an invalid amount. Unable to process request.");
        }
    }

    static void CheckBalance(string username)
    {
        System.Console.WriteLine("Your current balance is: $" + accountBalances[username]);
    }
}//---End of Class Program---