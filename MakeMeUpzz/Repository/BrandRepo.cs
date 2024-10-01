using MakeMeUpzz.Factory;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class BrandRepo
    {
        private static MakeMeUpEntities1 db = DatabaseSingleton.getInstance();
        public static List<MakeupBrand> getAllBrands()
        {
            return db.MakeupBrands.ToList();
        }

        public static List<int> getallbrandid()
        {
            return (from x in db.MakeupBrands select x.MakeupBrandID).ToList();
        }

        public static int getlastbrandid()
        {
            return (from x in db.MakeupBrands select x.MakeupBrandID).ToList().LastOrDefault();
        }

        public static void insertBrand(int MakeupBrandID, String MakeupBrandName, int MakeupBrandRating)
        {
            MakeupBrand makeupBrand = MakeupBrandFactory.GenerateBrand(MakeupBrandName, MakeupBrandID, MakeupBrandRating);
            db.MakeupBrands.Add(makeupBrand);
            db.SaveChanges();
        }

        public static MakeupBrand searchbrandid(int MakeupBrandID)
        {
            MakeupBrand makeupBrand = db.MakeupBrands.Find(MakeupBrandID);
            return makeupBrand;
        }

        public static void removebrand(int MakeupBrandID)
        {
            MakeupBrand makeupBrand = searchbrandid(MakeupBrandID);
            db.MakeupBrands.Remove(makeupBrand);
            db.SaveChanges();
        }

        public static void updatebrand(int MakeupBrandID, String MakeupBrandName, int MakeupBrandRating)
        {
            MakeupBrand makeupBrand = searchbrandid(MakeupBrandID);
            makeupBrand.MakeupBrandID = MakeupBrandID;
            makeupBrand.MakeupBrandName = MakeupBrandName;
            makeupBrand.MakeupBrandRating = MakeupBrandRating;
            db.SaveChanges();
        }

        public static int searchid(String MakeupBrandName)
        {
            return (from x in db.MakeupBrands
                    where x.MakeupBrandName == MakeupBrandName
                    select x.MakeupBrandID).FirstOrDefault();
        }
        public static int generateBrandID()
        {
            int newID = 0;
            int lastID = MakeupHandler.GetLastBrandId();
            int? lastIDLogic = lastID;
            if (lastIDLogic == null)
            {
                newID = 1;
            }
            else
            {
                newID = lastID;
                newID++;
            }
            return newID;
        }
    }

}