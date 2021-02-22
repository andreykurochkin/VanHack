using System;

namespace LinkedList {
    public class Program {
        public static void Main(string[] args) {
            Node head = null;
            for (int i = 0; i < args.Length; i++) {
                head = Insert(head, int.Parse(args[i]));
            }
            Display(head);
        }
        public static Node Insert(Node head, int data) {
            //Complete this method
            if (head == null) {
                head = new Node(data);
                return head;
            }
            
            var start = head;
            while (start.next != null) {
                start = start.next;
            }
            start.next = new Node(data);
            return head;
        }

        public static void Display(Node head) {
            Node start = head;
            while (start != null) {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
    public class Node {
        public int data;
        public Node next;
        public Node(int d) {
            data = d;
            next = null;
        }
    }
}