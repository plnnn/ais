using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bebra
{
    public class Group
    {
        public string ID { get; private set; }
        public string code { get; private set; }

        public Group(string ID, string code)
        {
            this.ID = ID;
            this.code = code;
        }

        public string getCode() { return code; }
    }
}
