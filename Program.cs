using System;

class Program
{
    public static void DisplayMenu()
    {
        Console.WriteLine("\n1. Deposit\n2. Withdraw\n3. View Balance\n4. View Transactions\n5. Logout");
    }

    public static int GetUserChoice()
    {
        Console.Write("\nPlease choose an option: ");
        return int.Parse(Console.ReadLine());
    }

    public static decimal GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return decimal.Parse(Console.ReadLine());
    }

    static void Main()
    {
        Wallet wallet = new Wallet();

        while (true)
        {
            DisplayMenu();
            int choice = GetUserChoice();

            switch (choice)
            {
                case 1:
                    decimal depositAmount = GetUserInput("\nEnter deposit amount: ");
                    wallet.Deposit(depositAmount);
                    break;
                case 2:
                    decimal withdrawalAmount = GetUserInput("\nEnter withdrawal amount: ");
                    wallet.Withdraw(withdrawalAmount);
                    break;
                case 3:
                    Console.WriteLine("\nBalance: " + wallet.GetBalance());
                    break;
                case 4:
                    Console.WriteLine("\nTransactions: " + string.Join(", ", wallet.GetTransactions()));
                    break;
                case 5:
                    Console.WriteLine("\nLogged out successfully.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nInvalid choice!");
                    break;
            }
        }

        Program.Main();
    }
}