﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeDFS
{
    class DepthFirstSearch
    {

        public static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
    }


    public class Node
    {
        public Node left { get; set; }
        public Node right { get; set; }
        public int value { get; set; }

        public Node(int value)
        {
            this.left = null;
            this.right = null;
            this.value = value;
        }
    }

    class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            this.root = null;
        }

        public void insert(int value)
        {
            Node newNode = new Node(value);
            if (this.root == null)
            {
                this.root = newNode;
                return;
            }

            Node currentNode = this.root;
            while (true)
            {
                if (currentNode.value > value)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = new Node(value);
                        return;
                    }
                    currentNode = currentNode.left;
                }
                else
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = new Node(value);
                        return;
                    }
                    currentNode = currentNode.right;
                }
            }
        }

        public List<int> DFSInOrder()
        {
            List<int> result = new List<int>();
            traverseInOrder(this.root, result);
            return result;
        }

        public List<int> DFSPreOrder()
        {
            List<int> result = new List<int>();
            traversePreOrder(this.root, result);
            return result;
        }

        public List<int> DFSPostOrder()
        {
            List<int> result = new List<int>();
            traversePostOrder(this.root, result);
            return result;
        }

        public List<int> traverseInOrder(Node node, List<int> list)
        {
            if (node.left != null)
            {
                traverseInOrder(node.left, list);
            }
            list.Add(node.value);
            if (node.right != null)
            {
                traverseInOrder(node.right, list);
            }

            return list;
        }

        public List<int> traversePreOrder(Node node, List<int> list)
        {
            list.Add(node.value);
            if (node.left != null)
            {
                traversePreOrder(node.left, list);
            }

            if (node.right != null)
            {
                traversePreOrder(node.right, list);
            }

            return list;
        }

        public List<int> traversePostOrder(Node node, List<int> list)
        {
            if (node.left != null)
            {
                traversePostOrder(node.left, list);
            }

            if (node.right != null)
            {
                traversePostOrder(node.right, list);
            }
            list.Add(node.value);

            return list;
        }
    }
}
