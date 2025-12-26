using System.Text;

namespace random_values_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Start With Random Values Generator----------");
            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Generate random number");
            Console.WriteLine("[2] Generate random string");

            int option = Convert.ToInt16(Console.ReadLine());

            if (option == 1)
            {
                GenerateRandomNumber();
            }
            else if (option == 2)
            {
                GenerateRandomString();
            }
        }

        static void GenerateRandomNumber()
        {
            var rnd = new Random();
            Console.WriteLine(rnd.Next(1000, 9999));
        }

        static void GenerateRandomString()
        {
            var rnd = new Random();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 16; i++)
            {
                stringBuilder.Append((char)rnd.Next(65, 126));
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
