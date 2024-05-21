using RAiso.Handlers;
using RAiso.Models;
using RAiso.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace RAiso.Controllers
{
    public class StationeryController
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

        public List<MsStationery> viewAllStationary()
        {
            return sh.getAllStationery();
        }

        public void popStationary(int id)
        {
            sh.deleteStationary(id);
        }

        public int createID()
        {
            return sh.buatID();
        }
        public void createStationary(int id, String name, int price)
        {
            sh.add(id, name, price); 
        }

        public MsStationery searchById(int id)
        {
            return sh.searchById(id);
        }

        public void updateStationary(int id, String name, int price)
        {
            sh.updateStationary(id, name, price);
        }

        public int getStationeryIdByName(String Name)
        {
            MsStationery stationery = sh.searchByName(Name);
            return stationery.StationeryID;
        }
    }
}