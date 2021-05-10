using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //bool ans = BoolParse(str);
            //Console.WriteLine(ans);
            bool isSuccess = BoolTryParse(str, out bool res);
            if(isSuccess == true)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        static bool BoolParse(string str)
        {
            if(str == "false" || str == "0")
            {
                return false;
            }
            else if (str == "true" || str == "1")
            {
                return true;
            }
            else
            {
                throw new Exception("Error.Cannot parse “your value here");
            }

        }
        static bool BoolTryParse(string str, out bool res)
        {
            if (str == "false" || str == "0")
            {
                res = false;
                return true;
            }
            else if (str == "true" || str == "1")
            {
                res = true;
                return true;
            }
            else
            {
                res = false;
                return false;
            }

        }
    }
}
