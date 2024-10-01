using MakeMeUpzz.Controller;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class TransactionHeaderRepo
    {
        MakeMeUpEntities1 db = DatabaseSingleton.getInstance();
        public static int GenerateTransactionId()
        {
            var historyController = new TransactionHistoryController();
            var lastTransaction = historyController.GetLastTransaction();
            return lastTransaction == null ? 1 : lastTransaction.TransactionID + 1;
        }
        public void InsertHeader(int tid, int uid, DateTime dt, string status)
        {
            
            TransactionHeader th = TransactionHeaderFactory.GenerateHeader(tid, uid, dt, status);
            db.TransactionHeaders.Add(th);
            db.SaveChanges();

        }
        public TransactionHeader search(int tid)
        {
            return (from TransactionHeader in db.TransactionHeaders where TransactionHeader.TransactionID == tid select TransactionHeader).FirstOrDefault();
        }
        public TransactionHeader getTransaction(int id)
        {
            TransactionHeader th = db.TransactionHeaders.Find(id);
            return th;
        }
        public List<TransactionHeader> getbyuserid(int id)
        {
            return db.TransactionHeaders.Where(i => i.UserID == id).ToList();

        }
        public  List<TransactionHeader> GetAllTransactionHeaders()
        {
            return db.TransactionHeaders.ToList();
        }

        public TransactionHeader GetLastTransaction()
        {
            return db.TransactionHeaders.ToList().LastOrDefault();
        }
        public List<TransactionHeader> GetUnhandledTransactions(string trans)
        {
            return (from x in db.TransactionHeaders where x.Status.Equals(trans) select x).ToList();
        }
        
        public void UpdateStatus(int id, string newstatus)
        {
            TransactionHeader th = getTransaction(id);
            th.Status = newstatus;
            db.SaveChanges();
        }
        public static List<TransactionHeader> getallTransactions()
        {
            MakeMeUpEntities1 MakeUpEntities = new MakeMeUpEntities1();
            return MakeUpEntities.TransactionHeaders.ToList();
        }
        

    }
}