//Services
    //View Balance
    //Deposit
    //Withdrawl
    //Transfer

class AccountService
{
    AccountRepo ar;
    decimal transferAmount = 0;

    public AccountService(AccountRepo ar)
    {
        this.ar = ar;
    }

    public Account TransferDeposit (Account a)
    {
        // Let's first check to see if the account is Avaiable - OR return null if its not available
        if(a.Available == false)
        {
            System.Console.WriteLine("\nAccount is not currently available.");
            return null; // Account cannot be displayed
        }
        
        // System.Console.WriteLine("\nHow much would you like to deposit?");
        // System.Console.Write("Deposit Amount: $");
        // decimal depositAmount = decimal.Parse(System.Console.ReadLine());
        a.Balance += transferAmount; 
        System.Console.Write("\nAccount transfer deposit successful. Your new balance in your " + a.Type + " account is: ");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine(a.Balance.ToString("C")); //added from program.cs WithdrawFromAccount
        Console.ResetColor();
    
        //Update the data storage with the changes
        ar.UpdateAccount(a);
        
        //returning the updated Account
        return a;
    }
    public Account TransferWithdrawl (Account a)
    {
        // Let's first check to see if an account is Avaiable - OR return null if its not available 
        if(a.Available == false)
        {
            System.Console.WriteLine("\nAccount is not currently available.");
            return null; // Account cannot be displayed
        }
        
        System.Console.WriteLine("\nHow much would you like to transfer from your " + a.Type + " account?");
        System.Console.Write("Withdrawl Amount: $");
        transferAmount = decimal.Parse(System.Console.ReadLine());
        if(a.Balance >= transferAmount)
        {
            a.Balance -= transferAmount;
            //String.Format("{0:0.00}", a.Balance);      // "123.46"
            //decimal.Round(a.Balance, 2);
            //a.Balance.ToString("n2");
            //string.Format("{0:C}", a.Balance);
            //string newbalance = a.Balance.ToString("C");

            System.Console.Write("\nAccount transfer withdrawl successful. Your new balance in your " + a.Type + " account is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(a.Balance.ToString("C")); //added from program.cs WithdrawFromAccount
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("\n*Insufficient Funds. Please try again.");
            Console.ResetColor();
            return null;
        }
        //Update the data storage with the changes
        ar.UpdateAccount(a);

        //returning the updated Account from withdrawl
        return a;
    }
    public Account Withdrawl(Account a)
    {
        // Let's first check to see if an account is Avaiable - OR return null if its not available 
        if(a.Available == false)
        {
            System.Console.WriteLine("\nAccount is not currently available.");
            return null; // Account cannot be displayed
        }
        
        System.Console.WriteLine("\nHow much would you like to withdraw?");
        System.Console.Write("Withdrawl Amount: $");
        decimal withdrawlAmount = decimal.Parse(System.Console.ReadLine());

        if(a.Balance >= withdrawlAmount)
        {
            a.Balance -= withdrawlAmount;
            //String.Format("{0:0.00}", a.Balance);      // "123.46"
            //decimal.Round(a.Balance, 2);
            //a.Balance.ToString("n2");
            //string.Format("{0:C}", a.Balance);
            //string newbalance = a.Balance.ToString("C");

            System.Console.Write("\nAccount withdrawl successful. Your new balance is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(a.Balance.ToString("C")); //added from program.cs WithdrawFromAccount
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("\n*Insufficient Funds. Please try again.");
            Console.ResetColor();
        }
        //Update the data storage with the changes
        ar.UpdateAccount(a);

        //returning the updated Account
        return a;
    }    
    public Account Deposit(Account a) // a is the account we want to attempt to check out
    {
        // Let's first check to see if the account is Avaiable - OR return null if its not available
        if(a.Available == false)
        {
            System.Console.WriteLine("\nAccount is not currently available.");
            return null; // Account cannot be displayed
        }
        
        System.Console.WriteLine("\nHow much would you like to deposit?");
        System.Console.Write("Deposit Amount: $");
        decimal depositAmount = decimal.Parse(System.Console.ReadLine());
        a.Balance += depositAmount; 

        System.Console.Write("\nAccount deposit successful. Your new balance is: ");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine(a.Balance.ToString("C")); //added from program.cs WithdrawFromAccount
        Console.ResetColor();
    
        //Update the data storage with the changes
        ar.UpdateAccount(a);
        
        //returning the updated Account
        return a;

    }
    public List<Account> GetAvailableAccounts(User loggedInUser)
    {
        //Get All Accounts
        List<Account> allAccounts = ar.GetAllAccounts(loggedInUser.Id);
        
        //Then Filter Out Unavailable Accounts (or whatever accounts you dont want)
        List<Account> availableAccounts = new(); //create new list that will be come filtered list
        
        //To filter: Run a loop over all accopunts to determine if they are available to be added to the filtered list
        foreach(Account a in allAccounts)
        {
            if(a.Available == true)
            {
                availableAccounts.Add(a);
            }
        }

        //Return Filtered List
        return availableAccounts;
    } 
    public Account GetAccount(int id) //TODO: still needed?
    {
        return ar.GetAccount(id);
    }
        public Account GetAccounts(int id)
    {
        return ar.GetAccounts(id);
    }
}
