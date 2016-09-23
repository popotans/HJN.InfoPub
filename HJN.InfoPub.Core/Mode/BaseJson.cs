using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJN.InfoPub.Core.Mode
{
    [Serializable]
    public class BaseJsonResult
    {
        public int success { get; set; }
        public string code { get; set; }
        public string msg { get; set; }

        public static BaseJsonResult BuildResult(int success, string code, string msg)
        {
            BaseJsonResult bjr = new BaseJsonResult { code = code, msg = msg, success = success };
            return bjr;
        }
    }
}
