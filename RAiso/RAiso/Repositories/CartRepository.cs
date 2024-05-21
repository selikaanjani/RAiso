using RAiso.Factories;
using RAiso.Handlers;
using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Repositories
{
    public class CartRepository
    {
        private RAisoDatabaseEntities db = DatabaseSingleton.GetInstance();
        public Cart search(int UserID, int StationeryID)
        {
            return (from x in db.Carts
                    where x.UserID == UserID && x.StationeryID == StationeryID
                    select x).ToList().FirstOrDefault();
        }
        public Cart searchByUserID(int UserID)
        {
            return (from x in db.Carts
                    where x.UserID == UserID
                    select x).ToList().FirstOrDefault();
        }
        public List<Cart> fetchAll()
        {
            return(from x in db.Carts select x).ToList();
        }

        public void add(int UserID, int StationeryID, int Quantity)
        {
            Cart cart = CartFactory.create(UserID, StationeryID, Quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public void delete(int UserID, int StationeryID)
        {
            Cart cart = search(UserID, StationeryID);
            db.Carts.Remove(cart);
            db.SaveChanges();
        }

        public void Update(int UserID, int StationeryID, int Quantity)
        {
            Cart cart = search(UserID, StationeryID);
            cart.UserID = UserID;
            cart.StationeryID = StationeryID;
            cart.Quantity = Quantity;
            db.SaveChanges();
        }

    }
}