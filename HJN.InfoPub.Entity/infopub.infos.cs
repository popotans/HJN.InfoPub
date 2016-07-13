
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
  public partial class infopub_infos : EntityBase
  {
    public infopub_infos()
    {
            TableName = "infos";
            Schema="infopub";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="idx";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("idx");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "idx","name","userid","shortcontent","createdate","updatedate","url","clickcount","istop","topenddatetime","topstartdatetime","catid","creatorpwd","creatoremail","provinceid","cityid","ztai","gid" };
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
          set{setProperty("name",value ,30);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 userid
      {
          get{return getProperty<System.Int32>("userid");}
          set{setProperty("userid",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String shortcontent
      {
          get{return getProperty<System.String>("shortcontent");}
          set{setProperty("shortcontent",value ,200);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime createdate
      {
          get{return getProperty<System.DateTime>("createdate");}
          set{setProperty("createdate",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime updatedate
      {
          get{return getProperty<System.DateTime>("updatedate");}
          set{setProperty("updatedate",value );}
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
      public System.Int32 clickcount
      {
          get{return getProperty<System.Int32>("clickcount");}
          set{setProperty("clickcount",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 istop
      {
          get{return getProperty<System.Int32>("istop");}
          set{setProperty("istop",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime topenddatetime
      {
          get{return getProperty<System.DateTime>("topenddatetime");}
          set{setProperty("topenddatetime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.DateTime topstartdatetime
      {
          get{return getProperty<System.DateTime>("topstartdatetime");}
          set{setProperty("topstartdatetime",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 catid
      {
          get{return getProperty<System.Int32>("catid");}
          set{setProperty("catid",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String creatorpwd
      {
          get{return getProperty<System.String>("creatorpwd");}
          set{setProperty("creatorpwd",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String creatoremail
      {
          get{return getProperty<System.String>("creatoremail");}
          set{setProperty("creatoremail",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 provinceid
      {
          get{return getProperty<System.Int32>("provinceid");}
          set{setProperty("provinceid",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 cityid
      {
          get{return getProperty<System.Int32>("cityid");}
          set{setProperty("cityid",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 ztai
      {
          get{return getProperty<System.Int32>("ztai");}
          set{setProperty("ztai",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String gid
      {
          get{return getProperty<System.String>("gid");}
          set{setProperty("gid",value ,40);}
      }


  }
}
