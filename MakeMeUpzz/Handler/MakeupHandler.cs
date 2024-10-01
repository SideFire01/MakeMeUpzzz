using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;

namespace MakeMeUpzz.Handlers
{
    public class MakeupHandler
    {
        public static void InsertMakeup(String name, int price, int weight, int typeid, int brandid)
        {
            MakeupRepo.InsertMakeup(name, price, weight, typeid,brandid);
        }
        public static void UpdateMakeup(int id, String name, int price, int weight, int typeid, int brandid)
        {
            MakeupRepo.updateMakeup(id, name, price, weight, typeid, brandid);
        }
        public static int GetMakeupId(String name, int price, int weight, int typeid, int brandid)
        {
            return MakeupRepo.getMakeupID(name, price, weight, typeid, brandid);
        }
        public static void InsertMakeupType(int typeid, String typename)
        {
            MakeUpTypeRepo.insertMakeupType(typeid, typename);
        }
        public static void UpdateType(int typeid, String typename)
        {
            MakeUpTypeRepo.updateMakeupType(typeid, typename);
        }
        public static void InsertBrand(int brandid, String brandname, int brandrating)
        {
            BrandRepo.insertBrand(brandid, brandname, brandrating);
        }
        public static void UpdateBrand(int brandid, String brandname, int brandrating)
        {
            BrandRepo.updatebrand(brandid, brandname, brandrating);
        }
        public static MakeupType FindMakeupTypeID(int typeid)
        {
            return MakeUpTypeRepo.FindMakeupTypeByID(typeid);
        }
        public static void RemoveMakeup(int typeid)
        {
            MakeUpTypeRepo.RemoveMakeupTypeByID(typeid);
        }
        public static int GetTypeId(String typename)
        {
            return MakeUpTypeRepo.getMakeupTypeIDbyName(typename);
        }
        public static MakeupBrand SearchBrandId(int brandid)
        {
            return BrandRepo.searchbrandid(brandid);
        }
        public static void RemoveBrand(int brandid)
        {
            BrandRepo.removebrand(brandid);
        }
        public static int SearchId(String brandname)
        {
            return BrandRepo.searchid(brandname);
        }
        public static int GetPrice(int id)
        {
            return MakeupRepo.GetPrice(id);
        }
        public static Makeup SearchMakeup(int id)
        {
            return MakeupRepo.SearchMakeup(id);
        }
        public static void DeleteMakeup(int id)
        {
            MakeupRepo.DeleteMakeup(id);
        }
        public static List<MakeupType> GetAllTypes()
        {
            return MakeUpTypeRepo.getAllMakeupTypes();
        }
        public static List<int> GetAllTypeId()
        {
            return MakeUpTypeRepo.getAllMakeupTypeIDs();
        }
        public static int Getlastid()
        {
            return MakeUpTypeRepo.getLastMakeupTypeID();
        }
        public static int Generatetypeid()
        {
            return MakeUpTypeRepo.GenerateTypeId();
        }
        public static List<MakeupBrand> getAllBrands()
        {
            return BrandRepo.getAllBrands();
        }
        public static List<int> GetAllBrandIDs()
        {
            return BrandRepo.getallbrandid();
        }
        public static int GetLastBrandId()
        {
            return BrandRepo.getlastbrandid();
        }
        public static int GenerateBrandId()
        {
            return BrandRepo.generateBrandID();
        }
        public static List<Makeup> GetAllMakeup()
        {
            return MakeupRepo.GetAllMakeUp();
        }
        public static int LastId()
        {
            return MakeupRepo.LastId();
        }
    }
}
