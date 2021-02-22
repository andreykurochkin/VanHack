using System;

namespace BinarySearchTrees {
    public class Node {
        public Node left, right;
        public int data;
        public Node(int data) {
            this.data = data;
            left = right = null;
        }
        public override string ToString() {
            return data.ToString();
        }
    }
    public class BinarySearchTrees {
        public int GetHeight(Node root) {
            //Write your code here
            if (root == null) {
                return -1;
            }
            int leftHeight = GetHeight(root.left);
            int rightHeight = GetHeight(root.right);
            if (leftHeight > rightHeight) {
                return leftHeight + 1;
            } else {
                return rightHeight + 1;
            }
        }
        public Node Insert(Node root, int data) {
            if (root == null) {
                return new Node(data);
            } else {
                Node cur;
                if (data <= root.data) {
                    cur = Insert(root.left, data);
                    root.left = cur;
                } else {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        public Node AlterInsert(Node root, int data) {
            if (root == null) {
                root = new Node(data);
            } else {
                if (data <= root.data) {
                    root.left = Insert(root.left, data);
                } else {
                    root.right = Insert(root.left, data);
                }
            }
            return root;
        }
    }
}

//class Solution {
//    static void Main(String[] args) {
//        Node root = null;
//        int T = Int32.Parse(Console.ReadLine());
//        while (T-- > 0) {
//            int data = Int32.Parse(Console.ReadLine());
//            root = insert(root, data);
//        }
//        int height = getHeight(root);
//        Console.WriteLine(height);

//    }
//}