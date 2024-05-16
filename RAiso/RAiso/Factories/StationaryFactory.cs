using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Factories
{
    public class StationaryFactory
    {
        public static MsStationery Create(int id, string name, int price)
        {
            MsStationery st = new MsStationery();
            st.StationeryID = id;
            st.StationeryName = name;
            st.StationeryPrice = price;
            return st;
        }
    }
}