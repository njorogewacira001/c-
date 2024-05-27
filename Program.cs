using System;

namespace myfirstprojects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string textAge = "23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            long bigNumber = 90000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);

            float precision = 3.0005F;
            Console.WriteLine(precision);

            string name = "Aba";
            char letter = 'a';

            Console.WriteLine("your name is:");
            Console.WriteLine(name);


            Console.WriteLine(letter);

            bool value = true;
            bool ismale = true;
            Console.WriteLine(ismale);

            int weight = 23;
            weight++;
            weight *= 23;
            Console.WriteLine(weight);

            int firstnum = 1000;
            int secondmum = 90;
            Console.WriteLine(firstnum % secondmum);

            const int vat = 16;
            const double percentvat = vat / 100D;            
            Console.WriteLine(vat);
            


            Console.ReadLine();



        }
    }
}
