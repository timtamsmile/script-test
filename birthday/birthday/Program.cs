namespace test1
{
    internal class Program
    {
        int birthMonth;
        int birthYear;
        int birthDay;



        static void Main(string[] args)
        {
            string userinput = Console.ReadLine();

            Console.WriteLine("please enter your BirthMonth");
            string birthmonth = Console.ReadLine();
            Console.WriteLine("and what is your brithyear?");
            string birthyear = Console.ReadLine();
            Console.WriteLine("and what is your Birthday");
            string birthday = Console.ReadLine();
            Console.WriteLine("thank you for your input.");
            Console.WriteLine("okay! so your adress is:"+ birthmonth +  birthday +  birthyear);

        }
    }
}