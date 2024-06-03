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
        public List<TransactionHeader> fetchAllById(int UserID)
        {
            if (thr.searchById(UserID) == null)
            {
                return null;
            }

            return thr.fetchAllById(UserID);
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
        public List<TransactionHeader> fetchAll()
        {
            return thr.fetchAll();
        }

        public TransactionHeader searchById(int id)
        {
            return thr.searchById(id);
        }

        public void delete(int id)
        {
            if (searchById(id) != null)
            {
                thr.delete(id);
            }
        }
    }
}