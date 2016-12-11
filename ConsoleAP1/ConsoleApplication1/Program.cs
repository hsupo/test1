using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int abc;
            Console.WriteLine("Hello Git!");

            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            System.Console.WriteLine();

            IEnumerable<int> queryresult =
                from score in scores
                where score > 81
                orderby score ascending 
                select score;

            // Execute the query.
            foreach (int i in queryresult)
            {
                Console.Write(i + " ");
            }
            for (int i = 0; i < (int)Properties.Settings.Default.iCounter; i++)
            {
                for (int j = 0; j < (int)Properties.Settings.Default.jCounter; j++)
                {
                    for (int k = 0; k < (int)Properties.Settings.Default.kCounter; k++)
                    {
                        if (k * j == 3)
                        {
                            goto LooPI;
                        }
                        System.Console.WriteLine("i:{0}, j:{1}, k:{2}", i, j, k);
                    }
                }
            LooPI:;
            }

            using (System.IO.FileStream  aa = new System.IO.FileStream("", System.IO.FileMode.Open ))
            {

            }

            System.Reflection.Assembly.GetExecutingAssembly().GetFiles();

            System.Console.Read();

        }
    }
}
