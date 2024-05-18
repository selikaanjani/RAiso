using RAiso.Factories;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Repositories
{
    public class StationeryRepository
    {
        private RAisoDatabaseEntities db = DatabaseSingleton.GetInstance();

        public List<MsStationery> fetchAll()
        {
            return (from x in db.MsStationeries select x).ToList();
        }

        public MsStationery search(int id)
        {
            return (from x in db.MsStationeries
                    where x.StationeryID == id
                    select x).ToList().FirstOrDefault();
        }
        public MsStationery searchName(String StationeryName)
        {
            return (from x in db.MsStationeries
                    where x.StationeryName == StationeryName
                    select x).ToList().FirstOrDefault();
        }
        public int generateId()
        {
            MsStationery st = db.MsStationeries.ToList().LastOrDefault();
            if (st == null)
            {
                return 1;
            }
            else
            {
                return st.StationeryID + 1;
            }
        }
        public void add(int id, String name, int price)
        {
            int NewID = generateId();
            MsStationery st = StationaryFactory.Create(id, name, price);
            db.MsStationeries.Add(st);
            db.SaveChanges();
        }

        public void delete(int id)
        {
            MsStationery st = search(id);
            db.MsStationeries.Remove(st);
            db.SaveChanges();
        }

        public void update(int id, String name, int price)
        {
            MsStationery st = search(id);
            st.StationeryID = id;
            st.StationeryName = name;
            st.StationeryPrice = price;
            db.SaveChanges();
        }
    }
}