using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Factories
{
    public class CartFactory
    {
        public static Cart create(int UserID, int StationaryID, int Quantity)
        {
            Cart cart = new Cart();
            cart.UserID = UserID;
            cart.StationeryID = StationaryID;
            cart.Quantity = Quantity;
            return cart;
        }
    }
}