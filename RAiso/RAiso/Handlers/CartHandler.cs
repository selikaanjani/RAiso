using RAiso.Models;
using RAiso.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Handlers
{
    public class CartHandler
    {
        CartRepository cr = new CartRepository();
        public List<Cart> fetchAll()
        {
            return cr.fetchAll();
        }
        public void add(int UserID, int stationaryId, int Quantity)
        {
            cr.add(UserID, stationaryId, Quantity);
        }
        public void deleteAllById(int UserID)
        {
            cr.deleteAllById(UserID);
        }
        public void update(int UserID, int staionaryID, int Quantity)
        {
            cr.Update(UserID, staionaryID, Quantity);
        }
        public Cart getCartById(int UserID)
        {
            return cr.searchByUserID(UserID);
        }
        public void delete(int UserID, int StationeryID)
        {
            cr.delete(UserID, StationeryID);
        }
    }
}