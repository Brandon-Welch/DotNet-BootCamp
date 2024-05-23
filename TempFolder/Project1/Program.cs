using System.Collections;
using System.Security;

class Program
{
    static AccountService accs; //moved this out of main method so it can be used in any of the methods and we dont have to pass this every single subsequent method
        //static methods can only use other static members... since main method is static, we need to make the other methods static (fields, methods, etc)
    
    static UserService us;
    static User? currentUser = null;
    //TODO: may need to remove static UserServices userserivces = new();

    User loggedInUser = null;

    static void Main(string[] args)
    {
        //Create connection to DB
        string path = @"C:\Users\A140953\OneDrive - Government Employees Insurance Company\Documents\RevatureTraining\DotNetBootCamp\Connection Strings\DotNetBankingDBcs.txt";
        string connectionString = File.ReadAllText(path);

        UserRepo ur = new(connectionString);
        us = new(ur);

        AccountRepo ar = new(connectionString); //TODO <-- we'll need to add the connection string in the near future
        accs = new(ar);
        
        //Clear the console screen for a cleaner visual feel
        Console.Clear();

        //Add a pause after clearing before program starts to display
        Thread.Sleep(750);

        //Welcome Message, will only show upon initial program launch
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.WriteLine(@"                  _ _.-'`-._ _");
        System.Console.WriteLine(@"                 ;.'_DotNet_'.;");
        System.Console.WriteLine(@"      _________n.[__Bootcamp__].n_________");
        System.Console.WriteLine(@"     |""__""___""__""||==||==||==||""__""___""__""|");
        System.Console.WriteLine(@"     |'''''''''''||..||..||..||'''''''''''|");
        System.Console.WriteLine(@"     |LI LI LI LI||LI||LI||LI||LI LI LI LI|");
        System.Console.WriteLine(@"     |.. .. .. ..||..||..||..||.. .. .. ..|");
        System.Console.WriteLine(@"     |LI LI LI LI||LI||LI||LI||LI LI LI LI|");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine(@" ,,;;,;;;,;;;,;;;,;;;,;;;,;;;,;;,;;;,;;;,;;;;,,");
        System.Console.WriteLine(@";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");
        Console.ResetColor();
        System.Console.WriteLine("\n  Welcome to the Dotnet Bootcamp Banking App!\n\n");

        AccessMenu();
        //Login();
        //Display the Main Menu
        //MainMenu();
    }

    private static void MainMenu(User loggedInUser)
    {
        bool keepGoing = true;

        while (keepGoing)
        {
            //Add a pause before displaying Main Menu
            Thread.Sleep(1500);

            //Main Menu
            System.Console.WriteLine("\nWhat would you like to do?");
            System.Console.WriteLine("=================================");
            System.Console.WriteLine("[1] View My Account(s)");
            System.Console.WriteLine("[2] Deposit into an Account");
            System.Console.WriteLine("[3] Withdraw from Account");
            System.Console.WriteLine("[4] Transfer between Accounts");
            //System.Console.WriteLine("[4] View Checked out Accounts"); //if using later, update validation to 4
            System.Console.WriteLine("[0] Logout");
            System.Console.WriteLine("=================================");

            //Allow user to enter a selection
            System.Console.Write("Enter your selection: ");
            int input = int.Parse(Console.ReadLine() ?? "0");
            
            //Validate user selection
            input = ValidateCmd(input, 4);
            System.Console.WriteLine();

            //Extracted to method - uses switch case to determine what to do next.
            keepGoing = DecideNextOption(input, loggedInUser);
        }
    }
    private static void AccessMenu()
    {
        bool keepGoing = true;
        while (keepGoing)
        {
            System.Console.WriteLine("What would you like to do?");
            System.Console.WriteLine("=================================");
            System.Console.WriteLine("[1] Login");
            System.Console.WriteLine("[2] Register");
            System.Console.WriteLine("[0] Exit");
            System.Console.WriteLine("=================================");

            System.Console.Write("Enter your selection: ");
            int input = int.Parse(Console.ReadLine() ?? "0");
            //Same Validation method copied over
            input = ValidateCmd(input, 2);

            keepGoing = DecideAccessOption(input);
        }
    }
    private static bool DecideAccessOption(int input)
    {
        switch (input)
        {
            case 1:
                Login(); break;
            case 2:
                Register(); break;
            case 0:
            default:
                //If option 0 or anything else -> set keepGoing to false.
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine(@"                  _ _.-'`-._ _");
                System.Console.WriteLine(@"                 ;.'_DotNet_'.;");
                System.Console.WriteLine(@"      _________n.[__Bootcamp__].n_________");
                System.Console.WriteLine(@"     |""__""___""__""||==||==||==||""__""___""__""|");
                System.Console.WriteLine(@"     |'''''''''''||..||..||..||'''''''''''|");
                System.Console.WriteLine(@"     |LI LI LI LI||LI||LI||LI||LI LI LI LI|");
                System.Console.WriteLine(@"     |.. .. .. ..||..||..||..||.. .. .. ..|");
                System.Console.WriteLine(@"     |LI LI LI LI||LI||LI||LI||LI LI LI LI|");
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine(@" ,,;;,;;;,;;;,;;;,;;;,;;;,;;;,;;,;;;,;;;,;;;;,,");
                System.Console.WriteLine(@";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");
                Console.ResetColor();
                System.Console.WriteLine("\nThanks for trusting Dotnet Bootcamp Banking for all your banking needs! Have a great day!\n");
                return false;
        }

        return true;
    }
    private static void Login()
    {
        /* // Spinner
        using (var spinner = new Spinner(10, 10))
            {
                spinner.Start();
                // Do your work here instead of sleeping...
                Thread.Sleep(2000);
            }
        */
        //Prompt User for login info
        System.Console.WriteLine("\nPlease enter your username:");
        System.Console.Write("Username: ");
        string username = System.Console.ReadLine() ?? "0";
        System.Console.WriteLine("Please enter your password:");
        System.Console.Write("Password: ");
        string password = System.Console.ReadLine() ?? "0";
        DeletePrevConsoleLine();
        
        /*
        //Hide user input behind '*'
        SecureString pass = new SecureString();
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    pass.AppendChar(key.KeyChar);
                    Console.Write("*");
                }
                else
                {
                    pass.RemoveAt(pass.Length - 1);
                    Console.Write("\b \b");
                }
            }
            while (key.Key != ConsoleKey.Enter);
        string password = new System.Net.NetworkCredential("", pass).Password;
        */
        
        //Set User login info
        User loggedInUser = us.LoginUser(username, password);
        if (loggedInUser != null)
        {
            //If user is valid, access main menu
            System.Console.WriteLine("You have successfully logged in!");
            //Console.Clear(); //FIXME
            MainMenu(loggedInUser);
        }
        else
        {
            //If user login is not valid, prompt to reattempt login
            System.Console.WriteLine("Login failed. Please try again.\n");
            Login();
        }

    }
    private static void Register()
    {
        //Prompt user to create a login
        System.Console.WriteLine("\nPlease Enter a New Username: ");
        System.Console.Write("Username: ");
        string username = Console.ReadLine() ?? "";
        //TODO: Could Add some validation here to loop if Username is empty or taken.

        System.Console.WriteLine("Please Enter a New Password: ");
        System.Console.Write("Password: ");
        string password = Console.ReadLine() ?? "";
        //TODO: Could Add some validation here to loop if Password is empty or not long enough.

        //Set new user info to an object
        User? newUser = new(0, username, password, "user");
        
        //Return the new User.
        newUser = us.RegisterUser(newUser);
        if (newUser != null)
        {
            System.Console.WriteLine("New User Registered!");
            Thread.Sleep(300);
        }
        else
        {
            System.Console.WriteLine("Registration Failed! Please Try Again!");
        }
    }
    private static bool DecideNextOption(int input, User loggedInUser)
    {
        switch (input)
        {
            case 1:
                {
                    RetrievingAvailableAccounts(loggedInUser);
                    break;
                }
            case 2:
                {
                    DepositIntoAccount();
                    break;
                }
            case 3:
                {
                    WithdrawFromAccount();
                    break;
                }
            case 4:
                {
                    TransferBetweenAccounts();
                    break;
                }
            case 0:
            default:
                {
                    //If option 0 OR default (anything else) -> set keepGoing to false and end program.
                    return false;
                }
        }

        return true;
    }
    private static void RetrievingAvailableAccounts(User loggedInUser)
    {
        //Create list from Available Accounts
        List<Account> accounts = accs.GetAvailableAccounts(loggedInUser);

        //Display Available Accounts
        System.Console.WriteLine("========= Your Accounts =========");
        foreach (Account a in accounts)
        {
            System.Console.WriteLine(a);
        }
        System.Console.WriteLine("=================================");
        
        //Insert Pause for reading accounts longer.
        Thread.Sleep(1500);
    }
    private static void TransferBetweenAccounts()
    {
        //Start by withdrawing from one account
        System.Console.WriteLine("What account would you like to transfer from?");
        while (true)
        {
            //Pick an account
            Account account = PromptUserForAccount();

            //Adding a way out...
            if (account == null) return; //Leaves method.
            
            //Withdraw from Account
            account = accs.TransferWithdrawl(account);

            if(account == null)
                {
                    System.Console.WriteLine("\nPlease Try Another Account.");
                }
                else
                {
                        //transfer to new account
                    while (true)
                    {
                        System.Console.WriteLine("\nWhat account would you like to transfer to?");
                        //Pick an account
                        account = PromptUserForAccount();
                        
                        //Adding a way out...
                        if (account == null) return; //Leaves method.
                        
                        //Deposit into account
                        account = accs.TransferDeposit(account);
  
                        if(account == null)
                        {
                            System.Console.WriteLine("\nPlease Try Another Account.");
                        }
                        {
                            break;
                        }
                    }
                    break;
                }


        }
    }
    private static void DepositIntoAccount()
    {
        while (true)
        {
            //Pick an account
            Account account = PromptUserForAccount();
            
            //Adding a way out...
            if (account == null) return; //Leaves method.
            
            //Deposit into account
            account = accs.Deposit(account);

            if(account == null)
            {
                System.Console.WriteLine("Please Try Another Account.");
            }
            else
            {
                break;
            }
        }

    }
    private static void WithdrawFromAccount()
    {
        while (true)
        {
            //Pick an account
            Account account = PromptUserForAccount();

            //Adding a way out...
            if (account == null) return; //Leaves method.
            
            //Withdraw from Account
            account = accs.Withdrawl(account);

            if(account == null)
            {
                System.Console.WriteLine("Please Try Another Account.");
            }
            else
            {
                break;
            }
        }
    }

    //Unused Method at this time
    private static void RetrievingCheckedOutAccounts()
    {
        System.Console.WriteLine("\nSorry the code for this method is in another castle.");
    }

    //Helper Methods
    private static Account PromptUserForAccount()
    {
        //Input Validation for Selecting Account
        Account retrievedAccount = null;
        while (retrievedAccount == null)
        {
            System.Console.WriteLine("Please enter an Account ID (0 to Exit Process): ");
            System.Console.Write("Account ID: ");
            int input = int.Parse(Console.ReadLine() ?? "0"); //BUG: need to add exception handling...if user input char/etc... try catch/loop for an input

            //Adds ability to exit the process
            if (input == 0) return null; //BUG: need to add some form of exception handling... if user enters a monetary value accidently instead of selecting account

            retrievedAccount = accs.GetAccounts(input); //FIXME: looks like this is the start of where Transfer breaks when trying to access savings vs checking
        }
        //Leaving the loop indicates that they have successfully picked a valid account.
        return retrievedAccount;
    }

    //Generic Command Input Validator - assume 1-maxOption are the number of options. and 0 is an option to quit.
    private static int ValidateCmd(int cmd, int maxOption)
    {
        while (cmd < 0 || cmd > maxOption)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("\n*Invalid Selection - Please Enter a selection 1-" + maxOption + "; or 0 to Quit");
            Console.ResetColor();
            System.Console.Write("Enter your selection: ");
            cmd = int.Parse(Console.ReadLine() ?? "0");
        }

        //if input was already valid - it skips the if statement and just returns the value.
        return cmd;
    }
    
    private static void DeletePrevConsoleLine()
{
    if (Console.CursorTop == 0) return;
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, Console.CursorTop - 1);
}

    /* //Spinner
    public class Spinner : IDisposable
    {
        private const string Sequence = @"/-\|";
        private int counter = 0;
        private readonly int left;
        private readonly int bottom;
        private readonly int delay;
        private bool active;
        private readonly Thread thread;

        public Spinner(int left, int bottom, int delay = 100)
        {
            this.left = left;
            this.bottom = bottom;
            this.delay = delay;
            thread = new Thread(Spin);
        }

        public void Start()
        {
            active = true;
            if (!thread.IsAlive)
                thread.Start();
        }

        public void Stop()
        {
            active = false;
            Draw(' ');
        }

        private void Spin()
        {
            while (active)
            {
                Turn();
                Thread.Sleep(delay);
            }
        }

        private void Draw(char c)
        {
            Console.SetCursorPosition(left, left);
//            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Working ");
            Console.Write(c);
        }
        private void Turn()
        {
            Draw(Sequence[++counter % Sequence.Length]);
        }

        public void Dispose()
        {
            Stop();
        }
    }
    */

}