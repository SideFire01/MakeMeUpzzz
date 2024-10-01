using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader GenerateHeader(int transid, int userid, DateTime datetime, string status)
        {
            TransactionHeader newHeader = new TransactionHeader();
            newHeader.TransactionID = transid;
            newHeader.UserID = userid;
            newHeader.Status = status;
            newHeader.TransactionDate = datetime;
            return newHeader;
        }
    }
}