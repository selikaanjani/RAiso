using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Handlers
{
    public class CartHandler
    {
        public String validateQty(int qty)
        {
            if (qty < 0)
            {
                return "Quantity must be greater than 0!";
            }
            else
            {
                return "Add to cart success";
            }
        }
    }
}