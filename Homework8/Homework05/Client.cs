using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
     public class Client
    {
        public string Name{get;set;}
        public Client() { }
        public Client(string name) { Name = name; }
        public override string ToString()
        {
            return Name;
        }
    }
}
