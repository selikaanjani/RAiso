using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Factories
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader create(int TransactionId, int UserId, DateTime TransactionDate)
        {
            TransactionHeader th = new TransactionHeader();
            th.TransactionID = TransactionId;
            th.UserID = UserId;
            th.TransactionDate = TransactionDate;
            return th;
        }
    }
}