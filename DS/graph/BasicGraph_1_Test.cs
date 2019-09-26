using System;
using System.Collections.Generic;
namespace FAQ {
    // BASED ON - https://introprogramming.info/tag/graph-implementation/#_Toc362296541
    public class GraphTest1 {
        static int size = 7;
        static bool[] visited = new bool[size];
        static BasicGraph graph;
        public static void Test () {

            List<string> strs = new List<string> { "Demo List", "List 123" };

            List<int>[] list = new List<int>[size];

            list[0] = new List<int> () { 4 };
            list[1] = new List<int> () { 1, 2, 6 };
            list[2] = new List<int> () { 1, 6 };
            list[3] = new List<int> () { 6 };
            list[4] = new List<int> () { 0 };
            list[5] = new List<int> () { };
            list[6] = new List<int> () { 1, 2, 3 };

            graph = new BasicGraph (list);

            Console.WriteLine ("Connected graph components: ");

            for (int v = 0; v < graph.Size; v++) {
                if (!visited[v]) {
                    TraverseDFS (v);
                    Console.WriteLine ();
                }
            }
        }

        static void TraverseDFS (int v) {
            if (!visited[v]) {
                Console.Write (v + " ");
                visited[v] = true;
                foreach (int child in graph.GetSuccessors (v)) {
                    TraverseDFS (child);
                }
            }
        }
    }

  
}