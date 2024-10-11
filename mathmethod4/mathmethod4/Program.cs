namespace mathandmethods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialspeed = 120;
            int decelaration = 15;
            //the text epearing to math out the equation

            Console.WriteLine("this is the value of the number {0}", initialspeed);
            slowdown();
            Console.WriteLine("this is the value of the number now {0}", initialspeed);
            slowdown();
            Console.WriteLine("this is the value of the number now {0}", initialspeed);
            slowdown();
            Console.WriteLine("this is the value of the number now {0}", initialspeed);
            slowdown();
            Console.WriteLine("this is the value of the number now {0}", initialspeed);
            slowdown();
            Console.WriteLine("this is the value of the number now {0}", initialspeed);
            Console.WriteLine(initialspeed);


            void slowdown()
            {
                //the math equation responsible for the outcome and the function of the method.
                initialspeed -= decelaration;
                decelaration -= 3;
                
            }

        }
    }
}