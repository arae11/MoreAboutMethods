using System;

namespace MethodsApps
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = DoThis(10, "sad");
            //var result2 = DoThis(25);
            //var pizza1 = OrderPizza(pineapple: true, anchovies: true);
            //var myTuple = ("Joe", "Bloggs", 25);
            //Console.WriteLine(myTuple);
            //Console.WriteLine(myTuple.Item2);
            //var myNamedTuple = (fName: "Jane", lName: "Doe", age: 32);
            //Console.WriteLine(myNamedTuple.age);

            //var title = "The Shining";
            //int copies = 3;
            //var MyTuple3 = (title, copies);
            //Console.WriteLine(MyTuple3);
            //Console.WriteLine(MyTuple3.title);

            var weight = ConvertPoundsToStones(188);
            Console.WriteLine(weight);
        }

        public static (int stones, int pounds) ConvertPoundsToStones(int pounds)
        {
            const int poundsInAStone = 14;
            var st = pounds / poundsInAStone;
            var lbs = pounds % poundsInAStone;
            return (st, lbs); 
        }

        public static string OrderPizza(bool anchovies, bool pineapple, bool mushrooms = false)
        {
            var pizza = "Pizza with tomato sauce, cheese, ";
            if (anchovies) pizza += "anchovies, ";
            if (pineapple) pizza += "NO STOP IT NO PINEAPPLE, ";
            if (mushrooms) pizza += "mushrooms, ";
            return pizza;
        }
        public static int DoThis(int x, String y = "happy")
        {
            Console.WriteLine($"I'm feeling {y}");
            return x * x;
        }
    }
    
}
