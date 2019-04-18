using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW1
{
    class Simulation
    {
        public double[,] simulation(int trials, int steps, double r, double T, double sigma, double s, double[,] random,bool index_anti,bool threadingindex)             
        {
            double[,] stockmatrix;
            if (threadingindex)
            {
                
                if (index_anti)
                {
                    stockmatrix = new double[trials * 2, steps];
                }
                else
                {
                    stockmatrix = new double[trials, steps];
                }
                for (int j = 0; j < stockmatrix.GetLength(0); j++)
                {
                    stockmatrix[j, 0] = s;
                }
                Parallel.For(0, trials, (i, loopstate) =>
                {
                    for (int j = 1; j < steps; j++)
                    {
                        double coeff1 = (r - (0.5 * Math.Pow(sigma, 2))) * (T / Convert.ToDouble(steps - 1));
                        double coeff2 = sigma * Math.Sqrt((T / Convert.ToDouble(steps - 1)));
                        stockmatrix[i, j] = stockmatrix[i, j - 1] * Math.Exp(coeff1 + coeff2 * random[i, j]);
                        if (index_anti)
                        {
                            stockmatrix[i + trials, j] = stockmatrix[i + trials, j - 1] * Math.Exp(coeff1 - coeff2 * random[i, j]);
                        }
                    }
                });
                
            }
            else
            {
               
                if (index_anti)
                {
                    stockmatrix = new double[trials * 2, steps];
                }
                else
                {
                    stockmatrix = new double[trials, steps];
                }
                for (int j = 0; j < stockmatrix.GetLength(0); j++)
                {
                    stockmatrix[j, 0] = s;
                }
                for (int i = 0; i < trials; i++)
                {
                    for (int j = 1; j < steps; j++)
                    {
                        double coeff1 = (r - (0.5 * Math.Pow(sigma, 2))) * (T / Convert.ToDouble(steps - 1));
                        double coeff2 = sigma * Math.Sqrt((T / Convert.ToDouble(steps - 1)));
                        stockmatrix[i, j] = stockmatrix[i, j - 1] * Math.Exp(coeff1 + coeff2 * random[i, j]);
                        if (index_anti)
                        {
                            stockmatrix[i + trials, j] = stockmatrix[i + trials, j - 1] * Math.Exp(coeff1 - coeff2 * random[i, j]);
                        }
                    }
                }
               
            }
            return stockmatrix;
        }
    }
}
