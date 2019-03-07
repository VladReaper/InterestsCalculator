using InterestsCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
  [TestClass]
    public class InterestsCalculatorTests
    {
      [TestMethod]
      public void CalculateInterestsTest()
      {
        List<BalanceInterest> testList = new List<BalanceInterest>()
        { 
          new BalanceInterest() { Balance = 900.70m, Interests = 9.01m },
          new BalanceInterest() { Balance = 1001m, Interests = 15.02m },
          new BalanceInterest() { Balance = 7801.20m, Interests = 156.02m },
          new BalanceInterest() { Balance = 12490.50m, Interests = 312.26m },
          new BalanceInterest() { Balance = 63400.00m, Interests = 1902.00m }
        };

        foreach (BalanceInterest bi in testList)
        {
          var interests = (new MainForm().CalculateInterests(bi.Balance));

          Assert.AreEqual(bi.Interests, interests);
        }
      }
    }

    class BalanceInterest
    {
      public decimal Balance { get; set; }
      public decimal Interests { get; set; }
    }
}
