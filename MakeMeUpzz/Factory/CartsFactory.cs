using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class CartsFactory
    {
        public static Cart GenerateCart(int cartid, int userid, int makeupid, int quantity)
        {
            Cart newCart = new Cart();
            newCart.CartID = cartid;
            newCart.UserID = userid;
            newCart.MakeupID = makeupid;
            newCart.Quantity = quantity;
            return newCart;
        }
    }
}