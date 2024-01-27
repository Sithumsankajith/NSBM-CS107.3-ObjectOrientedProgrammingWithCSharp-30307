using System;

class Q7

{
    static double balance = 1000; // Initial balance

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("ATM Simulator");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        Console.WriteLine("Exiting ATM. Thank you!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine();
        }
    }

    // Function to check balance
    static void CheckBalance()
    {
        Console.WriteLine($"Your current balance is: ${balance}");
    }

    // Function to deposit money
    static void DepositMoney()
    {
        Console.Write("Enter the amount to deposit: $");
        if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposit successful. Your new balance is: ${balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a valid positive number.");
        }
    }

    // Function to withdraw money
    static void WithdrawMoney()
    {
        Console.Write("Enter the amount to withdraw: $");
        if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful. Your new balance is: ${balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Cannot withdraw the specified amount.");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a valid positive number.");
        }
    }
}
