using Reward_Assignment.IRepository;
using Reward_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reward_Assignment.Repository
{
    // Implementing the IReward Assignment.
    public class RewardAssignment : IRewardAssignment
    {


        #region LIST TRANSACTIONS

        List<Transaction> myTransactions = new List<Transaction>();
        public void addTransaction(int price)
        {
            Transaction transaction = new Transaction();
            transaction.price = price;
            transaction.Rewards = calculateRewards(price);
            transaction.Date = DateTime.Today;
            myTransactions.Add(transaction);
        }
        public List<Transaction> getAllTransactions()
        {
            return myTransactions.ToList();
        }


        #endregion


        #region FINAL REWARDS

        public int getTotalRewards()
        {
            return myTransactions.ToList().Count > 0 ? myTransactions.GroupBy(c => c.Rewards).ToDictionary(x => x.Key, x => x.Count()).Count : 0;
        }

        #endregion


        #region CALCULATED METHODS

        public int calculateRewards(int price)
        {
            if (price >= 50 && price <= 100)
            {
                return price - 50;
            }
            else if (price > 100)
            {
                return (2 * (price - 100) + 50);
            }
            return 0;
        }

        public int[] rewardPerMonth()
        {
            int[] monthlist = new int[2];
            for (int i = 0; i < monthlist.Count(); i++)
            {
                List<Transaction> result = myTransactions.Where(trans => trans.Date.Month == DateTime.Today.AddMonths(-i).Month).ToList();
                monthlist[i] = result.Count;
            }
            return monthlist;
        }

        #endregion
    }
}
