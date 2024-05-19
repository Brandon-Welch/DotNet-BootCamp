class AccountRepo
{
    //This class is in the Data Access | Repository Layer of our application
    //Solely responsible for any data access and management centered around our account object

    //4 major operations we would like ot manage in this location
        //CRUD Operations - most basic concepts of what you would like ot do with data
            //C - Create //in accountStorage.cs Dictionary
            //R - Read/Retreive / in Program.cs app
            //U - Update
            //D - Delete

    AccountStorage accountStorage = new();


    public Account AddAccount(Account a) //a is referencing the actual Account object, so if we return a, we are returning the actual Account object
    {
        //We need to first ensure the account being added has a correct ID
        //Assume it doesnt and force it to have a correct ID using our idCounter (comes from the AccountStorage Utility)

        a.Id = accountStorage.idCounter; //m from the AddAccount(Account a) above
        accountStorage.idCounter++; //increment for next ID to be next in line

        //Add the account to our collection
        accountStorage.accounts.Add(a.Id, a); //Account.Id, Account
        return a;
    }

    
    public List<Account> GetAllAccounts()
    {
        //Returns all Accounts as a List
        return accountStorage.accounts.Values.ToList();
    }

    public Account GetAccount(int id) //ID is the KEY in our dictionary
    {
        //We need to retrieve (return) the account - in our case, we are using the unique identifier i.e. ID which is our key
        if (accountStorage.accounts.ContainsKey(id))
        {
            Account selectedAccount = accountStorage.accounts[id];
            return selectedAccount;
        }
        else
        {
            System.Console.WriteLine("\nSorry, no account exists with that ID. Please try again.\n");
            return null; 
        }
    }

    public Account UpdateAccount(Account updatedAccount)
    {
        try
        {
            //Assuming that the ID is consistent with an ID that exists, we just have to update the value (aka Account) for said ID (key) within the dictionary
            accountStorage.accounts[updatedAccount.Id] = updatedAccount; //accountStorage.accounts accesses the dictionary then need to specify the property you want
            return updatedAccount;   
        }

        catch(Exception e)
        {
            System.Console.WriteLine("\nSorry, no account exists with that ID. Please try again.\n");
            return null;
        }
    }
    public Account DeleteAccount(Account a) //changing parameter so we can display which account was deleted
    {
        //IF we have the ID > simply Remove it from storage
        bool didRemove = accountStorage.accounts.Remove(a.Id);
        
        if (didRemove == true)
        {
            //since we declared the full account in the parameters (Account a), we stored all the account variables so we are able to rturn the account even after removed
            return a;
        }
        
        else
        {
            System.Console.WriteLine("\nSorry, no account exists with that ID. Please try again.\n");
            return null;
        }
        
    }
}