using System.Numerics;

namespace mathandmethods1
{

    internal class Program
    {

        static void Main(string[] args)
        {
            int points = 20;
            Console.WriteLine("your point total started at:{0}", points);
            addfive();
            Console.WriteLine("your point total is now:{0}", points);
            addfive();
            Console.WriteLine("your point total is now:{0}", points);
            addfive(); 
            Console.WriteLine("your point total is now:{0}", points);
            addfive();
            Console.WriteLine("your point total is now:{0}", points);
            addfive();
            Console.WriteLine("your point total is now:{0}", points);
            addfive();
            Console.WriteLine("your point total is now:{0}", points);


            void addfive()
            {
                points += 5;
            }   
        }


    }
}
