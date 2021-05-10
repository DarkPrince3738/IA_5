using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the number of product");
            int numberOfBuying = int.Parse(Console.ReadLine());
            bool trueFalse = TryGetProductInfo(numberOfBuying, out string answer);
            if(trueFalse == true)
            {
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("Такого товару не існує");
            }
        }
        static bool TryGetProductInfo(int prodNumber, out string prodINfo)
        {
            switch (prodNumber)
            {
                case 1:
                    {
                        prodINfo="Назва товару - телефон, ціна 300$";
                        return true;
                    }
                case 2:
                    {
                        prodINfo = "Назва товару - навушники, ціна 100$";
                        return true;
                    }
                case 3:
                    {
                        prodINfo = "Назва товару - планшет, ціна 400$";
                        return true;
                    }
                case 4:
                    {
                        prodINfo = "Назва товару - ручка, ціна 10$";
                        return true;
                    }
                case 5:
                    {
                        prodINfo = "Назва товару - клавіатура, ціна 150$";
                        return true;
                    }
                default:
                    {
                        prodINfo = "";
                        return false;
                    }
            }

        }
    }
}
