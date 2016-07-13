using HJN.InfoPub.Core;
using HJN.InfoPub.Core.IDao;
using PWMIS.Core.YueWen.DataProvider;
using PWMIS.DataMap.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJN.InfoPub.MySql.DaoImpl
{
    public class BaseDaoImpl<T> : IBaseDao<T> where T : EntityBase
    {
        public int Add(T t)
        {
            YwDb db = DbContext.GetInfoDb();
            return db.Insert(t);
        }

        public int Update(T t)
        {
            YwDb db = DbContext.GetInfoDb();
            return db.Update(t);
        }

        public int Delete(T t)
        {
            YwDb db = DbContext.GetInfoDb();
            return db.Delete(t);
        }

        public int Add(string sql, params System.Data.IDataParameter[] paras)
        {
            return ExecuteNonQuery(sql, paras);
        }

        public int Update(string sql, params System.Data.IDataParameter[] paras)
        {
            return ExecuteNonQuery(sql, paras);
        }

        public int Delete(string sql, params System.Data.IDataParameter[] paras)
        {
            return ExecuteNonQuery(sql, paras);
        }

        public int ExecuteNonQuery(string sql, params System.Data.IDataParameter[] paras)
        {
            YwDb db = DbContext.GetInfoDb();
            return db.ExecuteNonQuery(sql, CommandType.Text, paras);
        }

        public PagedModel GetPagedListDataTable(int pageno, int pagesize, string tablename, string columns, string wherecolumn, string orderby)
        {
            YwDb db = DbContext.GetInfoDb();
            PagedModel pm = new PagedModel();
            string sql = db.GetPagingSql(tablename, columns, orderby, wherecolumn, pageno, pagesize, "mysql");
            DataTable dt = db.ExecuteDataTable(sql);

            int icount = 0;
            sql = "select count(1) from `" + tablename + "` " + wherecolumn;
            object obj = db.ExecuteScalar(sql);
            if (obj != null)
            {
                icount = int.Parse(obj.ToString());
            }
            pm.Data = dt;
            pm.Page = pageno;
            pm.Pagesize = pagesize;
            pm.TotalRecord = icount;
            return pm;
        }

        public PagedModel GetPagedList<T>(int pageno, int pagesize, string tablename, string columns, string wherecolumn, string orderby)
        {
            YwDb db = DbContext.GetInfoDb();
            PagedModel pm = new PagedModel();
            string sql = db.GetPagingSql(tablename, columns, orderby, wherecolumn, pageno, pagesize, "mysql");
            var dt = db.QueryListView<T>(sql);

            int icount = 0;
            sql = "select count(1) from `" + tablename + "` " + wherecolumn;
            object obj = db.ExecuteScalar(sql);
            if (obj != null)
            {
                icount = int.Parse(obj.ToString());
            }
            pm.Data = dt;
            pm.Page = pageno;
            pm.Pagesize = pagesize;
            pm.TotalRecord = icount;
            return pm;
        }


        public string GetMyType(T t)
        {
            throw new NotImplementedException();
        }
    }
}
