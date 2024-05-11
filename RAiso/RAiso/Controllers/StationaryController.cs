using RAiso.Handlers;
using RAiso.Models;
using RAiso.Repositories;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace RAiso.Controllers
{
    public class StationaryController
    {
        private StationeryHandler sh = new StationeryHandler();
        public String validasiInsert(String name, int price)
        {
            if (name == null || name.Length <= 3 || name.Length >= 50)
            {
                return "Name must be filled and consists of 3-50 characters!";
            }
            else if (price == 0 || price < 2000 || !Numeric(price))
            {
                return "Price must be filled, numeric, and > 2000!";
            }
            return "Add stationary success!";
        }

        public bool Numeric(int price)
        {
            string priceString = price.ToString();
            bool isDigit = false;
            foreach (char c in priceString)
            {
                if (char.IsDigit(c))
                {
                    isDigit = true;
                    break;
                }
            }
            return isDigit;
        }
    }
}