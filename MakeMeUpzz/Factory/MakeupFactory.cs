using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class MakeupFactory
    {
        public static Makeup GenerateMakeup(int id, String name, int price, int weight, int typeid, int brandid)
        {
            Makeup newMakeup = new Makeup();
            newMakeup.MakeupID = id;
            newMakeup.MakeupName = name;
            newMakeup.MakeupPrice = price;
            newMakeup.MakeupWeight = weight;
            newMakeup.MakeupBrandID = brandid;
            newMakeup.MakeupTypeID = typeid;
            return newMakeup;
        }
    }
}