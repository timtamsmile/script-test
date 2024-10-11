using System.Reflection.Metadata;
using System.Threading.Channels;

namespace test1
{
    internal class Program
    {
        //int Street;
        //int housenumber;
        int postalcode;
        int residence;

        static void Main(string[] args)
        {
            string userinput = Console.ReadLine();

            Console.WriteLine("please enter your street name");
            string street = Console.ReadLine();
            Console.WriteLine("and what is your housenumber?");
            string housenumber = Console.ReadLine();
            Console.WriteLine("thank you for your input.");
            Console.WriteLine("okay! so your adress is:{0}", street + housenumber);

        }
    }
}