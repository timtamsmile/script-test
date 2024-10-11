using System.ComponentModel.Design;

namespace choices_choices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userinput = Console.ReadLine();
            Console.WriteLine("  buddy! whats your favourite colour?");
            userinput = Console.ReadLine();
            if (userinput == "blue")
                Console.WriteLine("cool and calm");
            else if (userinput == "red")
                Console.WriteLine("bold choice");
            else if (userinput == "green")
                Console.WriteLine("nature lover, i see");
            else
                Console.WriteLine("your favourite colour is {0}", userinput);

        }
    }
}
