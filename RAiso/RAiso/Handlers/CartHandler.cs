using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace RAiso.Handlers
{
    public class CartHandler
    {
        public String validateQty(int qty)
        {
            if (String.IsNullOrEmpty(qty.ToString())|| qty == null || qty < 0)
            {
                return "Quantity must be filled and greater than 0!";
            }
            else
            {
                return "Add to cart success";
            }
        }
    }
}