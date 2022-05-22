using System;

namespace GraphDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> graph = new Graph<string>(5);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    graph.insertEdges(i, j, 0);
                }
            }
            graph.insertVertex("你好");
            graph.insertVertex("再见");
            graph.insertVertex("谢谢");
            graph.insertVertex("好的");
            graph.insertVertex("不客气");
            graph.insertEdges(0, 1, 1);
            graph.insertEdges(0, 2, 1);
            graph.insertEdges(1, 2, 1);
            graph.insertEdges(1, 3, 1);
            graph.insertEdges(1, 4, 1);


            graph.showDraph();
            
            graph.dfs();
            Console.WriteLine("\n广度优先");
            graph.bfs();


        }
    }
}
