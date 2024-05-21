using RAiso.Factories;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Repositories
{
    public class TransactionDetailRepositiory
    {
        RAisoDatabaseEntities db = DatabaseSingleton.GetInstance();
        public void add(int TransactionId, int StationaryId, int Quantity)
        {
            TransactionDetail td = TransactionDetailFactory.create(TransactionId, StationaryId, Quantity);
            db.TransactionDetails.Add(td);
            db.SaveChanges();
        }
        public List<TransactionDetail> fetchAll()
        {
            return (from x in db.TransactionDetails select x).ToList();
        }
        public TransactionDetail getLast()
        {
            return db.TransactionDetails.ToList().LastOrDefault();
        }

        public TransactionDetail getFirst()
        {
            return (from x in db.TransactionDetails select x).FirstOrDefault();
        }
    }
}