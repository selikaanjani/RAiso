using RAiso.Models;
using RAiso.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Handlers
{
    public class TransactionDetailHandler
    {
        TransactionDetailRepositiory tdr = new TransactionDetailRepositiory();
        public void add(int TransactionId, int StationeryId, int Quantity)
        {
            tdr.add(TransactionId, StationeryId, Quantity);
        }
        public List<TransactionDetail> fetchAll()
        {
            return tdr.fetchAll();
        }
        public int generateID()
        {
            return tdr.generateId();
        }
    }
}