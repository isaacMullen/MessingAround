using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    internal class Program
    {                
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            
            IEnumerator enumerator = numbers.GetEnumerator();


            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
                if(!enumerator.MoveNext())
                {
                    Console.WriteLine("DONE");
                }
            }
            Console.ReadKey();
        }                               
            
        
    }
}

