using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreLinkedLists {
    public class Node {
        public int data;
        public Node next;
        public Node(int d) {
            data = d;
            next = null;
        }
        public override string ToString() {
            return data.ToString();
        }
    }
    public class MoreLinkedLists {
        public Node RemoveDuplicates(Node head) {
            var nodes = new Stack<Node>();
            nodes.Push(head);
            var next = head.next;
            while (next != null) {
                if (nodes.Peek().data == next.data) {
                    nodes.Pop();
                }
                nodes.Push(next);
                next = next.next;
            }
            var ar = nodes.ToArray();
            for (int i = ar.Length - 1; i > 0; i--) {
                ar[i].next = ar[i - 1];
            }
            return ar[ar.Length - 1];
        }
        public Node Insert(Node head, int data) {
            Node p = new Node(data);
            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;
            }
            return head;
        }
        public static void Display(Node head) {
            Node start = head;
            while (start != null) {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        //static void Main(String[] args) {
        //    Node head = null;
        //    int T = Int32.Parse(Console.ReadLine());
        //    while (T-- > 0) {
        //        int data = Int32.Parse(Console.ReadLine());
        //        head = insert(head, data);
        //    }
        //    head = removeDuplicates(head);
        //    display(head);
        //}
    }
}
