  using System.Collections.Generic;
  using System;
  namespace FAQ {
      public class SinglylinkedlistTest {
          public static void Test () {
              Singlylinkedlist singleList = new Singlylinkedlist ();
              singleList.addAtBegin (5);
              singleList.addAtBegin (15);
              singleList.addAtEnd (20);
              singleList.addAtEnd (21);
              singleList.deleteAtBegin ();
              singleList.deleteAtEnd ();
              singleList.addAtIndex (10, 2);
              singleList.addAtEnd (15);
              singleList.display ();
              Console.WriteLine ("\n Size of the list is: " + singleList.size);
              Console.WriteLine (" Element at 2nd position : " + singleList.elementAt (2));
              Console.WriteLine (" Searching element 20, location : " + singleList.search (15));
          }
      }
  }