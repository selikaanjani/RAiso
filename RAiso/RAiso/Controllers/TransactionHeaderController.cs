using RAiso.Handlers;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Controllers
{
    public class TransactionHeaderController
    {
        TransactionHeaderHandler thh = new TransactionHeaderHandler();

        public List<TransactionHeader> fetchAllById(int UserID)
        {
            return thh.fetchAllById(UserID);
        }

        public List<TransactionHeader> fetchAll()
        {
            return thh.fetchAll();
        }

        public void add(int UserID)
        {
            DateTime date = DateTime.Now;
            thh.add(UserID, date);
        }

        public void remove(int TransactionID)
        {
            thh.delete(TransactionID);
        }

        public int getNewId()
        {
            return thh.generateID();
        }
    }
}