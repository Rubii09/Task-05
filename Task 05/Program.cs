using System;
namespace ATMsystem
{
    class Program
    {
        static void Main()
        {
            
            ATM a = new ATM(32000, 5643);
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter Your PIN:");
                int pin = Convert.ToInt32(Console.ReadLine());
                if (pin == a.pin)
                {
                    Console.WriteLine("PIn is correct");
                    break;
                }
                else
                {
                    Console.WriteLine("Card is blocked");
                }

            }
            char choice;
            do
            {
                Console.WriteLine("---ATM Menu----");
                Console.WriteLine(" A Check Balance:");
                Console.WriteLine(" B Deposit Money:");
                Console.WriteLine(" C Withdrwal Amount:");
                Console.WriteLine(" D Exit program!");

                Console.Write("Enter your choice:");
                choice = Convert.ToChar(Console.ReadLine());
                switch (choice)
                {
                    case 'A':
                        a.checkBalance();
                        break;

                    case 'B':
                        Console.WriteLine("After Deposit");
                        a.Deposit(2000);
                        a.display();

                        break;

                    case 'C':
                        Console.WriteLine("Withdrawl");
                        a.withdrawl(400);
                        a.display();
                        break;

                    case 'D':
                        Console.WriteLine("Exit Program");
                        break;

                    default:
                        Console.WriteLine("Invalid input choice");
                        break;
                }
            }
            while (choice != 'D');
        }

    }
    public class ATM
    {
        public int balance;
        public int pin;
        public ATM(int balance,int pin)
        {
            this.balance = balance;
            this.pin = pin;
        }
        public void CheckBalance()
        { 
            Console.WriteLine($"\nYour Current Balance is: {balance}");
        }
        public void checkBalance()
        {
            Console.WriteLine("Enter Balance:");
            int balance = Convert.ToInt32(Console.ReadLine());

        }
        public void Deposit(int amount)
        {
            if(amount<=0)
            {
                Console.WriteLine("Deposit amount must be positive!");

            }
            else
            {
                balance += amount;
            }
        }
        public void withdrawl(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawl amount must be positive!");
            }
            else
            {
                balance -= amount;
            }
        }
        public void display()
        {
            Console.WriteLine($"Updated Account Balance: {balance}\n");
        }
    }
}