using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class TransactionDetailController
    {
        public static List<TransactionDetail> FindByTransactionId(int transid)
        {
            DetailHandler detailHandler = new DetailHandler();
            return detailHandler.FindByTransactionId(transid);
        }
        public void InsertTransactionDetail(int transid, int makeupid, int quantity)
        {
            DetailHandler detailHandler = new DetailHandler();
            detailHandler.InsertDetail(transid, makeupid, quantity);
        }
        public static List<TransactionDetail> GetAllTransactionDetails()
        {
            DetailHandler detailHandler = new DetailHandler();
            return detailHandler.GetAllTransactionDetails();
        }
        
        
    }
}