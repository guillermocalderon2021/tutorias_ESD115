using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoria5
{
    internal class Nodo
    {
        public int Item { get; set; }
        public Nodo Next { get; set; }
        public Nodo(int item)
        {
            this.Item = item;
            this.Next = null;
        }
        public Nodo(int item, Nodo next)
        {
            this.Item = item;
            this.Next = next;
        }
    }
}
