using Reward_Assignment.Models;
using System.Collections.Generic;

namespace Reward_Assignment.IRepository
{
    // Reward Assignment Interfacce
    public interface IRewardAssignment
    {
        // Add  Transaction
        public void addTransaction(int price);

        //Get All Transactions
        public List<Transaction> getAllTransactions();

        // Get Total Rewards
        public int getTotalRewards();

        // Calculate the Rewards
        public int calculateRewards(int price);

        // Reward Per Month
        public int[] rewardPerMonth();
    }
}
