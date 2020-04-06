using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BDDFramework_WishList.Helper;
using Newtonsoft.Json;

namespace specflowstepbystep.Helper
{
    public static class HelperFunctions
    {
        public static string productname;
        public static void sleep(int time)
        {
            System.Threading.Thread.Sleep(time);
        }

        public static string get_product_fromjson()
        {
            string strResultJson = String.Empty;
            strResultJson = File.ReadAllText(Config._jsonfilepath);
            Product str = JsonConvert.DeserializeObject<Product>(strResultJson);
            return str.Name;
        }
    }
}
