using System;
using System.Collections.Generic;
namespace FAQ {
    public class DNode {
        public int data;
        public DNode next;
        public DNode previous;
        public DNode (int data) {
            this.data = data;
            next = null;
            previous = null;
        }
    }
    public class DoublyLinkedList {
        int size = 0;
        DNode head = null;
        DNode tail = null;

        public DNode addAtStart (int data) {
            Console.WriteLine ("Adding DNode " + data + " at the start");
            DNode n = new DNode (data);
            if (size == 0) {
                head = n;
                tail = n;
            } else {
                n.next = head;
                head.previous = n;
                head = n;
            }
            size++;
            return n;
        }

        public DNode addAtEnd (int data) {
            Console.WriteLine ("Adding DNode " + data + " at the End");
            DNode n = new DNode (data);
            if (size == 0) {
                head = n;
                tail = n;
            } else {
                tail.next = n;
                n.previous = tail;
                tail = n;
            }
            size++;
            return n;
        }

        public DNode addAfter (int data, DNode prevNode) {
            if (prevNode == null) {
                Console.WriteLine ("DNode after which new DNode to be added cannot be null");
                return null;
            } else if (prevNode == tail) { //check if it a last DNode
                return addAtEnd (data);
            } else {
                Console.WriteLine ("Adding DNode after " + prevNode.data);
                //create a new DNode
                DNode n = new DNode (data);

                //store the next DNode of prevNode
                DNode nextNode = prevNode.next;

                //make new DNode next points to prevNode
                n.next = nextNode;

                //make prevNode next points to new DNode
                prevNode.next = n;

                //make nextNode previous points to new DNode
                nextNode.previous = n;

                //make  new DNode previous points to prevNode
                n.previous = prevNode;
                size++;
                return n;
            }
        }

        public void deleteFromStart () {
            if (size == 0) {
                Console.WriteLine ("\nList is Empty");
            } else {
                Console.WriteLine ("\ndeleting DNode " + head.data + " from start");
                head = head.next;
                size--;
            }
        }

        public void deleteFromEnd () {
            if (size == 0) {
                Console.WriteLine ("\nList is Empty");
            } else if (size == 1) {
                deleteFromStart ();
            } else {
                //store the 2nd last DNode
                int x = tail.data;
                DNode prevTail = tail.previous;

                //detach the last DNode
                tail = prevTail;
                tail.next = null;
                Console.WriteLine ("\ndeleting DNode " + x + " from end");
                size--;
            }
        }

        public int elementAt (int index) {
            if (index > size) {
                return -1;
            }
            DNode n = head;
            while (index - 1 != 0) {
                n = n.next;
                index--;
            }
            return n.data;
        }

        //get Size
        public int getSize () {
            return size;
        }

        public void print () {
            DNode temp = head;
            Console.WriteLine ("Doubly Linked List: ");
            while (temp != null) {
                Console.WriteLine (" " + temp.data);
                temp = temp.next;
            }
            Console.WriteLine ();
        }

    }
}