using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // start and end time
            static double start = 0, stop = 0;

            // Function to put start time and print it

            static void startTime()
            {
                start = System.currentTimeMillis();
                System.out.println("Started at " + start);
            }

            // function to put stop time and print it

            static void stopTime()
            {
                stop = System.currentTimeMillis();
                System.out.println("Stopped at " + stop);
            }

            // function to calculate elapsed time and print it

            static void elapsedTime()
            {
                System.out.println("Elapsed Time is " + (stop - start) / 1000);
            }

            public static void main(String[] args)
            {
                Scanner sc = new Scanner(System.in);
                System.out.println("Enter 1 to Start : ");
                sc.next();
                startTime();
                System.out.println("Enter 2 to Stop : ");
                sc.next();
                sc.close();
                stopTime();
                elapsedTime();
            }
        }   
    }
}
