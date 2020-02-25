using System.Collections;
using System;

namespace _4_5_lab_sean
{
    class Program
    {
        static void Main(string[] args)
        {
            //list
            Console.WriteLine(" score leaderboard logic");
            ArrayList al = new ArrayList();
            al.Add("4400");
            al.Add("8900");
            al.Add("1200");
            al.Add("3700");
            al.Add("7200");

            foreach (string item in al)
            {
                Console.WriteLine(item);

            }
            //Sort
            Console.WriteLine("Sorting of scores from lowest to highest");
            al.Sort();
            foreach (string item in al)
            {
                Console.WriteLine(item);
            }
            //Reverse sort
            Console.WriteLine("Sorting of scores from highest to lowest");
            al.Reverse();
            foreach (string item in al)
            {
                Console.WriteLine(item);
            }
            //ADD
            Console.WriteLine("Add");
            al.Add("2400");
            foreach (string item in al)
            {
                Console.WriteLine(item);
            }
            //REMOVE
            Console.WriteLine("REMOVE");
            al.Remove("4400");
            foreach (string item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}
