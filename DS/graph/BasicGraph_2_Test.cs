using System;
using System.Collections.Generic;
namespace FAQ {
    public class GraphTest2 {
        public static void Test () {
            BasicGraph1<string> graph1 = new BasicGraph1<string> ();

            Vertex<string> obj1 = new Vertex<string> () {
                Data = "Privacy.htm", Neighbors =
                new List<Vertex<string>> () {
                new Vertex<string> { Data = "Index.htm" },
                new Vertex<string> { Data = "About.htm" },
                }
            };

            Vertex<string> obj2 = new Vertex<string> () {
                Data = "People.aspx", Neighbors =
                new List<Vertex<string>> () { }
            };

            List<Vertex<string>> vertices = new List<Vertex<string>> ();
            vertices.Add (obj1);
            vertices.Add (obj2);

            graph1.vertices = vertices;

            graph1.Print ();
        }
    }
}