using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration
            string name ="John";
            int age =35;
            bool isTall =false;
            double weight =80.2;

            /*for the smallest least precise decimal use float,
             * for more precise use decimal eg for money,
             * in most cases double will do just fine
             * */
            Console.WriteLine(name + "is" +  age + "he weighs " + weight);
            Console.WriteLine("it is"  + isTall + "that he is tall");

            //freeze console
            Console.ReadLine();


                
        }
    }
}
