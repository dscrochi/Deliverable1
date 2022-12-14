// See https://aka.ms/new-console-template for more information
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Deliverable1
{
    class Program1
    {

        static void Main(string[] args)
        {
            
                int answer = 1;
                while (answer>0)
                    {
                Console.Clear();
                Console.Write("How many people are we making PB&J sandwiches for?");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num);
                Console.WriteLine();


                int slices = num * 2;
                int pbtb = num * 2;
                int jtb = num * 4;

                int loaves = slices / 28 + 1;
                double pbjar = pbtb / 32 + 1;
                int jjar = jtb / 48 + 1;

                pbjar = Math.Ceiling(pbjar);

                Console.WriteLine("You need: \n");

                Console.WriteLine(slices + " slices of bread \n" + pbtb + " tablespoons of peanut butter \n" + jtb + " tablespoons of jelly \n");

                Console.WriteLine("Which is... \n");

                Console.WriteLine(loaves + " loaves of bread \n" + pbjar + " jars of peanut butter \n" + jjar + " jars of jelly \n");

                Console.Write("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.\r\n");
                string a =Console.ReadLine();

                    if (a != "yes" && a != "y")
                        {
                        answer = 0;
                            };



                }
            Console.WriteLine("Goodbye");




        }
    }
}