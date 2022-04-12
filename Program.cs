using System;

namespace CheckTheSTRINGisEmptyOrNo_Return_TRUEorFALSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StringChecker checker = new StringChecker();
            checker.Reader();
            checker.Cheker();
            checker.Printer();
        }

        public class StringChecker
        {
            string newString;
            string result;
            public void Reader()
            {
                Console.WriteLine("Program checkes if the entered string is empty or no.");

                Console.WriteLine("Enter some text or nothing and press Enter...");
                newString = Console.ReadLine();

            }

            public void Cheker()
            {
                if (Convert.ToBoolean(newString.Length == 0) == true)
                {
                    result = "Line is empty";  
                } else
                {

                    result = "There is some text in Line";
                }
            }

            public void Printer()
            {
                Console.Clear();
                Console.WriteLine("Program checkes if the entered string is empty or no.");
                Console.WriteLine($"The result is : {result}");
                Console.ReadLine();
            }
        }
    }
}
