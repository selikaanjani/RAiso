using RAiso.Handlers;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Controllers
{
    public class CartController
    {
        CartHandler ch = new CartHandler();
        public String validateQty(String qty)
        {
            if (String.IsNullOrEmpty(qty))
            {
                return "Quantity must be filled!";
            }
            else if (Convert.ToInt32(qty) <= 0)
            {
                return "Quantity must be greater than 0!";
            }
            else
            {
                return "Add to cart success!";
            }
        }

        public void add(int UserID, int stationaryId, int Quantity)
        {
            ch.add(UserID, stationaryId, Quantity);
        }

        public List<Cart> FetchAll()
        {
            return ch.fetchAll();
        }
        public void delete(int UserID, int StationeryID)
        {
            ch.delete(UserID, StationeryID);
        }
        public void update(int UserID, int StationeryID, int Quantity)
        {
            ch.update(UserID, StationeryID, Quantity);
        }
        public Cart getCartByUserId (int UserID)
        {
            return ch.getCartById(UserID);
        }
        public void deleteMultipleData(int UserID)
        {
            ch.deleteAllById(UserID);
        }
    }
}