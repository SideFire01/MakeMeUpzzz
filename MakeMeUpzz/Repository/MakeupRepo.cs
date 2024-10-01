using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class MakeupRepo
    {
        private static MakeMeUpEntities1 db = DatabaseSingleton.getInstance();

        public static int getMakeupID(String name, int price, int weight, int typeid, int brandid)
        {
            return db.Makeups
         .Where(x => x.MakeupName == name &&
                     x.MakeupPrice == price &&
                     x.MakeupWeight == weight &&
                     x.MakeupTypeID == typeid &&
                     x.MakeupBrandID == brandid)
         .Select(x => x.MakeupID)
         .FirstOrDefault();
        }
        public static void updateMakeup(int id, String name, int price, int weight, int typeid, int brandid)
        {
            Makeup updatedMakeup = SearchMakeup(id);
            updatedMakeup.MakeupName = name;
            updatedMakeup.MakeupPrice = price;
            updatedMakeup.MakeupWeight = weight;
            updatedMakeup.MakeupTypeID = typeid;
            updatedMakeup.MakeupBrandID = brandid;
            db.SaveChanges();
        }
        
        public static void DeleteMakeup(int id)
        {
            TransDetailRepo dr = new TransDetailRepo();
            List<TransactionDetail> transactionlist = dr.SearchMakeupId(id);
            foreach (var transaction in transactionlist)
            {
                db.TransactionDetails.Remove(transaction);
            }
            db.SaveChanges();
            Makeup makeup = db.Makeups.Find(id);
            db.Makeups.Remove(makeup);

            db.SaveChanges();
        }
        public static void InsertMakeup(String name, int price, int wieght, int typeid, int brandid)
        {
            int newMakeup = 0;
            int lastID = (from x in db.Makeups select x.MakeupID).ToList().LastOrDefault();
            if (db == null)
            {
                newMakeup = 1;
            }
            else
            {
                newMakeup = lastID+1;
            }
            Makeup makeup = MakeupFactory.GenerateMakeup(newMakeup, name, price, wieght,typeid, brandid);
            db.Makeups.Add(makeup);

            db.SaveChanges();
        }
        public static Makeup SearchMakeup(int makeupid)
        {
            Makeup makeup = db.Makeups.Find(makeupid);
            return makeup;
        }
        public static int GetPrice(int id)
        {
            return (from x in db.Makeups where x.MakeupID == id select x.MakeupPrice).FirstOrDefault();
        }
        public static List<Makeup> GetAllMakeUp()
        {
            return db.Makeups.ToList();
        }
        public static int LastId()
        {
            return (from x in db.Makeups select x.MakeupID).ToList().LastOrDefault();
        }
    }

}