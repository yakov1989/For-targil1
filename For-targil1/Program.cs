using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_targil1



{

    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("please enter a max number :");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine("Boom!!");
                else
                    Console.WriteLine($"{i}");

            } 
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {


    //        Console.WriteLine("please enter a number:");
    //        int i;
    //        int n = int.Parse(Console.ReadLine());

    //        for (i = 2; i <= 10; i++)
    //        {
    //            if (n % i == 0)
    //            {
    //                Console.WriteLine(i);
    //            }

    //        }
    //    }
    //}

    //Targil 4

    //class Program
    //{
    //    static void Main(string[] args)
    //    {


    //        int counter = 0;
    //        float avg = 0;

    //        Console.WriteLine("please enter a number or write done to exit:");
    //        string input = Console.ReadLine();
    //        for (int i = 0; input != "done"; i++)
    //        {
    //            counter++;
    //            int num = int.Parse(input);

    //            avg += num;
    //            Console.WriteLine("please enter a number or write done to exit:");
    //            input = Console.ReadLine();

    //        }

    //        Console.WriteLine($"The Average is:{avg / counter}");

    //    }


    //}


    //Targil 5

    //             class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Console.WriteLine("please enter a number:");
    //        int num = int.Parse(Console.ReadLine());
    //        for (int i = 2; i < num / 2; i++)
    //        {
    //            if (num % i == 0)
    //            {
    //                Console.WriteLine("The Number {0} is not Prime!", num);
    //                return;
    //            }

    //        }
    //        Console.WriteLine("The Number {0} is Prime!", num);
    //    }
    //    }

}


