using System;
using System.Collections.Generic;
using System.Text;

namespace TreeStructure
{
    public class Tree<T>
    {
        public Node<T> root;

        public Tree()
        {
            root = null;
        }

        public Tree(T rootData)
        {
            this.root = new Node<T>(null, rootData);
        }

        //public void 
    }
}
