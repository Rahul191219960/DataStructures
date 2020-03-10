using System;
using EmployeeN;
namespace DataStructures
{
    public class BinaryTree<T> where T : Employee
    {
        private BinaryTree<T> Left { get; set; }
        private BinaryTree<T> Right { get; set; }
        private BinaryTree<T> Root { get; set; }
        private BinaryTree<T> Parent { get; set; }

        private T data { get; set; }

        public BinaryTree()
        {
            this.Root = null;
            this.Parent = null;
        }

        private BinaryTree<T> GetRoot()
        {
            return this.Root;
        }

        public bool Search(T val)
        {
            BinaryTree<T> current = GetRoot();
            while (true)
            {
                if (current.data == val)
                    return true;
                else if (val <= current.data)
                    current = current.Left;
                else if (val > current.data)
                    current = current.Right;
                if (current == null)
                    return false;
            }
        }

        private BinaryTree<T> InternalSearch(T val)
        {
            BinaryTree<T> current = GetRoot();
            while (true)
            {
                if (current.data == val)
                    return current;
                else if (val <= current.data)
                    current = current.Left;
                else if (val > current.data)
                    current = current.Right;
                if (current == null)
                    return null;
            }
        }

        public T GetParent(T val)
        {
            BinaryTree<T> isPresent = InternalSearch(val);
            if (isPresent == null || isPresent.Parent == null)
                return null;
            else
                return isPresent.Parent.data;

        }

        public bool AddChild(T myChild)
        {
            try
            {
                if (this.Root == null)
                {
                    BinaryTree<T> node = new BinaryTree<T>();
                    node.data = myChild;
                    this.Root = node;
                    return true;
                }
                else
                {
                    BinaryTree<T> current = GetRoot();
                    while (current.Left != null || current.Right != null)
                    {
                        if (myChild <= current.data)
                        {
                            if (current.Left == null)
                                break;
                            current = current.Left;
                        }
                        else if (myChild > current.data)
                        {
                            if (current.Right == null)
                                break;
                            current = current.Right;
                        }
                    }
                    if (myChild <= current.data)
                    {
                        BinaryTree<T> newNode = new BinaryTree<T>();
                        newNode.data = myChild;
                        current.Left = newNode;
                        newNode.Parent = current;
                    }
                    else if (myChild > current.data)
                    {
                        BinaryTree<T> newNode = new BinaryTree<T>();
                        newNode.data = myChild;
                        current.Right = newNode;
                        newNode.Parent = current;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}