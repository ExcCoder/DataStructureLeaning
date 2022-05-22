using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class MainProgram
    {
        public static void DemoMain()
        {
            ArrayQueue<string> queue = new ArrayQueue<string>(3);
            string input = "值1";
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("s(show)");
                Console.WriteLine("e(exit)");
                Console.WriteLine("a(add)");
                Console.WriteLine("g(get)");
                Console.WriteLine("h(head)");
                input = Console.ReadLine();
                switch (input)
                {
                    case "s": 
                        queue.showQuene(); 
                        break;
                    case "e":
                        loop = false;
                        break;
                    case "a":
                        Console.WriteLine("请输入一个元素");
                        queue.addQuene(Console.ReadLine());
                        break;
                    case "g":
                        Console.WriteLine(queue.getQuene());
                        
                        break;
                    case "h":
                        Console.WriteLine(queue.headQueue()); 
                        break;

                }




            }
        }
    }
}
