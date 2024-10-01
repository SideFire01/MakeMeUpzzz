using MakeMeUpzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class MakeupTypeFactory
    {
        public static MakeupType GenerateMakeupType(int id, String name)
        {
            MakeupType newType = new MakeupType();
            newType.MakeupTypeID = id;
            newType.MakeupTypeName = name;
            return newType;
        }
    }
}