using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Controllers
{
    public class CartController
    {
        public String validateQty(int qty)
        {
            if (String.IsNullOrEmpty(qty.ToString()))
            {
                return "Quantity must be filled!";
            }
            else if (qty < 0)
            {
                return "Quantity must be greater than 0!";
            }
            else
            {
                return "Add to cart success!";
            }
        }
    }
}