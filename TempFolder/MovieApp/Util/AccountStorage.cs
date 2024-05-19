class AccountStorage
{
    public Dictionary<int, Account> accounts;
    public int idCounter = 1; //normally start at 1 and then future is idCounter++
 

    //Making this constructor give us some pre-loaded Accounts to work with.
    public AccountStorage()
    {
        Account account1 = new Account(idCounter, 1075.25m, "Checking", 10, true); idCounter++;
        Account account2 = new Account(idCounter, 500.75m, "Savings", 10, true); idCounter++;
        
        accounts = new(); //sets the dictionary to an empty collection
        accounts.Add(account1.Id, account1);
        accounts.Add(account2.Id, account2);   
    }
}