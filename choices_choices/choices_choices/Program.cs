using System.ComponentModel.Design;

namespace choices_choices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userinput = Console.ReadLine();
            Console.WriteLine("hey buddy! whats your favourite dinosaur?");
            userinput = Console.ReadLine();
            if (userinput == "t-rex")
                Console.WriteLine("BONE CRUNCHING MADDNESS-");
            else if (userinput == "titanosaur")
                Console.WriteLine("ohhh thats a big boy");
            else if (userinput == "pterodactyl")
                Console.WriteLine("oh yeah the m    effin pterodactyl. but where is the p?");
            else 
                Console.WriteLine("your choice is {0}", userinput);

        }
    }
}
