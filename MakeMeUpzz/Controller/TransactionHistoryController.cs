using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class TransactionHistoryController
    {
        
        TransactionHeaderHandler TransHeadHandler = new TransactionHeaderHandler();
        public List<TransactionHeader> GetAllTransactionHeaders()
        {
            return TransHeadHandler.GetAllTransactionHeaders();
        }
        public List<TransactionHeader> GetByUserId(int id)
        {
            return TransHeadHandler.GetByUserId(id);
        }
        public List<TransactionHeader> GetUnhandledTransaction(string status)
        {
            return TransHeadHandler.GetUnhandledTransaction(status);
        }
        public TransactionHeader SearchTransaction(int transid)
        {
            return TransHeadHandler.SearchTransaction(transid);
        }
        public void InsertTransactionHeader(int transid, int userid, DateTime datetime, string transstatus)
        {
            TransHeadHandler.InsertTransactionHeader(transid, userid, datetime, transstatus);
        }
        
        public void UpdateStatus(int TransactionID, string newstatus)
        {
            TransHeadHandler.UpdateStatus(TransactionID, newstatus);
        }
        public TransactionHeader GetLastTransaction()
        {
            return TransHeadHandler.GetLastTransaction();
        }
        public static int GenerateTransactionId()
        {
            return TransactionHeaderHandler.GenerateTransactionId();
        }

    }
}