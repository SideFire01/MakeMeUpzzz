using MakeMeUpzz.Handlers;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class MakeupController
    {
        public static string InsertMakeupValidator(string MakeupName, int MakeupPrice, int MakeupWeight, int MakeupTypeID, int MakeupBrandID)
        {
            string errmess = "";
            if (MakeupName.Length < 1 || MakeupName.Length > 99)
            {
                errmess = "Please fill the Makeup Name between 1 to 99 characters";
            }
            else if (MakeupPrice < 1)
            {
                errmess = "Makeup Price should be greater than or equal to 1";
            }
            else if (MakeupWeight > 1500)
            {
                errmess = "Makeup Weight cannot be greater than 1500 grams";
            }
            else if (MakeupTypeID == 0)
            {
                errmess = "Type ID cannot be empty";
            }
            else if (MakeupBrandID == 0)
            {
                errmess = "Brand ID cannot be empty";
            }
            return errmess;
        }
        public static string MakeupBrandValidator(string MakeupBrandName, int MakeupBrandRating)
        {
            string errmess = "";
            if (MakeupBrandName.Length < 1 || MakeupBrandName.Length > 99)
            {
                errmess = "Please fill the Makeup Brand Name between 1 to 99 characters";
            }
            else if (MakeupBrandRating < 0 || MakeupBrandRating > 100)
            {
                errmess = "Makeup Brand Rating must be between 0 and 100";
            }
            return errmess;
        }
        public static string MakeupTypeValidator(string MakeupName)
        {
            string errorMessage = "";
            if (MakeupName.Length < 1 || MakeupName.Length > 99)
            {
                errorMessage = "Please fill the Makeup Name between 1 to 99 characters";
            }
            return errorMessage;
        }

        public static void InsertNewMakeup(String MakeupName, int MakeupPrice, int MakeupWeight,
            int MakeupTypeID, int MakeupBrandID)
        {
            MakeupHandler.InsertMakeup(MakeupName, MakeupPrice, MakeupWeight, MakeupTypeID,
                MakeupBrandID);
        }
        public static void UpdateMakeup(int MakeupID, String MakeupName, int MakeupPrice, int MakeupWeight,
            int MakeupTypeID, int MakeupBrandID)
        {
            MakeupHandler.UpdateMakeup(MakeupID, MakeupName, MakeupPrice, MakeupWeight, MakeupTypeID,
                MakeupBrandID);
        }
        public static void UpdateMakeupType(int MakeupTypeID, String MakeupTypeName)
        {
            MakeupHandler.UpdateType(MakeupTypeID, MakeupTypeName);
        }
        public static void UpdateMakeupBrand(int MakeupBrandID, String MakeupBrandName, int MakeupBrandRating)
        {
            MakeupHandler.UpdateBrand(MakeupBrandID, MakeupBrandName, MakeupBrandRating);
        }
        public static void InsertMakeupBrand(int MakeupBrandID, String MakeupBrandName, int MakeupBrandRating)
        {
            MakeupHandler.InsertBrand(MakeupBrandID, MakeupBrandName, MakeupBrandRating);
        }
        public static void InsertMakeupType(int MakeupTypeID, String MakeupTypeName)
        {
            MakeupHandler.InsertMakeupType(MakeupTypeID, MakeupTypeName);
        }

        public static MakeupType FindMakeupTypeID(int MakeupTypeID)
        {
            return MakeupHandler.FindMakeupTypeID(MakeupTypeID);
        }
        public static int generateMakeupTypeID()
        {
            return MakeupHandler.Generatetypeid();
        }
        public static int generateMakeupBrandID()
        {
            return MakeupHandler.GenerateBrandId();
        }
        public static void RemoveMakeupByID(int MakeupID)
        {
            MakeupHandler.DeleteMakeup(MakeupID);
        }
        public static void RemoveMakeupTypeByID(int MakeupTypeID)
        {
            MakeupHandler.RemoveMakeup(MakeupTypeID);
        }
        public static void RemoveMakeupBrandByID(int MakeupBrandID)
        {
            MakeupHandler.RemoveBrand(MakeupBrandID);
        }
        public static int getMakeupPrice(int id)
        {
            return MakeupHandler.GetPrice(id);
        }
        public static Makeup FindById(int id)
        {
            return MakeupHandler.SearchMakeup(id);
        }
        public static MakeupBrand FindMakeupBrandId(int MakeupBrandID)
        {
            return MakeupHandler.SearchBrandId(MakeupBrandID);
        }

        public static List<MakeupType> GetAllMakeupTypes()
        {
            return MakeupHandler.GetAllTypes();
        }

        public static List<MakeupBrand> GetAllMakeupBrands()
        {
            return MakeupHandler.getAllBrands();
        }

        public static List<Makeup> GetAllMakeups()
        {
            return MakeupHandler.GetAllMakeup();
        }
        
        
    }
}