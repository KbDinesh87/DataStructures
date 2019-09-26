﻿using System;

namespace C_DataStructures {
    class Program {
        static void Main (string[] args) {
            FAQ.NullCheck.Test ();
            FAQ.SimpleInheritance.Test ();
            FAQ.Inheritance1.Test ();
            FAQ.OperatorOverload.Test ();
            FAQ.DelegateClosure.Test ();
            FAQ.GraphTest1.Test();
            FAQ.GraphTest2.Test();
            FAQ.BasicGraph_AdjList_Test.Test();
            FAQ.BasicGraph_AdjMatrix_Test.Test();
            Console.ReadLine ();
            Console.WriteLine ("Hello World!");
        }
    }
}