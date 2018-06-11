using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ant = "1";
            int i = 1;
            Console.WriteLine(ant);
            while (i<21)
            {   
                Console.WriteLine("------------------------------"+i);
                string output="";
                char prev=' ';
                int cnt = 0;
                foreach (var item in ant)
                {
                    // initialization
                    if (prev == ' ') prev = item;
                    // When changing the number
                    if (prev != item)
                    {
                        output += prev;
                        output += cnt.ToString();
                        prev = item;
                        cnt = 1;
                    }
                    else cnt++;
                }
                // When finished
                output += prev;
                output += cnt.ToString();
                Console.WriteLine(output);
                ant = output;
                i++;
            }
        }


    }

}