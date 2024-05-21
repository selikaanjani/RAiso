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

        public List<TransactionHeader> fetchAll()
        {
            return thh.fetchAll();
        }

        public void add(int UserID)
        {
            DateTime date = DateTime.Now;
            thh.add(thh.generateID(), UserID, date);
        }
    }
}