using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJN.InfoPub.Core.IDao
{
    public interface IBaseDao<T> : IIoc
    {
        int Add(T t);
        int Update(T t);
        int Delete(T t);
       
        int Add(string sql, params IDataParameter[] paras);
        int Update(string sql, params IDataParameter[] paras);
        int Delete(string sql, params IDataParameter[] paras);

        PagedModel GetPagedList<T>(int pageno, int pagesize, string tablename, string columns, string wherecolumn, string orderby);
        PagedModel GetPagedListDataTable(int pageno, int pagesize, string tablename, string columns, string wherecolumn, string orderby);

        string GetMyType(T t);
    }

    public interface IIoc { }
}
