using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Swap
{
    public class Node<T>
    {
        T data;
        Node<T> link;

        public Node(T data, Node<T> element)
        {
            this.data = data;
            this.link = element;
        }

        public override string ToString()
        {
            return string.Format("data: {0}", data.ToString());
        }
    }
}
