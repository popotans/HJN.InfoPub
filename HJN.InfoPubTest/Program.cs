using HJN.InfoPub.Core;
using PWMIS.Core.YueWen.DataProvider;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HJN.InfoPubTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 1; i++)
            //{
            //    YwDb db = DbContext.GetInfoDb();
            //    var item = db.QueryObject<InfoPub.Entity.infopub_admin_menu>("select * from admin_menu  ");
            //    Console.WriteLine(item.name + " ");
            //}

            //Console.WriteLine("sw.Elapsed" + sw.Elapsed);

            //Console.WriteLine("reset");
            //sw.Restart();
            //for (int i = 0; i < 10000; i++)
            //{
            //    YwDb db = DbContext.GetInfoDb();
            //    var item = db.QueryObject<InfoPub.Entity.infopub_admin_menu>("select * from admin_menu  ");
            //    Console.WriteLine(item.name + " ");
            //}
            //Console.WriteLine("sw.Elapsed" + sw.Elapsed);
            //Console.ReadKey();
            
            Ztreetest ztreetest = new Ztreetest();
            ztreetest.DoRun();
        }
    }
}
