using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ArrayQueue<T>
    {
        
        int maxSize;
        int front;
        int rear;
        T[] arr;
        public ArrayQueue(int arrMaxsize)
        {
            arr = new T[arrMaxsize];
            front = 0;
            rear = 0;
            maxSize = arrMaxsize;
        }
        public bool IsFull()
        {
            return (rear+1)%maxSize==front;
        }
        public bool isEmpty()
        {
            return rear == front;
        }
        public void addQuene(T obj)
        {
            if (IsFull())
            {
                Console.WriteLine("队列已满");
            }
            arr[rear] = obj;
            rear = (rear + 1) % maxSize;
        }
        public T getQuene() 
        {
            if (isEmpty())
            {
                Console.WriteLine("队列是空的");
                return default(T);
            }
            T value = arr[front];
           front= (front+1)%maxSize;
            return value;
        }
        public void showQuene()
        {
            if (isEmpty())
            {
                Console.WriteLine("队列是空的");
                return;
            }
            for (int i = front; i < front+size(); i++)
            {
                Console.WriteLine($"arr[{i%maxSize}]={arr[i%maxSize]}\n");
            }
        }
        public int size()
        {
            return (rear + maxSize - front) % maxSize;
        }
        public T headQueue() 
        {
            if (isEmpty())
            {
                Console.WriteLine("队列是空的");
                return default(T);
            }

            return arr[front + 1];
        }
    }
}
