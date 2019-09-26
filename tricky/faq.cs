using System;
using System.Collections.Generic;
namespace FAQ {

    #region Check Null Values
    public class NullCheck {
        static String str;
        static DateTime time;
        public static void Test () {
            Console.WriteLine (str == null ? "str == null" : str);
            Console.WriteLine (time == null ? "time == null" : time.ToString ());
        }
    }
    #endregion
    #region Check simple inheritance
    class A {
        public void abc (int q) {
            Console.WriteLine ("abc from A");
        }
    }

    class B : A {
        public void abc (double p) {
            Console.WriteLine ("abc from B");
        }
    }

    public class SimpleInheritance {
        public static void Test () {
            int i = 5;
            B b = new B ();
            b.abc (i);
        }
    }
    #endregion
    #region A typical polymorphism understanding 
    class Inheritance1 {
        public static void Test () {
            MyClassB b = new MyClassB ();
            MyClassA a = b;
            a.abc ();
            b.abc ();
        }
    }

    class MyClassA {
        public MyClassA () {
            Console.WriteLine ("constructor A");
        }

        public void abc () {
            Console.WriteLine ("A");
        }
    }

    class MyClassB : MyClassA {
        public MyClassB () {
            Console.WriteLine ("constructor B");
        }

        new public void abc () {
            Console.WriteLine ("B");
        }
    }
    #endregion
    #region OperatorOverloading
    public class Point {
        public int X { get; set; }
        public int Y { get; set; }
        public Point (int xPos, int yPos) {
            X = xPos;
            Y = yPos;
        }

        public static Point operator + (Point p1, Point p2) {
            return new Point (p1.X + p2.X, p1.Y + p2.Y);
        }
        public static Point operator * (Point p1, Point p2) {
            return new Point (p1.X * p2.X, p1.Y * p2.Y);
        }
    }
    public class OperatorOverload {
        public static void Test () {
            Point ptOne = new Point (15, 20);
            Point ptTwo = new Point (40, 50);
            Point ptThree = ptOne + ptTwo; //It will throw error if we remove line 74
        }
    }
    #endregion
    #region Delegate Closure
    public class DelegateClosure {
        delegate void SomeMethod ();
        public static void Test () {
            List<SomeMethod> delList = new List<SomeMethod> ();
            for (int i = 0; i < 10; i++) {
                delList.Add (delegate { Console.WriteLine (i); });
                //OR --> delList.Add (() => { Console.WriteLine (i); });
            }

            foreach (var del in delList) {
                del ();
            }
        }
    }
    #endregion
}