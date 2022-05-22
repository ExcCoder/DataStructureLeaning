using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.SingleLink
{
    class SingleLinkedListDemo
    {
        public static void Main(String[] args)
        {
            StdNode stdNode1 = new StdNode(1,"joe","math");
            StdNode stdNode2 = new StdNode(2, "Mircal", "SoftwareEngineer");
            StdNode stdNode3 = new StdNode(3, "Kenewnew", "MathADNMedia");
            StdNode stdNode4 = new StdNode(4,"Mo","Computer");

            SingleLinkedListMassage list = new SingleLinkedListMassage();
            
            list.push(stdNode1);
            list.push(stdNode2);
            list.push(stdNode3);
            list.push(stdNode4);

            list.list();

        }
    }
}
