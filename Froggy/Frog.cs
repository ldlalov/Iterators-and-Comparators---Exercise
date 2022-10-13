using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy 
{
    public class Frog : IEnumerable<int>
    {
        public List<int> frogMoves = new List<int>();
        public int Possition  { get; set; } 
        public int JumpForward()
        {
            return Possition += 2;
        }
        public void JumpBackward()
        {
            Possition -= 2;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var move in frogMoves)
            {
                yield return move;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
