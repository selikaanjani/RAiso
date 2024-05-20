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
        public void add(int TransactionId, int UserId, DateTime TransactionDate)
        {
            thr.add(TransactionId, UserId, TransactionDate);
        }
        public List<TransactionHeader> fetchAll()
        {
            return thr.fetchAll();
        }
        public int generateID()
        {
            return thr.generateId();
        }
    }
}