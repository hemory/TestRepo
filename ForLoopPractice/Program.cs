using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt16(Console.ReadLine());

            bool isOfLegalAge = IsLegal(userAge);

            Console.WriteLine(isOfLegalAge);
            
            Console.ReadLine();
        }



        
        public static void CountUp(int maxNumber)
        {
            for (int i = 0; i <= maxNumber; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static List<int> GenerateAListOfNumbers()
        {
            List<int> listOfNumbers = new List<int> {1,2,3,4,5,6,7,8,9};

            return listOfNumbers;
        }

        public static bool IsLegal(int age)
        {
            if (age >= 18)
            {
                return true;
            }

            return false;
        }
    }
}
