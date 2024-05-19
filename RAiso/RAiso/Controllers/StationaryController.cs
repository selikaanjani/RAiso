﻿using RAiso.Handlers;
using RAiso.Models;
using RAiso.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace RAiso.Controllers
{
    public class StationaryController
    {
        private StationeryHandler sh = new StationeryHandler();
        public String validasiInsert(String name, string price)
        {
            if (String.IsNullOrEmpty(name) || (String.IsNullOrEmpty(price)))
            {
                return "All fields must be filled!";

            }
            else if (name.Length <= 3 || name.Length >= 50)
            {
                return "Name must be consists of 3-50 characters!";
            }
            //price
            else
            {
                if (Convert.ToInt32(price) < 2000 || !Numeric(Convert.ToInt32(price)))
                {
                    return "Price must be numeric, and greather than 2000!";
                }
                return "Add stationary success!";
            }
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