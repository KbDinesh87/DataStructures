using System;
using System.Collections.Generic;
namespace FAQ {
    public class Vertex<T> {
        private T data;
        private List<Vertex<T>> neighbors;

        public T Data {
            get { return data; }
            set { data = value; }
        }
        public List<Vertex<T>> Neighbors {
            get { return neighbors; }
            set { neighbors = value; }
        }
    }
    public class BasicGraph1<T> {
        public List<Vertex<T>> vertices;

        public void Print () {
            foreach (Vertex<T> vertex in vertices) {
                Console.WriteLine();
                Console.Write (vertex.Data);
                foreach (Vertex<T> neighbors in vertex.Neighbors) {
                    Console.Write ("-->");
                    Console.Write (neighbors.Data);
                }
            }
        }
    }

}