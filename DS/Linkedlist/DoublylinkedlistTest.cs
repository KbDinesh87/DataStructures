  using System.Collections.Generic;
  using System;
  namespace FAQ {
      public class DoublylinkedlistTest {
          public static void Test () {
              DoublyLinkedList d = new DoublyLinkedList ();
              DNode x = d.addAtStart (2);
              d.addAtStart (1);
              d.print ();
              d.addAtEnd (3);
              d.print ();
              d.addAfter (4, x);
              d.print ();
              d.deleteFromStart ();
              d.print ();
              Console.WriteLine ("Element at index 2: " + d.elementAt (2));
              d.addAtStart (1);
              d.print ();
              d.deleteFromEnd ();
              d.print ();
              Console.WriteLine ("Size of the Linked List: " + d.getSize ());
          }
      }
  }