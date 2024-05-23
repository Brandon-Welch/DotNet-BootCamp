using System.Net.NetworkInformation;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
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
    static UserRepo ur;
    private readonly string _connectionString;

    //Dependency Injection -> Constructor Injection
    public AccountRepo(string connString)
    {
        _connectionString = connString;
    }



    public Account AddAccount(Account a) //a is referencing the actual Account object, so if we return a, we are returning the actual Account object
    {
        //We need to first ensure the account being added has a correct ID
        //Assume it doesnt and force it to have a correct ID using our idCounter (comes from the AccountStorage Utility)

        //Set Up DB Connection
        using SqlConnection connection = new(_connectionString);

        //Create the SQL String
        string sql = "INSERT INTO dbo.Account OUTPUT inserted.* VALUES (@Balance, @Type, @Available, @UserId)";

        //Set Up SQL Command Object and use its methods to modify
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@Balance", a.Balance);
        cmd.Parameters.AddWithValue("@Type", a.Type);
        cmd.Parameters.AddWithValue("@Available", a.Available);
        cmd.Parameters.AddWithValue("@UserId", a.UserId);

        //Execute the Query
        using SqlDataReader reader = cmd.ExecuteReader();

        //Extract the Results
                if (reader.Read())
        {
            //If Read() found data -> then extract it.
            Account newAccount = BuildAccount(reader); //Helper Method for doing that repetitive task
            return newAccount;
        }
        else
        {
            //Else Read() found nothing -> Insert Failed. :(
            return null;
        }
        
/*        a.Id = accountStorage.idCounter; //m from the AddAccount(Account a) above
        accountStorage.idCounter++; //increment for next ID to be next in line

        //Add the account to our collection
        accountStorage.accounts.Add(a.Id, a); //Account.Id, Account
        return a;
*/
    }

    
    public List<Account> GetAllAccounts(int userId)
    {
        //Returns all Accounts as a List
        //return accountStorage.accounts.Values.ToList();
        List<Account> accounts = [];
        try
        {
            //Set up DB Connection
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            //Create the SQL String
            string sql = "SELECT * FROM dbo.Account WHERE userId = @UserId";

            //Set up SqlCommand Object
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@UserId", userId);

            //Execute the Query
            using var reader = cmd.ExecuteReader();

            //Extract the Results
            while (reader.Read())
            {
                //for each iteration -> extract the results to a User object -> add to list.
                Account newAccount = BuildAccount(reader);

                //don't return! Instead Add to List!
                accounts.Add(newAccount);
            }

            return accounts;

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    }

    public Account GetAccounts(int id)
    {
        try
        {
            //Set up DB Connection
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            //Create the SQL String
            string sql = "SELECT * FROM dbo.Account WHERE userId = @UserId";

            //Set up SqlCommand Object
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@userId", id);

            //Execute the Query
            using var reader = cmd.ExecuteReader();

            //Extract the Results
            if (reader.Read())
            {
                //for each iteration -> extract the results to a Account object -> add to list.
                Account newAccount = BuildAccount(reader);
                return newAccount;
            }

            return null; //Didnt find anyone :(

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    }
    public Account GetAccount(int id) //TODO: still needed? //ID is the KEY in our dictionary
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
            //Set up DB Connection
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            //Create the SQL String
            string sql = "UPDATE dbo.Account SET Balance = @Balance, Type = @Type, Available = @Available, UserId = @UserId OUTPUT inserted.* WHERE Id = @Id";

            //Set up SqlCommand Object
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Id", updatedAccount.Id);
            cmd.Parameters.AddWithValue("@Balance", updatedAccount.Balance);
            cmd.Parameters.AddWithValue("@Type", updatedAccount.Type);
            cmd.Parameters.AddWithValue("@Available", updatedAccount.Available);
            cmd.Parameters.AddWithValue("@UserId", updatedAccount.UserId);

            //Execute the Query
            using var reader = cmd.ExecuteReader();

            //Extract the Results
            if (reader.Read())
            {
                //for each iteration -> extract the results to a User object -> add to list.
                Account newAccount = BuildAccount(reader);
                return newAccount;
            }

            return null; //Didnt find anyone :(

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
        
        
        
/*        try
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
*/
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
    
    
    //Helper Method
    private static Account BuildAccount(SqlDataReader reader)
    {
        Account newAccount = new();
        newAccount.Id = (int)reader["Id"];
        newAccount.Balance = (decimal)reader["Balance"];
        newAccount.Type = (string)reader["Type"];
        newAccount.Available = (bool)reader["Available"];
        newAccount.UserId = (int)reader["UserId"];
        /* different version of above?
        int userId = (int)reader["UserId"];
        newAccount.UserId = ur.GetUser(userId);
        */
        return newAccount;
    }
}