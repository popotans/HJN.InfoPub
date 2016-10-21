using FluentValidation.Results;
using HJN.InfoPub.Core.IDao;
using HJN.InfoPub.Core.Mode;
using HJN.InfoPub.Core.Validate;
using HJN.InfoPub.Entity;
using PWMIS.Core.YueWen.DataProvider;
using PWMIS.DataMap.Entity;
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

        public int Add(admin_menu menuentity)
        {
            MenuValidator.CreateInstance().DoValidate(menuentity);

            YwDb db = DbContext.GetInfoDb();
            return db.Insert(menuentity);
        }

        public int Update(admin_menu menuentity)
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

        public admin_menu Get(int idx)
        {
            YwDb db = DbContext.GetInfoDb();
            string sql = "select * from admin_menu where idx=" + idx;
            return db.QueryObject<admin_menu>(sql);
        }

        public PagedModel GetList(int pageno, int pagesize, string where)
        {
            YwDb db = DbContext.GetInfoDb();
            PagedModel pm = new PagedModel();
            string sql = db.GetPagingSql("admin_menu", "*", " idx desc ", where, pageno, pagesize, "mysql");
            pm.Data = db.QueryList<admin_menu>(sql);
            int icount = 0;
            sql = "select count(1) from `admin_menu`  where  " + where;
            object obj = db.ExecuteScalar(sql);
            if (obj != null)
            {
                icount = int.Parse(obj.ToString());
            }

            pm.Page = pageno;
            pm.Pagesize = pagesize;
            pm.TotalRecord = icount;
            return pm;
        }

        public List<admin_menu> GetAll()
        {
            admin_menu menu = new admin_menu();
            OQL oql = OQL.From(menu)
                .Select().OrderBy(menu.idx).END;
            YwDb db = DbContext.GetInfoDb();
            var list = EntityQuery<admin_menu>.QueryList(oql, db);
            return list;
        }


        public string GetZtreeMenuData4Parent(int idx)
        {
            var list = GetAll().Where(x => x.idx != idx);
            List<ZtreeSimpleMode> zlist = new List<ZtreeSimpleMode>();
            foreach (var item in list)
            {
                ZtreeSimpleMode mode = new ZtreeSimpleMode { val = item.idx.ToString(), pId = item.parentidx.ToString(), open = true, name = item.name, id = item.idx.ToString() };
                zlist.Add(mode);
            }

            zlist.Add(new ZtreeSimpleMode { val = "0", pId = "0", open = true, name = "顶级分类", id = "0" });
            //zlist.Add(new ZtreeSimpleMode { val = "999", pId = "3", open = true, name = "999", id = "999" });
            //zlist.Add(new ZtreeSimpleMode { val = "77", pId = "7", open = true, name = "77", id = "77" });
            return ZtreeSimpleMode.ToJson(zlist);
        }
    }
}
