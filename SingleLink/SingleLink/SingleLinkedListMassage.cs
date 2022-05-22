using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.SingleLink
{
    class SingleLinkedListMassage
    {
        StdNode head = new StdNode(0, "", "");
        /// <summary>
        /// 添加链表
        /// </summary>
        /// <param name="stdNode"></param>
        public void push(StdNode stdNode)
        {
            StdNode temp = head;
            while (true)
            {
                if (temp.next == null)
                {
                    break;
                }
                temp = temp.next;
            }
            temp.next = stdNode;
        }
        /// <summary>
        /// 遍历显示链表
        /// </summary>
        public void list()
        {
            StdNode temp = head;
            if (head.next == null)
            {
                Console.WriteLine("该列表为空");
            }
            while (true)
            {
                if (temp.next == null)
                {
                    break;
                }
                Console.WriteLine(temp.ID + temp.Name + temp.Professional);
                temp = temp.next;
            }
        }
        public void update(StdNode newStdNode)
        {
            StdNode temp = head.next;
            bool flag = false;
            while (true)
            {
                if (temp == null)
                {
                    break;
                }
                if (temp.ID == newStdNode.ID)
                {
                    flag = true;
                }
                if (flag)
                {
                    temp.Name = newStdNode.Name;
                    temp.Professional = newStdNode.Professional;
                }
                else
                {
                    Console.WriteLine("没用找到");
                }
            }
        }
        /// <summary>
        /// 根据排名将英雄插入到指定位置
        /// </summary>
        /// <param name="StdNode"></param>
        public void addByOrder(StdNode StdNode)
        {
            StdNode temp = head;
            bool flag = false;  //flag标志添加的编号是否存在，默认为False
            while (true)
            {
                if (temp.next == null)//说明temp已经添加到表后
                {
                    break;
                }
                if (temp.next.ID > StdNode.ID)//位置找到，在temp的后面插入
                {
                    break;
                }
                else if (temp.next.ID == StdNode.ID)//希望添加的ID已然存在
                {
                    flag = true;//说明编号存在
                }
                temp = temp.next;//遍历当前链表
            }
            //判断flag的值
            if (flag)//不能添加，因为编号存在
            {
                Console.WriteLine("不能添加，因为英雄的编号已经存在，不能加入");
            }
            else
            {
                //插入到链表中，temp后
                StdNode.next = temp.next;
                temp.next = StdNode;
            }
        }
    }
}
