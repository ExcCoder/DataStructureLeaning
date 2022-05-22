using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.SingleLink
{
    class StdNode
    {
        public int ID;
        public string Name;
        public string Professional;
        public StdNode next;
        public StdNode(int id,string name,string professional)
        {
            this.ID = id;
            this.Name = name;
            this.Professional = professional;
        }
    }
}
