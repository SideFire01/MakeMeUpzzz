using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class TransactionDetailsFactory
    {
        public static TransactionDetail GenerateTransaction(int id, int makeupid, int quantity)
        {
            TransactionDetail newTransaction = new TransactionDetail();
            newTransaction.TransactionID = id;
            newTransaction.MakeupID = makeupid;
            newTransaction.Quantity = quantity;
            return newTransaction;
        }
    }
}