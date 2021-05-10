using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write num");
            string ans = Console.ReadLine();
            bool isSuccess = int.TryParse(ans, out int res);
            if (isSuccess)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
