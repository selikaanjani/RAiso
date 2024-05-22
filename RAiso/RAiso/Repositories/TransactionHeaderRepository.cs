using RAiso.Factories;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Repositories
{
    public class TransactionHeaderRepository
    {
        RAisoDatabaseEntities db = DatabaseSingleton.GetInstance();

        public TransactionHeader searchById(int id)
        {
            return (from x in db.TransactionHeaders where x.UserID == id select x).FirstOrDefault();
        }
        public void add(int TransactionId, int UserId, DateTime TransactionDate)
        {
            TransactionHeader th = TransactionHeaderFactory.create(TransactionId, UserId, TransactionDate);
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
        }
        public TransactionHeader getLast()
        {
            return db.TransactionHeaders.ToList().LastOrDefault();
        }

        public TransactionHeader getFirst()
        {
            return (from x in db.TransactionHeaders select x).FirstOrDefault();
        }

        public List<TransactionHeader> fetchAllById(int id)
        {
            return (from x in db.TransactionHeaders where x.UserID == id select x).ToList();
        }

        public List<TransactionHeader> fetchAll()
        {
            return (from x in db.TransactionHeaders select x).ToList();
        }
    }
}