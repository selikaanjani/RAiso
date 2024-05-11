using RAiso.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RAiso.Models;

namespace RAiso.Handlers
{
    public class StationeryHandler
    {
        StationeryRepository sr = new StationeryRepository();
        public List<MsStationery> getAllStationery()
        {
            return sr.fetchAll();
        }

        public void add(int id, String name, int price)
        {
            sr.add(id, name, price);
        }

        public MsStationery searchById(int id)
        {
            return sr.search(id);
        }
        public void deleteStationary(int id)
        {
            sr.delete(id);
        }
        public void updateStationary(int id, String name, int price)
        {
            sr.update(id, name, price);
        }

        public int buatID()
        {
            return sr.generateId();
        }

    }
}