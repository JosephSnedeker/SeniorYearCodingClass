using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Stack<T>
    {
        List<int> holder = new List<int>();
        public Stack()
        {

        }
        //Push
        public void Push(int val)
        {
            holder.Add(val);
        }
        //Pop
        public int Pop()
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
                return holder[holder.Count - 1];
            }
            else
            {
                return -101010;
            }

        }
    }
}
