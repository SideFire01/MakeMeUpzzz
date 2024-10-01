using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class OrderController
    {
        public static int GenerateId()
        {
            CartHandler handler = new CartHandler();
            Cart lastcart = handler.GetLastItem();
            if (lastcart == null)
            {
                return 1;
            }
            return lastcart.CartID + 1;
        }
        public static void EmptyCart()
        {
            CartHandler handler = new CartHandler();
             handler.EmptyCart();
             
        }
        public static List<Makeup> GetAllMakeups()
        {
            return MakeupHandler.GetAllMakeup();
        }
    }
}