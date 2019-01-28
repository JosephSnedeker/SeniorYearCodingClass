using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueClass
{
    class Queue
    {
        List<int> holder = new List<int>();
        public Queue()
        {

        }
        //Push
        public void enQueue(int val)
        {
            holder.Add(val);
        }
        //Pop
        public int deQueue()
        {
            if (holder.Count != 0)
            {
                int x = holder[holder.Count - 1];
                holder.RemoveAt(holder.Count - 1);
                return x;
            }
            else
            {
                return -101010;
            }


        }
        //Peek
        public int Peek()
        {
            if (holder.Count != 0)
            {
                return holder[0];
            }
            else
            {
                return -101010;
            }

        }
        //Print
        public void Print()
        {
            for (int i = 0; i < holder.Count; i++)
            {
                Console.Write(holder[i]+ ", ");
            }
        }
        public List<int> Search(int val)
        {
            List<int> positions = new List<int>();
            for (int i = 0; i < holder.Count; i++)
            {
                if (val == holder[i])
                {
                    positions.Add(i);
                }
            }
            return positions;
        }
    }
}
