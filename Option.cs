using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public abstract class Option
    {
        protected double s;                               
        protected double k;                                 
        protected double r;                                 
        protected double T;                                 
        protected int steps;                               
        protected double sigma;                              
        protected int trials;                             
        protected int index;
        protected bool threadingindex;
        protected bool index_anti;
        protected bool index_cv;
        protected double[,] randsaved;   

        public Option(double cst, double ck, double cr, double cT, int csteps, double csig, int ctrials, int cindex,bool cindex_anti,bool cindex_cv,bool cthreadingindex)           
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
            threadingindex = cthreadingindex;
            randomnumber rnd = new randomnumber();          
            randsaved = rnd.random(steps, trials,threadingindex);     
        }
        
        public double[,] randomMatrix                            
        {
            set { this.randsaved = value; }
            get { return this.randsaved; }
        }
        
        public double stockprice                               
        {
            set
            {
                this.s = value;
            }
            get
            {
                return this.s;
            }
        }

        public double strikeprice                              
        {
            get
            {
                return this.k;
            }
            set
            {
                this.k = value;
            }
        }

        public double rate                                       
        {
            get
            {
                return this.r;
            }
            set
            {
                this.r = value;
            }
        }

        public double tenor                                       
        {
            get
            {
                return this.T;
            }
            set
            {
                this.T = value;
            }
        }

        public int Steps                                         
        {
            get
            {
                return this.steps;
            }
            set
            {
                this.steps = value;
            }
        }

        public double volatility                                  
        {
            get
            {
                return this.sigma;
            }
            set
            {
                this.sigma = value;
            }

        }

        public int Trials                                     
        {
            get
            {
                return this.trials;
            }
            set
            {
                this.trials = value;
            }
        }

        public int Index                                            
        {
            get
            {
                return this.index;
            }
            set
            {
                this.index = value;
            }
        }
        
        public void threading(bool thread)
        {
            threadingindex = thread;
        }

        public void anti (bool x)
        {
            index_anti = x;
        }
        public void control_value(bool cv)
        {
            index_cv = cv;
        }
        public abstract double optionprice(out double se);
        public abstract double optionprice_cv(out double se);

        public double delta()                                     
        {
            double s0 = stockprice;                                        
            double se;                                                    
            double tol = 0.0001;                                            
            stockprice = s0 * (1 + tol);                                   
            double priceup = optionprice(out se);                         
            stockprice = s0 * (1 - tol);                                   
            double pricedown = optionprice(out se);                        
            double delta = (priceup - pricedown) / (2 * s0 * tol);          
            stockprice = s0;                                                
            return delta;                                                  
        }


        public double gamma()                                     
        {                                                                   
            double s0 = stockprice;
            double se;
            double pricemid = optionprice(out se);
            double tol = 0.0001;
            stockprice = s0 * (1 + tol);
            double priceup = optionprice(out se);
            stockprice = s0 * (1 - tol);
            double pricedown = optionprice(out se);
            double gamma = (priceup - (2 * pricemid) + pricedown) / (Math.Pow(s0 * tol, 2));
            stockprice = s0;
            return gamma;
        }


        public double vega()                                      
        {                                                                  
            double sig0 = volatility;
            double se;
            double tol = 0.0001;
            volatility = sig0 * (1 + tol);
            double priceup = optionprice(out se);
            volatility = sig0 * (1 - tol);
            double pricedown = optionprice(out se);
            double vega = (priceup - pricedown) / (2 * sig0 * tol);
            volatility = sig0;
            return vega;
        }


        public double thelta()                                    
        {                                                                  
            double t0 = tenor;
            double se;
            double pricemid = optionprice(out se);
            double tol = 0.0001;
            tenor = t0 * (1 + tol);
            double priceup = optionprice(out se);
            double tetha = (pricemid - priceup) / (tol * t0);
            tenor = t0;
            return tetha;
        }


        public double rho()                                      
        {                                                                  
            double r0 = rate;
            double se;
            double tol = 0.0001;
            rate = r0 * (1 + tol);
            double priceup = optionprice(out se);
            rate = r0 * (1 - tol);
            double pricedown = optionprice(out se);
            double rho = (priceup - pricedown) / (2 * r0 * tol);
            rate = r0;
            return rho;
        }
    }
}
