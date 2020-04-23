

using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0;
            string input3 = "";
            Class obj = new Class();
            bool boo = false;
            // Check user inputs 
            do
            {
                Console.WriteLine("enter number1");
                string input1 = Console.ReadLine();
                Console.WriteLine("enter number2");
                string input2 = Console.ReadLine();
                Console.WriteLine("choose your opperation");
                input3 = Console.ReadLine();

                try
                {
                    number1 = int.Parse(input1);
                    number2 = int.Parse(input2);
                    if (input3.Equals("+") | input3.Equals("*") | input3.Equals("/"))
                    {

                    }
                    else
                    {
                        boo = true;
                        Console.WriteLine("wrong input");
                    }
                }
                catch (Exception e)
                {
                    boo = false;
                    Console.WriteLine(e.Message);
                    Console.WriteLine("reenter your data");
                }
            } while (boo);

            // Compute the operation
            obj.compute(number1, number2, input3);

        }
    }
}