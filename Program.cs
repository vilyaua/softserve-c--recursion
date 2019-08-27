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
            int size = 60000;
            Random rnd = new Random();
            
            sbyte[] source = new sbyte[ size ];

            sbyte[] init(sbyte[] arr, sbyte low, sbyte high)
            {
                for (int i = 0; i < size; i++)
                {
                    int random = rnd.Next( lowest, highest + 1 );
                    arr[i] = (sbyte)random;
                }
                return arr;
            }

            void output(ArrayList operList)
            {
                int random = rnd.Next(0, operList.Count);
                sbyte item = (sbyte)operList[random];

                System.Console.Write($" { item } ");

                operList.Remove(item);

                if (operList.Count > 0)
                {
                    output(operList);
                }
            }

            init(source, lowest, highest);

            ArrayList myNegativeList = new ArrayList();
            ArrayList myRestList = new ArrayList();
            ArrayList mySourceList = new ArrayList();

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < 0)
                {
                    myNegativeList.Add(source[i]);
                }
                else
                {
                    myRestList.Add(source[i]);
                }
                mySourceList.Add(source[i]);
            }

            System.Console.Write("Source");
            output(mySourceList);
            System.Console.WriteLine("\n...FinishedSource. Press a Key");
            Console.ReadKey();
            System.Console.Write("\nNegative");
            output(myNegativeList);
            System.Console.WriteLine("\n...Finished Negative. Press a Key");
            //Console.ReadKey();
            System.Console.Write("\nRest");
            output(myRestList);
            System.Console.WriteLine("\n...FinishedRest");
        }
    }
}
