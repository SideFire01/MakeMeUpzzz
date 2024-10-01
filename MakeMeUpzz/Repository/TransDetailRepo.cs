using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class TransDetailRepo
    {
        MakeMeUpEntities1 db = DatabaseSingleton.getInstance();
        public List<TransactionDetail> GetLLTransDetails()
        {
            return db.TransactionDetails.ToList();
        }
        public List<TransactionDetail> SearchTransId(int transid)
        {
            return db.TransactionDetails.Where(i => i.TransactionID == transid).ToList();
        }
        public List<TransactionDetail> SearchMakeupId(int transid)
        {
            return db.TransactionDetails.Where(i => i.MakeupID == transid).ToList();
        }
        public void InsertDetail(int tid, int mid, int quantity)
        {
            TransactionDetail td = TransactionDetailsFactory.GenerateTransaction(tid, mid, quantity);
            db.TransactionDetails.Add(td);
            db.SaveChanges();

        }
        
        

    }
}