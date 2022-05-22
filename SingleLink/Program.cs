using System;

namespace ConsoleApp5
{
    public class SparesArr
    {
        public void DemoMain()
        {
            int[,] Arry = new int[11, 11];
            for (int i = 0; i < Arry.GetLength(0); i++)
            {
                for (int j = 0; j < Arry.GetLength(1); j++)
                {
                    Arry[i, j] = 0;
                }
            }
            Arry[3, 4] = 13;
            Arry[4, 7] = 16;
            Arry[4, 5] = 12;
            //创建稀疏表
            int count = 0;
            for (int i = 0; i < Arry.GetLength(0); i++)
            {
                for (int j = 0; j < Arry.GetLength(1); j++)
                {
                    if (Arry[i,j] != 0)
                    {
                        count++;
                    }
                }
            }
            int[,] sum = new int[3, count+1];
            sum[0, 0] = 11;
            sum[1, 0] = 11;
            sum[2, 0] = 0;
            
            int col = 1;
            for (int i = 0; i < Arry.GetLength(0); i++)
            {
                for (int j = 0; j < Arry.GetLength(1); j++)
                {
                    if (Arry[i, j] != 0)
                    {
                        
                        sum[0,col] = i;
                        sum[1, col] = j;
                        sum[2, col] = Arry[i,j];
                        col = col + 1;
                    }
                }
            }
            for (int i = 0; i < sum.GetLength(1); i++)
            {
              Console.WriteLine(sum[0,i] + "---" + sum[1, i] + "---" + sum[2, i]);
            }
            Console.ReadKey();
        }
    }
}
