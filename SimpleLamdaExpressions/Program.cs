using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLamdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Fun with Lamda");
            TraditionalDelegateSyntax();
            AnonymousMethodSyntax();
            LamdaExpressionSyntax();
           ProcessingLamdaExpressionArgumentWithinMultipleStatement();

            Console.ReadLine();


        }

        private static void ProcessingLamdaExpressionArgumentWithinMultipleStatement()
        {
            Console.WriteLine("Using LAmda Expression Method Syntax");
            //make a list of integers
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //call FindAll() using c# Lamda expression syntax
            List<int> evenNumbers = list.FindAll((i) =>
            {
                Console.WriteLine("The initial value of i is{0}", i);
                bool isEven = (i % 2) == 0;
                return isEven;

            }
            );
            Console.WriteLine("Here are your even numbers");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0} \t", evenNumber);

            }
            Console.WriteLine();
        }

        private static void LamdaExpressionSyntax()
        {
            Console.WriteLine("Using LAmda Expression Method Syntax");
            //make a list of integers
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //call FindAll() using c# Lamda expression syntax
            List<int> evenNumbers = list.FindAll(i=>(i % 2) == 0);
            Console.WriteLine("Here are your even numbers");
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine("{0} \t", evenNumber);

            }
            Console.WriteLine();
        }

        static void AnonymousMethodSyntax()
        {
            Console.WriteLine("Using Anonymous Method Syntax");
            //make a list of integers
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //call FindAll() using anonymous method
            List<int> evenNumbers = list.FindAll(delegate(int i){ return (i % 2) == 0; });
            Console.WriteLine("Here are your even numbers");
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine("{0} \t", evenNumber);

            }
            Console.WriteLine();
        }
            
    static void TraditionalDelegateSyntax()
        {
            //make a list of integers
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //call FindAll() using traditional Delegate method
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);
            Console.WriteLine("Here are your even numbers");
            foreach(int evenNumber in evenNumbers)
            {
                Console.WriteLine("{0} \t", evenNumber);

            }
            Console.WriteLine();
        }

        private static bool IsEvenNumber(int i)
        {
            //is it an enen number?
            return (i % 2) == 0;
        }
    }
}
