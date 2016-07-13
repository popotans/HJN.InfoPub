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
        public int Success { get; set; }
        public string Code { get; set; }
        public string Msg { get; set; }

        public static BaseJsonResult BuildResult(int success, string code, string msg)
        {
            BaseJsonResult bjr = new BaseJsonResult { Code = code, Msg = msg, Success = success };
            return bjr;
        }
    }
}
