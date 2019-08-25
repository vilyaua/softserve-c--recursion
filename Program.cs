using System;
using System.Collections;

namespace softserve_c__recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte lowest = -100;
            sbyte highest = 100;
            Random rnd = new Random();
            
            sbyte[] arr = new sbyte[ Math.Abs(lowest) + Math.Abs(highest) + 1 ];

            void init(sbyte low, sbyte high)
            {
                int cur = 0;
                for (sbyte i = low; i <= high; i++)
                {
                    arr[cur++] = i;
                }
            }

            void output(ArrayList mylist)
            {
                ArrayList operList = mylist;
                int random = rnd.Next(0, operList.Count);
                sbyte item = (sbyte)mylist[random];

                System.Console.WriteLine($"{ item }");

                operList.Remove(item);

                if (mylist.Count >= 1)
                {
                    output(operList);
                }
            }

            init(lowest, highest);

            System.Collections.ArrayList myNegativeList = new System.Collections.ArrayList();
            System.Collections.ArrayList myRestList = new System.Collections.ArrayList();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    myNegativeList.Add(arr[i]);
                }
                else
                {
                    myRestList.Add(arr[i]);
                }
            }

            output(myNegativeList);
            output(myRestList);
        }
    }
}
