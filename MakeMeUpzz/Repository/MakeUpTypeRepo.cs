using MakeMeUpzz.Factory;
using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class MakeUpTypeRepo
    {

        private static MakeMeUpEntities1 db = DatabaseSingleton.getInstance();
        public static int GenerateTypeId()
        {
            int lastID = MakeupHandler.Getlastid();
            return lastID == 0 ? 1 : lastID + 1;
        }
        public static void RemoveMakeupTypeByID(int MakeupTypeID)
        {
            MakeupType makeupType = db.MakeupTypes.Find(MakeupTypeID);
            db.MakeupTypes.Remove(makeupType);
            db.SaveChanges();
        }

        public static void updateMakeupType(int MakeupTypeID, String MakeupTypeName)
        {
            MakeupType makeupType = FindMakeupTypeByID(MakeupTypeID);
            makeupType.MakeupTypeID = MakeupTypeID;
            makeupType.MakeupTypeName = MakeupTypeName;
            db.SaveChanges();
        }

        public static int getMakeupTypeIDbyName(String MakeupTypeName)
        {
            return (from x in db.MakeupTypes
                    where x.MakeupTypeName == MakeupTypeName
                    select x.MakeupTypeID).FirstOrDefault();
        }
        public static List<int> getAllMakeupTypeIDs()
        {
            return (from x in db.MakeupTypes select x.MakeupTypeID).ToList();
        }

        public static void insertMakeupType(int MakeupTypeID, String MakeupTypeName)
        {
            MakeupType makeupType = MakeupTypeFactory.GenerateMakeupType(MakeupTypeID, MakeupTypeName);
            db.MakeupTypes.Add(makeupType);
            db.SaveChanges();
        }
        public static List<MakeupType> getAllMakeupTypes()
        {
            return db.MakeupTypes.ToList();
        }

        public static int getLastMakeupTypeID()
        {
            return (from x in db.MakeupTypes select x.MakeupTypeID).ToList().LastOrDefault();
        }

        

        public static MakeupType FindMakeupTypeByID(int MakeupTypeID)
        {
            MakeupType makeupType = db.MakeupTypes.Find(MakeupTypeID);
            return makeupType;
        }

        






    }

}