using PWMIS.Core.YueWen.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJN.InfoPub.Core
{
    public class DbContext
    {
        public static YwDb GetInfoDb()
        {
            YwDb db = new YwMySql();
            db.ConnectionString = "server=localhost;user id=root;password=;database=infopub";
            return db;
        }
    }
}
