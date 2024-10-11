namespace mathandmethods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 25;
            //the text epearing to math out the equation

            Console.WriteLine("this is the value of the number {0}", num1);
            subtracter();
            Console.WriteLine("this is the value of the number now {0}", num1);
            subtracter();
            Console.WriteLine("this is the value of the number now {0}", num1);
            subtracter();
            Console.WriteLine("this is the value of the number now {0}", num1);
            subtracter();
            Console.WriteLine("this is the value of the number now {0}", num1);
            subtracter();
            Console.WriteLine("this is the value of the number now {0}", num1);
            Console.WriteLine(num1);


            void subtracter()
            {
                //the math equation responsible for the outcome and the function of the method.
                num1 -= num2;
                num2 -= 5;
            }
            
        }
    }
}
