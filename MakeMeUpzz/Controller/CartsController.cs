using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class CartsController
    {
        public static List<Cart> GetAllCartItems()
        {
            CartHandler handler = new CartHandler();
            return handler.GetAllCartItems();
        }
        public static void InsertToCart(int userId,int makeupId,int quantity)
        {
            CartHandler handler = new CartHandler();
            int id = OrderController.GenerateId();

            handler.CartInsert(id, userId, makeupId, quantity);
        }
     
    }
}