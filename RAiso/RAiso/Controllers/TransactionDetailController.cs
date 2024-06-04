using RAiso.Handlers;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Controllers
{
    public class TransactionDetailController
    {
        TransactionDetailHandler tdh = new TransactionDetailHandler();
        public void addMultipleData(List<Cart> carts, int transactionId)
        {
            foreach (Cart cart in carts)
            {
                tdh.add(transactionId, cart.StationeryID, cart.Quantity);
            }
        }

        public List<TransactionDetail> fetchAll()
        {
            return tdh.fetchAll();
        }
        public List<TransactionDetail> fetchAllById(int TransactionID)
        {
            return tdh.fetchAllById(TransactionID);
        }
    }
}