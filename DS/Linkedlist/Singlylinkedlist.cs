using System;
using System.Collections.Generic;
namespace FAQ {

    public class Node {
        public int data;
        public Node next;

        public Node (int data) {
            this.data = data;
            this.next = null;
        }
    }

    // BASED ON - https://algorithms.tutorialhorizon.com/singly-linked-list-implementation/
    public class Singlylinkedlist {
        public Node head;
        public int size;
        public Singlylinkedlist () {
            head = null;
        }
        public void addAtBegin (int data) {
            Node n = new Node (data);            
            n.next = head;
            head = n;
            size++;
        }
        public int deleteAtBegin () {
            int tmp = head.data;
            head = head.next;
            size--;
            return tmp;
        }
        public void deleteAtEnd () {
            Node currNode = head;
            if (head.next == null) {
                head = null;
            } else {
                while (currNode.next.next != null) {
                    currNode = currNode.next;
                }
                int temp = currNode.next.data;
                currNode.next = null;
                size--;
            }
        }
        public void addAtEnd (int data) {
            if (head == null) {
                addAtBegin (data);
            } else {
                Node n = new Node (data);
                Node currNode = head;
                while (currNode.next != null) {
                    currNode = currNode.next;
                }
                currNode.next = n;
                size++;
            }
        }
        public int elementAt (int index) {
            if (index > size) {
                return -1;
            }
            Node n = head;
            while (index - 1 != 0) {
                n = n.next;
                index--;
            }
            return n.data;
        }
        public int getSize () {
            return size;
        }
        public int search (int data) {
            Node n = head;
            int count = 1;
            while (n != null) {
                if (n.data == data) {
                    return count;
                } else {
                    n = n.next;
                    count++;
                }
            }
            return -1;
        }
        public void addAtIndex (int data, int position) {
            if (position == 1) {
                addAtBegin (data);
            }
            int len = size;
            if (position > len + 1 || position < 1) {
                Console.WriteLine ("\nINVALID POSITION");
            }
            if (position == len + 1) {
                addAtEnd (data);
            }
            if (position <= len && position > 1) {
                Node n = new Node (data);
                Node currNode = head; //so index is already 1
                while ((position - 2) > 0) {
                    Console.WriteLine (currNode.data);
                    currNode = currNode.next;
                    position--;
                }
                n.next = currNode.next;
                currNode.next = n;
                size++;
            }
        }
        public void display () {
            Console.WriteLine ("");
            Node currNode = head;
            while (currNode != null) {
                Console.WriteLine ("->" + currNode.data);
                currNode = currNode.next;
            }
        }
    }
}