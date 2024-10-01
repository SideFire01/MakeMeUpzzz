using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System.Collections.Generic;

namespace MakeMeUpzz.Handlers
{
    public class CartHandler
    {
        private readonly CartRepo cartRepos;
        public CartHandler()
        {
            cartRepos = new CartRepo();
        }
        public List<Cart> GetAllCartItems()
        {
            return cartRepos.CartAllItem();
        }
        public Cart GetLastItem()
        {
            return cartRepos.LastItem();
        }
        public void CartInsert(int id, int userid, int makeupid, int quantity)
        {
            cartRepos.InsertCart(id, userid, makeupid, quantity);
        }
        public void EmptyCart()
        {
            cartRepos.ClearCart();
        }
    }
}
