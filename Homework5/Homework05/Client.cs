using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
     class Client
    {
        public string Name{get;set;}
        public Client(string name) { Name = name; }
        public override string ToString()
        {
            return "      [客户："+Name+"]";
        }
    }
}
