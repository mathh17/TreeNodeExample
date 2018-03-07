using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeNodeTest
{
    public class Tree<T>
    {
        public TreeNode<T> root;

        public Tree(T value)
        {
            if (value != null)
            {
                this.root = new TreeNode<T>(value);
            }
        }
        public void BreadthFirstSearch()
        {
            //Create new queue
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            //Put root in queue
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                TreeNode<T> v = queue.Dequeue();
                Console.WriteLine(v.value);
                foreach (TreeNode<T> c in v.children)
                {
                    queue.Enqueue(c);
                }
            }
        }

        public void DepthFirstSearch()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            stack.Push(root);
            while (stack.Count != 0)
            {
                TreeNode<T> v = stack.Pop();
                Console.WriteLine(v.value);
                foreach (TreeNode<T> c in v.children)
                {
                    stack.Push(c);
                }

            }
        }

    }

    public class TreeNode<T>
    {
        public T value;
        public bool hasParent;
        public List<TreeNode<T>> children;

        public TreeNode(T value)
        {
            if (value != null)
            {
                this.value = value;
                this.children = new List<TreeNode<T>>();
            }
        }

        public void AddChild(TreeNode<T> child)
        {
            child.hasParent = true;
            this.children.Add(child);
        }
        public TreeNode<T> GetChild(int index)
        {
            return children[index];
        }
    }

    


    class Program
    {
        static void Main(string[] args)
        {

            Tree<int> tree = new Tree<int>(5);
            TreeNode<int> three = new TreeNode<int>(8);
            TreeNode<int> ten = new TreeNode<int>(10);
            TreeNode<int> one = new TreeNode<int>(9);
            TreeNode<int> six = new TreeNode<int>(3);
            TreeNode<int> fourteen = new TreeNode<int>(4);
            TreeNode<int> four = new TreeNode<int>(15);
            TreeNode<int> seven = new TreeNode<int>(17);
            TreeNode<int> thirteen = new TreeNode<int>(3);

            tree.root.AddChild(three);
            tree.root.AddChild(ten);
            three.AddChild(one);
            three.AddChild(six);
            six.AddChild(four);
            six.AddChild(seven);
            ten.AddChild(fourteen);
            fourteen.AddChild(thirteen);

            Console.WriteLine("To print the trees write either:");
            Console.WriteLine("");
            Console.WriteLine("'BFS' to get the BreathFirstSearch");
            Console.WriteLine("'DFS to get the DepthFirstSearch");

            while (true)
            {

                switch (Console.ReadLine())
                {
                    case "BFS":
                        tree.BreadthFirstSearch();
                        break;

                    case "DFS":
                        tree.DepthFirstSearch();
                        break;
                }
            }

        }

    }
    
}
