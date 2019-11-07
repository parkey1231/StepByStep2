using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericity
{
    class Queue<T>
    {
        private const int DEFAULTQUEUESIZE = 100;
        private T[] data;
        private int head = 0;//插入数据位置
        private int tail = 0;//取出数据位置
        private int numElements = 0;

        public Queue()
        {
            this.data = new T[DEFAULTQUEUESIZE];
        }

        public Queue(int size)
        {
            if (size > 0)
            {
                this.data = new T[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Size", "Must be greater than zero");
            }
        }

        public void Enqueer(T item)
        {
            if (this.numElements == this.data.Length)
            {
                throw new Exception("Queue full");
            }

            this.data[this.head] = item;
            this.head++;
            this.head %= this.data.Length;
            this.numElements++;
        }

        public T Dequeue()
        {
            if (this.numElements == 0)
            {
                throw new Exception("Queue empty");
            }
            this.tail = numElements-1;
            T queueItem = this.data[this.tail];
            this.tail++;
            this.tail %= this.data.Length;
            this.numElements--;
            return queueItem;
        }
    }
}
