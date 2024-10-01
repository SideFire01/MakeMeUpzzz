using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class CartRepo
    {
        MakeMeUpEntities1 db = DatabaseSingleton.getInstance();
        public void InsertCart(int id, int uid, int mid, int quantity)
        {
            Cart newCart = CartsFactory.GenerateCart(id, uid, mid, quantity);
            db.Carts.Add(newCart);
            db.SaveChanges();
        }
        public List<Cart> CartAllItem()
        {
            return db.Carts.ToList();
        }
        public void ClearCart()
        {
            db.Carts.RemoveRange(db.Carts);
            db.SaveChanges();
        }
        public Cart LastItem()
        {
            return db.Carts.ToList().LastOrDefault();
        }
    }
}