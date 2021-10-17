using System;

namespace TreeStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<string> amazon = new Tree<string>("CEO: Jeff Bezos");

            Console.WriteLine(amazon.root.data + " - reports to " + amazon.root.parent);

            amazon.root.children.Add(new Node<string>(amazon.root, "SVP eCommerce: Brian Valentine"));
            amazon.root.children.Add(new Node<string>(amazon.root, "AWS CEO: Andy Jassy"));
            amazon.root.children.Add(new Node<string>(amazon.root, "SVP Corporate: Jeff Blackburn"));

            Node<string> awsCeo = amazon.root.children[1];
            awsCeo.children.Add(new Node<string>(awsCeo, "AWS CFO: Luis Visoso"));

            foreach (Node<string> l1Exec in amazon.root.children)
            {
                Console.WriteLine("  " + l1Exec.data + " - reports to " + l1Exec.parent.data);
                
                foreach(Node<string> l2Exec in l1Exec.children)
                {
                    Console.WriteLine("    " + l2Exec.data + " - reports to " + l2Exec.data);
                }
            }

            
        }
    }
}
