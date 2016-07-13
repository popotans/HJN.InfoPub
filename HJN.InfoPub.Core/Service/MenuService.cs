using FluentValidation.Results;
using HJN.InfoPub.Core.IDao;
using HJN.InfoPub.Core.Validate;
using HJN.InfoPub.Entity;
using PWMIS.Core.YueWen.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJN.InfoPub.Core.Service
{
    public class MenuService
    {
        public MenuService()
        {

        }

        public int Add(infopub_admin_menu menuentity)
        {
            MenuValidator.DoValidate(menuentity);

            YwDb db = DbContext.GetInfoDb();
            return db.Insert(menuentity);
        }

        public int Update(infopub_admin_menu menuentity)
        {
            YwDb db = DbContext.GetInfoDb();
            return db.Update(menuentity);
        }

        public int Delete(int idx)
        {
            YwDb db = DbContext.GetInfoDb();
            int rr = db.ExecuteNonQuery("delete from admin_menu where idx=" + idx);
            return rr;
        }

        public infopub_admin_menu Get(int idx)
        {
            YwDb db = DbContext.GetInfoDb();
            string sql = "select * from admin_menu where idx=" + idx;
            return db.QueryObject<infopub_admin_menu>(sql);
        }

        public PagedModel GetList(int pageno, int pagesize, string where)
        {
            YwDb db = DbContext.GetInfoDb();
            PagedModel pm = new PagedModel();
            string sql = db.GetPagingSql("admin_menu", "*", "idx desc", where, pageno, pagesize, "mysql");
            int icount = 0;
            sql = "select count(1) from `admin_menu` " + where;
            object obj = db.ExecuteScalar(sql);
            if (obj != null)
            {
                icount = int.Parse(obj.ToString());
            }

            pm.Data = db.QueryList<infopub_admin_menu>(sql);
            pm.Page = pageno;
            pm.Pagesize = pagesize;
            pm.TotalRecord = icount;
            return pm;
        }
    }
}
