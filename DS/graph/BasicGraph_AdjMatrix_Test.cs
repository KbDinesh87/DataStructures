using System;
using System.Collections.Generic;
namespace FAQ {
    public class BasicGraph_AdjMatrix_Test {
        public static void Test () {
            // create the graph given in above figure 
            int V = 5;
            GraphAdjMatrix graph = new GraphAdjMatrix (V);
            graph.addEdge (0, 1);
            graph.addEdge (0, 4);
            graph.addEdge (1, 2);
            graph.addEdge (1, 3);
            graph.addEdge (1, 4);
            graph.addEdge (2, 3);
            graph.addEdge (3, 4);
            graph.printGraph ();
        }
    }
}