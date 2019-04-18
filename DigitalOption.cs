using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class DigitalOption : Option
    {
        public DigitalOption(double cst, double ck, double cr, double cT, int csteps, double csig, int ctrials, int cindex, bool cindex_anti, bool cindex_cv, bool cthreadingindex) : base(cst, ck, cr, cT, csteps, csig, ctrials, cindex, cindex_anti, cindex_cv, cthreadingindex)
        {
            s = cst;
            k = ck;
            r = cr;
            T = cT;
            steps = csteps;
            sigma = csig;
            trials = ctrials;
            index = cindex;
            index_anti = cindex_anti;
            index_cv = cindex_cv;
        }
        public override double optionprice_cv(out double se)
        {
            Simulation sim = new Simulation();
            double[,] stockmatrix = sim.simulation(trials, steps, r, T, sigma, s, randsaved, index_anti, threadingindex);
            double[,] payoff = new double[trials, 1];
            double cv1, cv2;
            double delta, delta2;
            double dt = T / steps;
            double num = -1;
            double sum_ct = 0;
            double sum_ct2 = 0;
            double d2;
            for (int i = 0; i < trials; i++)
            {
                cv1 = 0;
                cv2 = 0;

                for (int j = 1; j < steps; j++)
                {
                    double t = (j - 1) * dt;
                    double d1 = ((Math.Log(stockmatrix[i, j - 1] / k) + (r + (sigma * sigma) * 0.5) * (T - t))) / (sigma * Math.Sqrt(T - t));
                    if (index == 1)
                    {
                        delta = CDF(d1);
                    }
                    else
                    {
                        delta = CDF(d1) - 1;
                    }
                    cv1 += delta * (stockmatrix[i, j] - (stockmatrix[i, j - 1] * Math.Exp(r * T / (steps - 1))));

                    if (index_anti)
                    {
                        d2 = ((Math.Log(stockmatrix[i + trials, j - 1] / k) + (r + (sigma * sigma) * 0.5) * (T - t))) / (sigma * Math.Sqrt(T - t));
                        if (index == 1)
                        { delta2 = CDF(d2); }
                        else
                        { delta2 = CDF(d2) - 1; }
                        cv2 += delta2 * (stockmatrix[i + trials, j] - (stockmatrix[i + trials, j - 1] * Math.Exp(r * T / (steps - 1))));
                    }
                }

                if (index == 1)
                {
                    if (index_anti)
                    {
                        if(stockmatrix[i, steps - 1] > k)
                            payoff[i, 0] = 0.5 * (1 + num * cv1) + (1 + num * cv2);
                        else
                            payoff[i, 0] = 0.5 * (0 + num * cv1) + (0 + num * cv2);
                    }
                    else
                    {
                        if(stockmatrix[i, steps - 1] > k)
                            payoff[i, 0] =1 + num * cv1;
                        else
                            payoff[i,0] = 0 + num * cv1;
                    }
                }

                else
                {
                    if (index_anti)
                    {
                        if(k > stockmatrix[i, steps - 1])
                            payoff[i, 0] = 0.5 * ((1 + num * cv1) + (1 + num * cv2));
                        else
                            payoff[i, 0] = 0.5 * ((0 + num * cv1) + (0 + num * cv2));
                    }
                    else
                    {
                        if(k > stockmatrix[i, steps - 1])
                            payoff[i, 0] = 1 + num * cv1;
                        else
                            payoff[i, 0] = 0 + num * cv1;
                    }
                }

                sum_ct += payoff[i, 0];
                sum_ct2 += Math.Pow(payoff[i, 0], 2);
            }

            double price = (sum_ct / Convert.ToDouble(trials)) * Math.Exp(-r * T);
            double std = Math.Sqrt((sum_ct2 - sum_ct * sum_ct / Convert.ToDouble(trials)) * Math.Exp(-2 * r * T) / (Convert.ToDouble(trials - 1)));
            se = std / Math.Sqrt(trials);
            return price;

        }

        public override double optionprice(out double se)
        {
            Simulation sim = new Simulation();
            double[,] stockmatrix = sim.simulation(trials, steps, r, T, sigma, s, randsaved, index_anti, threadingindex);
            double[,] payoff;
            if (index_anti) { payoff = new double[trials * 2, 1]; }
            else { payoff = new double[trials, 1]; }


            if (index == 1)
            {
                for (int i = 0; i < stockmatrix.GetLength(0); i++)
                {
                    if (stockmatrix[i, steps - 1] > k)
                        payoff[i, 0] = 1;
                    else
                        payoff[i, 0] = 0;
                }
            }

            if (index != 1)
            {
                for (int i = 0; i < stockmatrix.GetLength(0); i++)
                {
                    if (k > stockmatrix[i, steps - 1])
                        payoff[i, 0] = 1;
                    else
                        payoff[i, 0] = 0;
                }
            }

            double sum = 0;
            double sum_se = 0;
            for (int i = 0; i < trials; i++)
            {
                sum += payoff[i, 0];
            }
            double price = (sum / Convert.ToDouble(trials)) * Math.Exp(-r * T);

            if (index_anti)
            {
                double[,] ave_p = new double[trials, 1];
                for (int i = 0; i < trials; i++)
                {
                    ave_p[i, 0] = (payoff[i, 0] + payoff[i + trials, 0]) * 0.5;
                }

                for (int i = 0; i < trials; i++)
                {
                    sum_se += Math.Pow((ave_p[i, 0] * Math.Exp(-r * T)) - price, 2);

                }
            }
            else
            {
                for (int i = 0; i < trials; i++)
                {
                    sum_se += Math.Pow((payoff[i, 0] * Math.Exp(-r * T)) - price, 2);
                }
            }

            double std = Math.Sqrt((1 / Convert.ToDouble((trials - 1))) * sum_se);

            se = std / Math.Sqrt(trials);

            return price;
        }


        static double CDF(double x)              // The CDF function from web:http://www.johndcook.com/blog/csharp_phi/                     
        {

            double a1 = 0.254829592;
            double a2 = -0.284496736;
            double a3 = 1.421413741;
            double a4 = -1.453152027;
            double a5 = 1.061405429;
            double p = 0.3275911;

            int sign = 1;
            if (x < 0)
                sign = -1;
            x = Math.Abs(x) / Math.Sqrt(2.0);
            double t = 1.0 / (1.0 + p * x);
            double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);

            return 0.5 * (1.0 + sign * y);
        }

    }
}
