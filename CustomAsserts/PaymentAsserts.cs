using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CustomAsserts.Tests
{
    public static class PaymentAsserts
    {
        public static void AbleToWithdraw(this Assert assert, int balance, int withdrawalAmount)
        {
            if (withdrawalAmount > balance)
                throw new AssertFailedException($"The withdrawal was greater than your balance. Balance:{balance} Withdrawal:{withdrawalAmount}");

            return;
        }

        public static void AbleToDeposit(this Assert assert, int depositAmount)
        {
            if(depositAmount <= 0 )
                throw new AssertFailedException($"The Deposit amount was either negative or zero. Deposit:{depositAmount}");

            return;
        }
    }
}
