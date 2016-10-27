
/* 
 本类由PWMIS 实体类生成工具(适用于 PWMIS.Core Version: 5.3 以上)自动生成
 http://www.pwmis.com/sqlmap
 使用前请先在项目工程中引用 PWMIS.Core.dll
 2016/10/21 20:25:35
*/

using System;
using PWMIS.Common;
using PWMIS.DataMap.Entity;

namespace HJN.InfoPub.Entity  
{
  [Serializable()]
  public partial class userinfo : EntityBase
  {
    public userinfo()
    {
            TableName = "userinfo";
            Schema="infopub";
            EntityMap=EntityMapType.Table;
            //IdentityName = "标识字段名";
    IdentityName="idx";

            //PrimaryKeys.Add("主键字段名");
    PrimaryKeys.Add("idx");

            
    }


      protected override void SetFieldNames()
      {
           PropertyNames = new string[] { "idx","name","email","userstate","qq","wx","isdelete","ip","createdate","nickname","gid" };
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
          set{setProperty("name",value ,10);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String email
      {
          get{return getProperty<System.String>("email");}
          set{setProperty("email",value ,50);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.Int32 userstate
      {
          get{return getProperty<System.Int32>("userstate");}
          set{setProperty("userstate",value );}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String qq
      {
          get{return getProperty<System.String>("qq");}
          set{setProperty("qq",value ,15);}
      }

      /// <summary>
      /// 
      /// </summary>
      public System.String wx
      {
          get{return getProperty<System.String>("wx");}
          set{setProperty("wx",value ,30);}
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
      public System.String ip
      {
          get{return getProperty<System.String>("ip");}
          set{setProperty("ip",value ,20);}
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
      public System.String nickname
      {
          get{return getProperty<System.String>("nickname");}
          set{setProperty("nickname",value ,10);}
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
