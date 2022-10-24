using Reward_Assignment.Repository;
using System;

namespace Reward_Assignment
{

    public class Program
    {

        static void Main(string[] args)
        {

            RewardAssignment model = new RewardAssignment();
            Console.WriteLine();
            Console.WriteLine("**************************************");
            Console.WriteLine("Reward Assignments");
            Console.WriteLine("**************************************");
            Console.WriteLine();
            Console.WriteLine("Please enter how many transactions need to be processed");
            int Transactions = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The setup is going to process the " + Transactions + " transactions. Please add the transactions one after other.");
            Console.WriteLine("----------------------------------------------------------------------------");
            for (int i = 1; i <= Transactions; i++)
            {
                Console.WriteLine("Add " + i + " Transaction Amount");
                model.addTransaction(int.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------------------------");
            var list = model.getAllTransactions();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Price    Reward     Date");
            Console.WriteLine("**************************************************");
            foreach (var item in list)
            {
                Console.WriteLine(item.price + "    " + item.Rewards + "     " + item.Date);
            }
            Console.ReadLine();

        }
    }
}
