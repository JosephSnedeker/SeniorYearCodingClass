using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards

{
    class Stack
         
    {
        List<Card> holder = new List<Card>();
        public Stack()
        {
             
        }
        //Push
        public void Build(Card val)
        {
            holder.Add(val);
        }
        //Pop
        public Card Draw()
        {
            if (holder.Count != 0)
            {
                Card x = holder[holder.Count - 1];
                holder.RemoveAt(holder.Count - 1);
                return x;
            }
            else
            {
                return new Card("joker", 1111);
            }
           
            
        }
        



    }


}
