using System;

namespace practical_taskk
{

    class Programmm
    {


        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static int get_data(int a, int m, int c, int x0, int itirations)
        {
            int cycle = 0;
            //a = 5, m = 16, x0 = 7, c = 3, itirations = 5,
            double[] arr = new double[1000];
            double[] U = new double[1000];
            for (int k = 0; k < 1000; k++)
            {
                arr[k] = 0;
            }
            U[0] = 0;
            arr[0] = x0;
            for (int j = 1; j < itirations; j++)
            {
                if (j - 1 >= 0)

                    arr[j] = (a * arr[j - 1] + c) % m;
                U[j] = arr[j] / m;
                Console.WriteLine(arr[j] + "    " + U[j]);
                int mi = (int)Math.Sqrt(m);
                float mf = (float)Math.Sqrt(m);

                if (mi == mf && c != 0)
                {
                    cycle = m;
                }
                else if (mi == mf && c == 0)
                {
                    cycle = m / 4;
                }
                else if (IsPrime(m) && c == 0)
                {
                    cycle = m - 1;
                }
                else cycle++;
                Console.WriteLine(cycle);
                if (m - 1 <= cycle)
                {
                    Console.WriteLine("full period");

                }
            }
                return cycle;
             
        }
        }

    }
 