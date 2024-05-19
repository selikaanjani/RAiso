using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Factories
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail create(int TransactionId, int stationeryId, int Quantity)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionID = TransactionId;
            td.StationeryID = stationeryId;
            td.Quantity = Quantity;
            return td;
        }
    }
}