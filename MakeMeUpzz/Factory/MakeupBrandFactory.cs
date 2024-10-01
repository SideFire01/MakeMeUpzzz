using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class MakeupBrandFactory
    {
        public static MakeupBrand GenerateBrand(String name, int id, int rating)
        {
            MakeupBrand newBrand = new MakeupBrand();
            newBrand.MakeupBrandID = id;
            newBrand.MakeupBrandName = name;
            newBrand.MakeupBrandRating = rating;
            return newBrand;
        }
    }
}