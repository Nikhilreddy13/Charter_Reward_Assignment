using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reward_Assignment.Repository;
using System.Linq;

namespace Reward_Assignment_Test
{
    [TestClass]
    public class RewardTestCases
    {
        RewardAssignment rewardAssignment = new RewardAssignment();
        [TestMethod]
        public void AddTransactionTest()
        {
            int Price = 10;

            rewardAssignment.addTransaction(Price);

            Assert.AreEqual(rewardAssignment.getAllTransactions().FirstOrDefault(c => c.price == Price).price, // Expected Value
                            Price); //Actual Value
        }


        [TestMethod]
        public void GetAllAddedTransactionsTest()
        {
            int totalTransactions =  20;
            for (int i = 1; i <= totalTransactions; i++) // Addidng Ten Transactions.
            {
                rewardAssignment.addTransaction(i);
            }
            Assert.IsTrue(rewardAssignment.getAllTransactions().Count == totalTransactions); 
        }

        [TestMethod]
        public void GetTotalRewardsTest()
        {
            for (int i = 11; i <= 40; i++) // Addidng Fourty Transactions.
            {
                rewardAssignment.addTransaction(i);
            }
            Assert.IsTrue(rewardAssignment.getTotalRewards()>0);
        }

        [TestMethod]
        public void CalculateRewardTest()
        {
            int? CalculatedReward = rewardAssignment.calculateRewards(20);
            //Calculated Values Contains Value
            Assert.IsNotNull(CalculatedReward);
        }

        [TestMethod]
        public void RewardPermonthTest()
        {
            int AddedTransactions = 30;
            for (int i = 1; i <= AddedTransactions; i++) // Addidng Fourty Transactions.
            {
                rewardAssignment.addTransaction(i);
            } // adding the transactions
            int[] results = rewardAssignment.rewardPerMonth();
            Assert.IsTrue(results[0] > 0); // check whether all the transactions added or not.
            Assert.AreEqual(results[0], AddedTransactions); // check whether added transactions and requested transactions are same or not.
        }

       


    }
}
