using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PROBLEM 1

            int[] arrays = new int[12];
            arrays[0] = 15;
            arrays[1] = 15;
            arrays[2] = 15;
            arrays[3] = 15;
            arrays[4] = 15;
            arrays[5] = 15;
            arrays[6] = 30;
            arrays[7] = 15;
            arrays[8] = 15;
            arrays[9] = 15;
            arrays[10] = 15;
            arrays[11] = 15;

            int[] group1 = new int[4];
            group1[0] = arrays[0];
            group1[1] = arrays[1];
            group1[2] = arrays[2];
            group1[3] = arrays[3];

            int[] group2 = new int[4];
            group2[0] = arrays[4];
            group2[1] = arrays[5];
            group2[2] = arrays[6];
            group2[3] = arrays[7];

            int[] group3 = new int[4];
            group3[0] = arrays[8];
            group3[1] = arrays[9];
            group3[2] = arrays[10];
            group3[3] = arrays[11];

            int a = group1.Sum();
            int b = group2.Sum();
            int c = group3.Sum();

            if (a == b && b == c && a == c)
            {
                Console.WriteLine("there are no odd ones");
            }
            else if (a == b && b != c && a != c)
            {
                //return c;
            }
            else if (a != b && b != c && a == c)
            {
               // return b;
            }
            else if (a != b && b == c && a != c)
            {
                //return a;
            }

            // Mr Yeprikyan, I wasn't able to give further solution for the 1st problem. 
            // I strongly rely on your explanation during our next lesson

            // PROBLEM 2

            List<string> strings = new List<string>();
            strings.Add("pizza");
            strings.Add("tolma");
            strings.Add("sushi");
            strings.Add("hotdog");
            strings.Add("burger");


            int u = strings.Count - ((strings.Count - 1)/2);

            Console.WriteLine(strings[u]);

            // PROBLEM 3

            List<int> ints = new List<int>();
            ints.Add(3);
            ints.Add(4);
            ints.Add(15);
            ints.Add(26);
            ints.Add(12);

            Console.WriteLine(ints.Max());

        }
    }
}
