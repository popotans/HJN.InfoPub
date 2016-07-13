
/* 
 本类由PWMIS 实体类生成工具(适用于 PWMIS.Core Version: 5.3 以上)自动生成
 http://www.pwmis.com/sqlmap
 使用前请先在项目工程中引用 PWMIS.Core.dll
 2016/7/13 10:58:29
*/

using System;
using PWMIS.Common;
using PWMIS.DataMap.Entity;

namespace HJN.InfoPub.Entity 
{
  [Serializable()]
  public partial class infopub_admin_menu : EntityBase
  {
    public infopub_admin_menu()
    {
            TableName = "admin_menu";
            Schema="infopub";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="idx";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("idx");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "idx","name","gid","parentidx","parentgid","isdelete","url","disorder" };
      }



      /// <summary>
      /// 
      /// </summary>
      public System.Int32 idx
      {
          get{return getProperty<System.Int32>("idx");}
          set{setProperty("idx",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String name
      {
          get{return getProperty<System.String>("name");}
          set{setProperty("name",value ,20);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String gid
      {
          get{return getProperty<System.String>("gid");}
          set{setProperty("gid",value ,40);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 parentidx
      {
          get{return getProperty<System.Int32>("parentidx");}
          set{setProperty("parentidx",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String parentgid
      {
          get{return getProperty<System.String>("parentgid");}
          set{setProperty("parentgid",value ,40);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 isdelete
      {
          get{return getProperty<System.Int32>("isdelete");}
          set{setProperty("isdelete",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String url
      {
          get{return getProperty<System.String>("url");}
          set{setProperty("url",value ,100);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 disorder
      {
          get{return getProperty<System.Int32>("disorder");}
          set{setProperty("disorder",value );}
      }


  }
}
