using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GraphDemo
{
    class Graph<T>
    {
        #region 定义区
        List<T> vertexList; //存储顶点的集合
        //private ArrayList<string> vertexList;   
        private int[,] edges;  //存储图对应的邻接矩阵
        int weight;
        int numOfEdges; //表示边的数目
        bool[] isVisited;   //判断节点是否被访问

        //构造器
        public Graph(int n)
        {
            //初始化矩阵和vertexList
            edges = new int[n, n];
            vertexList = new List<T>(n);
            weight = 0;
            numOfEdges = 0;
        }
        #endregion
        #region 深度优先遍历算法
        //得到第一个节点的下标
        public int getFristNeighbor(int index)
        {
            for (int i = 0; i < edges.GetLength(0); i++)
            {
                //若下一个节点存在，返回对应的下标
                if (edges[index, i] > 0)
                {
                    return i;
                }
            }
            return -1;
        }
        //根据前一个节点的下标来获取下一个节点
        public int getNextNeighbor(int v1, int v2)
        {
            for (int i = v2+1; i < vertexList.Count; i++)
            {
                if (edges[v1, i] > 0)
                {
                    return i;
                }
            }
            //  Console.WriteLine("节点不存在");
            return -1;
        }
        //深度遍历算法
        //i第一次就是0
        public void dfs(bool[] isVisited, int i)
        {
            Console.Write(getValueBylIndex(i) + "->");
            //将该节点设置为已访问
            isVisited[i] = true;
            //查找节点i的第一个邻接点
            int w = getFristNeighbor(i);
            while (w != -1)
            {
                if (!isVisited[w])
                {
                    dfs(isVisited, w);
                }
                w = getNextNeighbor(i, w);
            }


        }
        public void dfs()
        {
            isVisited = new bool[edges.GetLength(0)];

            for (int i = 0; i < getNumOfVertex(); i++)
            {
                if (!isVisited[i])
                {
                    dfs(isVisited, i);
                }
            }
        }
        #endregion
        #region 图的基本实现
        //添加边
        public void insertEdges(int v1, int v2, int weight)
        {
            edges[v1, v2] = weight;
            edges[v2, v1] = weight;
            numOfEdges++;
        }
        //插入节点
        public void insertVertex(T vertex)
        {
            vertexList.Add(vertex);
        }
        //获取节点个数
        public int getNumOfVertex()
        {
            return vertexList.Count;
        }
        //获取节点边数      
        public int getNumOfEdges()
        {
            return numOfEdges;
        }
        //返回节点下标对应的数据
        public T getValueBylIndex(int i)
        {
            return vertexList[i];
        }
        //返回v1,v2的权值
        public int getWeight(int v1, int v2)
        {
            return edges[v1, v2];
        }
        //实现矩阵
        public void showDraph()
        {
            for (int i = 0; i < edges.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < edges.GetLength(1); j++)
                {
                    Console.Write(edges[i, j]+",");
                }
                Console.Write("]");

                Console.WriteLine();
            }
        }
        #endregion
        #region 图的广度优先遍历实现
        public void bfs(bool[] isvisited, int i)
        {
            int u;//队列下标
            int w;//邻接点
            //LinkedList<object> Queue = new LinkedList<object>();
            LinkedList<int> queue = new LinkedList<int>();
            //访问节点
            Console.Write(getValueBylIndex(i) + "->");
            isVisited[i] = true;
            queue.AddLast(i);
            while (queue.Count!=0)
            {
                
                //取出队列的头节点下标
                u = queue.First.Value;
                queue.RemoveFirst();
                //得到第一个邻接点的下标
                w = getFristNeighbor(u);
                while (w != -1)
                {
                    //是否访问过
                    if (!isvisited[w])
                    {
                        Console.Write(getValueBylIndex(w) + "->");
                        //标记已访问
                        isvisited[w] = true;
                        //入队
                        queue.AddLast(w);
                    }
                    w = getNextNeighbor(u, w);   //广度优先

                }
                //以u为前驱点找w后面的下一个邻接点
               // Console.WriteLine(u + "," + w + "---");


            }
        }
        //遍历所有节点进行广度优先搜索重载
        public void bfs()
        {
            isVisited = new bool[edges.GetLength(0)];

            for (int i = 0; i < getNumOfVertex(); i++)
            {
                if (!isVisited[i])
                {
                    bfs(isVisited, i);
                }
            }
        }
        #endregion
    }
}
