using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YueWen.Utility.Common;

namespace HJN.InfoPub.Core.Mode
{
    [Serializable]
    public class ZtreeSimpleMode
    {
        //{ id: 6, pId: 0, name: "福建省", open: true },
        public string id { get; set; }
        public string pId { get; set; }
        public string name { get; set; }
        public bool open { get; set; }
        public string val { get; set; }
        public static string ToJson(List<ZtreeSimpleMode> modelist)
        {
            return SerializeHelper.ToJson(modelist);
        }
    }
}
