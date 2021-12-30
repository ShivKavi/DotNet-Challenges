using System;

namespace Algorithms {

    class Program {

        class Node {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

class BinarySearchTree {

            public static Boolean Contains(Node root, int value) {
                if (root == null) {
                    return false;
                } else if (value < root.Data) {
                    return Contains(root.Left, value);
                } else if (value > root.Data) {
                    return Contains(root.Right, value);
                } else {
                    return true;
                }
            }
            public static Node Insert(Node root, int value) {
                if (root == null) {
                    root = new Node();
                    root.Data = value;
                } else if (value < root.Data) {
                    root.Left = Insert(root.Left, value);
                } else if (value > root.Data) {
                    root.Right = Insert(root.Right, value);
                }

                return root;
            }
        }

        static void Main(string[] args) {
            Node rootNode = new Node();
            rootNode.Data = 2;

            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 5);
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 5));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, -2));
        }
    }
}