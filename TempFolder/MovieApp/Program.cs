class Program
{
    static AccountService accs = new(); //moved this out of main method so it can be used in any of the methods and we dont have to pass this every single subsequent method
    //static methods can only use other static members... since main method is static, we need to make the other methods static (fields, methods, etc)

    static void Main(string[] args)
    {
        //Display the Main Menu
        MainMenu();
    }

    private static void MainMenu()
    {
        //Clear the console screen for a cleaner visual feel
        Console.Clear();

        //Add a pause after clearing before program starts to display
        Thread.Sleep(750);

        //MWelcome Message, will only show upon initial program launch
        System.Console.WriteLine(@"                  _ _.-'`-._ _");
        System.Console.WriteLine(@"                 ;.'_DotNet_'.;");
        System.Console.WriteLine(@"      _________n.[__Bootcamp__].n_________");
        System.Console.WriteLine(@"     |""__""___""__""||==||==||==||""__""___""__""|");
        System.Console.WriteLine(@"     |'''''''''''||..||..||..||'''''''''''|");
        System.Console.WriteLine(@"     |LI LI LI LI||LI||LI||LI||LI LI LI LI|");
        System.Console.WriteLine(@"     |.. .. .. ..||..||..||..||.. .. .. ..|");
        System.Console.WriteLine(@"     |LI LI LI LI||LI||LI||LI||LI LI LI LI|");
        System.Console.WriteLine(@" ,,;;,;;;,;;;,;;;,;;;,;;;,;;;,;;,;;;,;;;,;;;;,,");
        System.Console.WriteLine(@";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");
        System.Console.WriteLine("  Welcome to the Dotnet Bootcamp Banking App!");
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
            System.Console.WriteLine("[0] Quit");
            System.Console.WriteLine("=================================");

            //Allow user to enter a selection
            System.Console.Write("Enter your selection: ");
            int input = int.Parse(Console.ReadLine() ?? "0");
            
            //Validate user selection
            input = ValidateCmd(input, 4);
            System.Console.WriteLine();

            //Extracted to method - uses switch case to determine what to do next.
            keepGoing = DecideNextOption(input);
        }
    }

    private static bool DecideNextOption(int input)
    {
        switch (input)
        {
            case 1:
                {
                    RetrievingAvailableAccounts();
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
            // case 4:
            //     {
            //         RetrievingCheckedOutAccounts();
            //         break;
            //     }
            case 0:
            default:
                {
                    //If option 0 OR default (anything else) -> set keepGoing to false and end program.
                    System.Console.WriteLine("Thanks for trusting Dotnet Boocamp with all your banking needs! Have a great day!\n");
                    return false;
                }
        }

        return true;
    }

    private static void RetrievingAvailableAccounts()
    {
        //Create list from Available Accounts
        List<Account> accounts = accs.GetAvailableAccounts();

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
            // if (account != null)
            // {
            //     System.Console.WriteLine("\nAccount withdrawl successful. Your new balance is: $" + account.Balance); break; // <-- :O
            // }
            // else
            // {
            //     System.Console.WriteLine("Please Try Another Account.");
            // }
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
                        // if (account != null)
                        // {
                        //     System.Console.WriteLine("\nAccount deposit successful. Your new balance is: $" + account.Balance); break; // <-- :O
                        // }
                        // else
                        // {
                        //     System.Console.WriteLine("Please Try Another Account.");
                        // }
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
            // if (account != null)
            // {
            //     System.Console.WriteLine("\nAccount deposit successful. Your new balance is: $" + account.Balance); break; // <-- :O
            // }
            // else
            // {
            //     System.Console.WriteLine("Please Try Another Account.");
            // }
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
            // if (account != null)
            // {
            //     System.Console.WriteLine("\nAccount withdrawl successful. Your new balance is: $" + account.Balance); break; // <-- :O
            // }
            // else
            // {
            //     System.Console.WriteLine("Please Try Another Account.");
            // }
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
            int input = int.Parse(Console.ReadLine() ?? "0");
            //Okay I want to add a "way out" for anytime they want to exist the process.
            if (input == 0) return null;

            retrievedAccount = accs.GetAccount(input);    // <-- add a trivial service method here.
        }
        //Leaving the loop indicates that they have successfully picked a valid account.
        return retrievedAccount;
    }

    //Generic Command Input Validator - assume 1-maxOption are the number of options. and 0 is an option to quit.
    private static int ValidateCmd(int cmd, int maxOption)
    {
        while (cmd < 0 || cmd > maxOption)
        {
            System.Console.WriteLine("\n*Invalid Selection - Please Enter a selection 1-" + maxOption + "; or 0 to Quit");
            System.Console.Write("Enter your selection: ");
            cmd = int.Parse(Console.ReadLine() ?? "0");
        }

        //if input was already valid - it skips the if statement and just returns the value.
        return cmd;
    }
}
