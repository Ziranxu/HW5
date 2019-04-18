using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW1
{
    class randomnumber
    {

        public double[,] random(int steps, int trials,bool threadingindex)                          
        {
            double[,] randn = new double[trials, steps];
            if (threadingindex)
            {
                Random rnd = new Random();
               for(int i =0;i<trials;i++)
                {
                    for (int j = 0; j < steps; j++)
                    {
                        double u = 2 * rnd.NextDouble() - 1;
                        double v = 2 * rnd.NextDouble() - 1;
                        double z1, z2;
                        double w = (Math.Pow(u, 2)) + (Math.Pow(v, 2));
                        while (w > 1)
                        {
                            u = 2 * rnd.NextDouble() - 1;
                            v = 2 * rnd.NextDouble() - 1;
                            w = (Math.Pow(u, 2)) + (Math.Pow(v, 2));
                        }
                        double c = (Math.Sqrt(-2 * (Math.Log(w) / w)));
                        z1 = c * u;
                        z2 = c * v;
                        randn[i, j] = z1;
                        if (i + 1 < trials)
                        {
                            randn[i + 1, j] = z2;
                        }
                    }
                }
            }
            else
            {
                Random rnd = new Random();
                for (int j = 0; j < steps; j++)
                {
                    for (int i = 0; i < trials; i += 1)
                    {
                        double u = 2 * rnd.NextDouble() - 1;
                        double v = 2 * rnd.NextDouble() - 1;
                        double z1, z2;
                        double w = (Math.Pow(u, 2)) + (Math.Pow(v, 2));
                        while (w > 1)
                        {
                            u = 2 * rnd.NextDouble() - 1;
                            v = 2 * rnd.NextDouble() - 1;
                            w = (Math.Pow(u, 2)) + (Math.Pow(v, 2));
                        }
                        double c = (Math.Sqrt(-2 * (Math.Log(w) / w)));
                        z1 = c * u;
                        z2 = c * v;
                        randn[i, j] = z1;
                        if (i + 1 < trials)
                        {
                            randn[i + 1, j] = z2;
                        }
                    }
                }
            }

            return randn;                                                          
        }

    }
}
