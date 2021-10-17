using System;
using System.Collections.Generic;
using System.Text;

namespace TreeStructure
{
    public class Node<T>
    {
        public Node<T> parent;
        public T data;
        public List<Node<T>> children;

        public Node()
        {
            this.parent = null;
            this.data = default(T); //data of type T cannot be null 
        }

        public Node(Node<T> parent, T data)
        {
            this.parent = parent;
            this.data = data;
            this.children = new List<Node<T>>();
        }

        public void AddChild(Node<T> child)
        {
            this.children.Add(child);
        }
    }
}
