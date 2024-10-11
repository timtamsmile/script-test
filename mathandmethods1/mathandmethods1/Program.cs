using System.Numerics;

namespace mathandmethods1
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int total = 50;
            Console.WriteLine("your total started at:{0}", total);
            substract10();
            Console.WriteLine("your total is now:{0}", total); 
            substract10();
            Console.WriteLine("your total is now:{0}", total);
            substract10();
            Console.WriteLine("your total is now:{0}", total);
            substract10();
            Console.WriteLine("your total is now:{0}", total);



            void substract10()
        {
          total -= 10;
        }
        }
        

    }
}
