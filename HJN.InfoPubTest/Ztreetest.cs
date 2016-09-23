using HJN.InfoPub.Core.Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJN.InfoPubTest
{
    class Ztreetest
    {

        public void DoRun()
        {
            ZtreeSimpleMode mode = new ZtreeSimpleMode()
            {
                id = "1",
                name = "id1",
                open = true,
                pId = "0"
            };
            ZtreeSimpleMode mode2 = new ZtreeSimpleMode()
            {
                id = "2",
                name = "id1",
                open = true,
                pId = "0"
            };

            ZtreeSimpleMode mode3 = new ZtreeSimpleMode()
            {
                id = "3",
                name = "id1",
                open = true,
                pId = "0"
            };

            List<ZtreeSimpleMode> list = new List<ZtreeSimpleMode>();
            list.Add(mode);
            list.Add(mode2);
            list.Add(mode3);

            string str = ZtreeSimpleMode.ToJson(list);
            Console.WriteLine(str);


        }
    }
}
