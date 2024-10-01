using MakeMeUpzz.Controller;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;

namespace MakeMeUpzz.Handlers
{
    public class TransactionHeaderHandler
    {
        private readonly TransactionHeaderRepo _transactionHeaderRepo;

        public TransactionHeaderHandler()
        {
            _transactionHeaderRepo = new TransactionHeaderRepo();
        }

        public void InsertTransactionHeader(int tid, int uid, DateTime dt, string status)
        {
            _transactionHeaderRepo.InsertHeader(tid, uid, dt, status);
        }

        public  TransactionHeader GetLastTransaction()
        {
            return _transactionHeaderRepo.GetLastTransaction();
        }
        public List<TransactionHeader> GetByUserId(int id)
        {
            return _transactionHeaderRepo.getbyuserid(id);

        }
        public  List<TransactionHeader> GetAllTransactionHeaders()
        {
            return _transactionHeaderRepo.GetAllTransactionHeaders();
        }
        public List<TransactionHeader> GetUnhandledTransaction(string a)
        {
            return _transactionHeaderRepo.GetUnhandledTransactions(a);
        }
        public TransactionHeader SearchTransaction(int tid)
        {
            return _transactionHeaderRepo.search(tid);
        }
        public void UpdateStatus(int TransactionID, string statusnew)
        {
            _transactionHeaderRepo.UpdateStatus(TransactionID, statusnew);
        }

        public static List<TransactionHeader> getallTransaction()
        {
            return TransactionHeaderRepo.getallTransactions();
        }
        public static int GenerateTransactionId()
        {
            return TransactionHeaderRepo.GenerateTransactionId();
        }
    }
}
