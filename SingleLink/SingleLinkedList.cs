using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class SingleLinkedListDemo
    {
        
        public static void DemoMain(String[] args )
        {
            //测试
            HeroNote heroNote1 = new HeroNote(1,"松江","及时雨");
            HeroNote heroNote2 = new HeroNote(2, "哈利波特", "魔法师");
            HeroNote heroNote3 = new HeroNote(3, "崩坏3", "刀刀致命");
            HeroNote heroNote4 = new HeroNote(4, "动漫", "最爱");
            SingleLinkedList SingleLink = new SingleLinkedList();
            SingleLink.add(heroNote1);
            SingleLink.add(heroNote2);
            SingleLink.add(heroNote3);
            SingleLink.add(heroNote4);
            SingleLink.list();


        }

    }
    }
    //定义一个单链表来管理英雄
    class SingleLinkedList
    {
    private HeroNote head = new HeroNote(1, "", "");
    public static void main(String[] args)
    {

    }
    /*
        添加节点到单项链表
        思路，当不考虑序号排序时
        1.找到当前链表的最后节点
        2.将最后这个节点的next指向新的节点
    */
    public void add(HeroNote heroNote)
    {
        HeroNote temp = head;
        //遍历链表，找到最后的节点
        while (true)
        {
            if (temp.next == null)
            {
                break;
            }
            //如果没有找到最后，链表后移
            temp = temp.next;
        }
        //将最后的节点指向新的节点
        temp.next = heroNote;
    }
    //显示链表
    public void list()
    {
        //判断链表是否为空
        if (head.next == null)
        {
            return;
        }
        HeroNote temp = head.next;
        //循环列表
        while (true)
        {
            //判断是否完成循环
            if (temp.next == null)
            {
                break;
            }
            Console.WriteLine(temp.no+temp.name+temp.nickName.ToString());
            //将temp后移
            temp = temp.next;
        }
    }
    
}
//定义HeroNote，每个HeroNote 对象就是一个节点
public class HeroNote
{
    public int no;
    public string name;
    public string nickName;
    public HeroNote next;

    public HeroNote(int no, string name, string nickName)
    {
        this.no = no;
        this.name = name;
        this.nickName = nickName;
    }
}
