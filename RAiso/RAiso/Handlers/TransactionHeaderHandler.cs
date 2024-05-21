using RAiso.Models;
using RAiso.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Handlers
{
    public class TransactionHeaderHandler
    {
        TransactionHeaderRepository thr = new TransactionHeaderRepository();
        public void add(int UserId, DateTime TransactionDate)
        {
            thr.add(generateID(), UserId, TransactionDate);
        }
        public List<TransactionHeader> fetchAll()
        {
            return thr.fetchAll();
        }
        public int generateID()
        {
            if (thr.getFirst() == null)
            {
                return 1;
            }
            else
            {
                TransactionHeader transactionHeader = thr.getLast();
                return transactionHeader.TransactionID + 1;
            }
        }
    }
}