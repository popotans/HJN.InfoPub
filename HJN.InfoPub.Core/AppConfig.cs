using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YueWen.Utility.Common;
using System.Xml;
namespace HJN.InfoPub.Core
{
    public class AppConfig : Singleton<AppConfig>
    {
        private XmlElement Root;
        private AppConfig()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.BaseDirectory + "\\config\\app.config");
            Root = doc.DocumentElement;
        }

        public string GetByKey(string key)
        {
            string rs = "";

            XmlNode xn = Root.SelectSingleNode("appSettings/add[@key='" + key + "']");
            if (xn == null)
            {
                xn = Root.SelectSingleNode("appSettings/" + key);
                if (xn != null) rs = xn.InnerText;
            }
            else
                rs = xn.Attributes["value"].Value;
            return rs;
        }

    }
}
