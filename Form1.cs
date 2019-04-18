using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            pccore.Text = Convert.ToString(System.Environment.ProcessorCount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int index_EuroC = Convert.ToInt32(EuropeanCall.Checked);
            int index_EuroP = Convert.ToInt32(EuropeanPut.Checked);
            int index_AsiaC = Convert.ToInt32(AsianCall.Checked);
            int index_AsiaP = Convert.ToInt32(AsianPut.Checked);
            int index_DigC = Convert.ToInt32(DigitalCall.Checked);
            int index_DigP = Convert.ToInt32(DigitalPut.Checked);
            int index_downout = Convert.ToInt32(downout.Checked);
            int index_upout = Convert.ToInt32(upout.Checked);
            int index_downin = Convert.ToInt32(downin.Checked);
            int index_upin = Convert.ToInt32(upin.Checked);
            int index_LookC = Convert.ToInt32(LookbackCall.Checked);
            int index_LookP = Convert.ToInt32(LookbackPut.Checked);
            int index_Range = Convert.ToInt32(RangeCall.Checked);

            progressBar1.Value = progressBar1.Value + 5;
            bool threadingindex = Convert.ToBoolean(Threading.Checked);
            bool index_anti = Convert.ToBoolean(Antithetic.Checked);
            progressBar1.Value = progressBar1.Value + 5;
            bool index_cv = Convert.ToBoolean(control_variate.Checked);
            progressBar1.Value = progressBar1.Value + 5;
            randomnumber RandInstance = new randomnumber();
            progressBar1.Value = progressBar1.Value + 5;
            double s = Convert.ToDouble(stock_price.Text);
            progressBar1.Value = progressBar1.Value + 5;
            double k = Convert.ToDouble(strike_price.Text);
            progressBar1.Value = progressBar1.Value + 5;
            double r = Convert.ToDouble(risk_free_rate.Text);
            progressBar1.Value = progressBar1.Value + 5;
            double T = Convert.ToDouble(Time.Text);
            progressBar1.Value = progressBar1.Value + 5;
            double sigma = Convert.ToDouble(volatility.Text);
            progressBar1.Value = progressBar1.Value + 5;
            int N = Convert.ToInt32(steps.Text);
            progressBar1.Value = progressBar1.Value + 5;
            int trials = Convert.ToInt32(Trials.Text);
            progressBar1.Value = progressBar1.Value + 5;

            Option option;
            if (index_EuroC == 1 || index_EuroP ==1)
            {
                option = new EuropeanOption(s, k, r, T, N, sigma, trials, index_EuroC, index_anti, index_cv, threadingindex);
                progressBar1.Value = progressBar1.Value + 5;
                double standard_error;
                progressBar1.Value = progressBar1.Value + 5;
                Option_result.Text = Convert.ToString(option.optionprice(out standard_error));
                progressBar1.Value = progressBar1.Value + 5;
                Delta.Text = Convert.ToString(option.delta());
                progressBar1.Value = progressBar1.Value + 5;
                Gamma.Text = Convert.ToString(option.gamma());
                progressBar1.Value = progressBar1.Value + 5;
                Vega.Text = Convert.ToString(option.vega());
                progressBar1.Value = progressBar1.Value + 5;
                Thelta.Text = Convert.ToString(option.thelta());
                progressBar1.Value = progressBar1.Value + 5;
                Rho.Text = Convert.ToString(option.rho());
                progressBar1.Value = progressBar1.Value + 5;
                SE_result.Text = Convert.ToString(standard_error);
                progressBar1.Value = progressBar1.Value + 5;

                timer.Stop();
                TimeSpan ts = timer.Elapsed;
                string elapsedTime = String.Format("{0:00} h and {1:00} m {2:00} s and {3:00} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                time_mark.Text = Convert.ToString(elapsedTime);
            }
            if(index_AsiaC==1|| index_AsiaP==1)
            {
                option = new AsianOption(s, k, r, T, N, sigma, trials, index_AsiaC, index_anti, index_cv, threadingindex);
                progressBar1.Value = progressBar1.Value + 5;
                double standard_error;
                progressBar1.Value = progressBar1.Value + 5;
                Option_result.Text = Convert.ToString(option.optionprice(out standard_error));
                progressBar1.Value = progressBar1.Value + 5;
                Delta.Text = Convert.ToString(option.delta());
                progressBar1.Value = progressBar1.Value + 5;
                Gamma.Text = Convert.ToString(option.gamma());
                progressBar1.Value = progressBar1.Value + 5;
                Vega.Text = Convert.ToString(option.vega());
                progressBar1.Value = progressBar1.Value + 5;
                Thelta.Text = Convert.ToString(option.thelta());
                progressBar1.Value = progressBar1.Value + 5;
                Rho.Text = Convert.ToString(option.rho());
                progressBar1.Value = progressBar1.Value + 5;
                SE_result.Text = Convert.ToString(standard_error);
                progressBar1.Value = progressBar1.Value + 5;

                timer.Stop();
                TimeSpan ts = timer.Elapsed;
                string elapsedTime = String.Format("{0:00} h and {1:00} m {2:00} s and {3:00} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                time_mark.Text = Convert.ToString(elapsedTime);
            }
            if(index_downin ==1 || index_downout==1 || index_upin==1||index_upout==1)
            {
                if(index_downin == 1|| index_upin == 1)
                {
                    option = new BarrierinOption(s, k, r, T, N, sigma, trials, index_upin, index_anti, index_cv, threadingindex);
                    progressBar1.Value = progressBar1.Value + 5;
                    double standard_error;
                    progressBar1.Value = progressBar1.Value + 5;
                    Option_result.Text = Convert.ToString(option.optionprice(out standard_error));
                    progressBar1.Value = progressBar1.Value + 5;
                    Delta.Text = Convert.ToString(option.delta());
                    progressBar1.Value = progressBar1.Value + 5;
                    Gamma.Text = Convert.ToString(option.gamma());
                    progressBar1.Value = progressBar1.Value + 5;
                    Vega.Text = Convert.ToString(option.vega());
                    progressBar1.Value = progressBar1.Value + 5;
                    Thelta.Text = Convert.ToString(option.thelta());
                    progressBar1.Value = progressBar1.Value + 5;
                    Rho.Text = Convert.ToString(option.rho());
                    progressBar1.Value = progressBar1.Value + 5;
                    SE_result.Text = Convert.ToString(standard_error);
                    progressBar1.Value = progressBar1.Value + 5;

                    timer.Stop();
                    TimeSpan ts = timer.Elapsed;
                    string elapsedTime = String.Format("{0:00} h and {1:00} m {2:00} s and {3:00} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                    time_mark.Text = Convert.ToString(elapsedTime);
                }
                if (index_downout == 1|| index_upout == 1)
                {
                    option = new BarrierinOption(s, k, r, T, N, sigma, trials, index_upout, index_anti, index_cv, threadingindex);
                    progressBar1.Value = progressBar1.Value + 5;
                    double standard_error;
                    progressBar1.Value = progressBar1.Value + 5;
                    Option_result.Text = Convert.ToString(option.optionprice(out standard_error));
                    progressBar1.Value = progressBar1.Value + 5;
                    Delta.Text = Convert.ToString(option.delta());
                    progressBar1.Value = progressBar1.Value + 5;
                    Gamma.Text = Convert.ToString(option.gamma());
                    progressBar1.Value = progressBar1.Value + 5;
                    Vega.Text = Convert.ToString(option.vega());
                    progressBar1.Value = progressBar1.Value + 5;
                    Thelta.Text = Convert.ToString(option.thelta());
                    progressBar1.Value = progressBar1.Value + 5;
                    Rho.Text = Convert.ToString(option.rho());
                    progressBar1.Value = progressBar1.Value + 5;
                    SE_result.Text = Convert.ToString(standard_error);
                    progressBar1.Value = progressBar1.Value + 5;

                    timer.Stop();
                    TimeSpan ts = timer.Elapsed;
                    string elapsedTime = String.Format("{0:00} h and {1:00} m {2:00} s and {3:00} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                    time_mark.Text = Convert.ToString(elapsedTime);
                }
            }
            if (index_DigC == 1 || index_DigP == 1)
            {
                option = new DigitalOption(s, k, r, T, N, sigma, trials, index_DigC, index_anti, index_cv, threadingindex);
                progressBar1.Value = progressBar1.Value + 5;
                double standard_error;
                progressBar1.Value = progressBar1.Value + 5;
                Option_result.Text = Convert.ToString(option.optionprice(out standard_error));
                progressBar1.Value = progressBar1.Value + 5;
                Delta.Text = Convert.ToString(option.delta());
                progressBar1.Value = progressBar1.Value + 5;
                Gamma.Text = Convert.ToString(option.gamma());
                progressBar1.Value = progressBar1.Value + 5;
                Vega.Text = Convert.ToString(option.vega());
                progressBar1.Value = progressBar1.Value + 5;
                Thelta.Text = Convert.ToString(option.thelta());
                progressBar1.Value = progressBar1.Value + 5;
                Rho.Text = Convert.ToString(option.rho());
                progressBar1.Value = progressBar1.Value + 5;
                SE_result.Text = Convert.ToString(standard_error);
                progressBar1.Value = progressBar1.Value + 5;

                timer.Stop();
                TimeSpan ts = timer.Elapsed;
                string elapsedTime = String.Format("{0:00} h and {1:00} m {2:00} s and {3:00} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                time_mark.Text = Convert.ToString(elapsedTime);
            }

            if (index_LookC == 1 || index_LookP == 1)
            {
                option = new LookBackOption(s, k, r, T, N, sigma, trials, index_LookC, index_anti, index_cv, threadingindex);
                progressBar1.Value = progressBar1.Value + 5;
                double standard_error;
                progressBar1.Value = progressBar1.Value + 5;
                Option_result.Text = Convert.ToString(option.optionprice(out standard_error));
                progressBar1.Value = progressBar1.Value + 5;
                Delta.Text = Convert.ToString(option.delta());
                progressBar1.Value = progressBar1.Value + 5;
                Gamma.Text = Convert.ToString(option.gamma());
                progressBar1.Value = progressBar1.Value + 5;
                Vega.Text = Convert.ToString(option.vega());
                progressBar1.Value = progressBar1.Value + 5;
                Thelta.Text = Convert.ToString(option.thelta());
                progressBar1.Value = progressBar1.Value + 5;
                Rho.Text = Convert.ToString(option.rho());
                progressBar1.Value = progressBar1.Value + 5;
                SE_result.Text = Convert.ToString(standard_error);
                progressBar1.Value = progressBar1.Value + 5;

                timer.Stop();
                TimeSpan ts = timer.Elapsed;
                string elapsedTime = String.Format("{0:00} h and {1:00} m {2:00} s and {3:00} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                time_mark.Text = Convert.ToString(elapsedTime);
            }

            if (index_Range==1)
            {
                option = new Range(s, k, r, T, N, sigma, trials, index_DigC, index_anti, index_cv, threadingindex);
                progressBar1.Value = progressBar1.Value + 5;
                double standard_error;
                progressBar1.Value = progressBar1.Value + 5;
                Option_result.Text = Convert.ToString(option.optionprice(out standard_error));
                progressBar1.Value = progressBar1.Value + 5;
                Delta.Text = Convert.ToString(option.delta());
                progressBar1.Value = progressBar1.Value + 5;
                Gamma.Text = Convert.ToString(option.gamma());
                progressBar1.Value = progressBar1.Value + 5;
                Vega.Text = Convert.ToString(option.vega());
                progressBar1.Value = progressBar1.Value + 5;
                Thelta.Text = Convert.ToString(option.thelta());
                progressBar1.Value = progressBar1.Value + 5;
                Rho.Text = Convert.ToString(option.rho());
                progressBar1.Value = progressBar1.Value + 5;
                SE_result.Text = Convert.ToString(standard_error);
                progressBar1.Value = progressBar1.Value + 5;

                timer.Stop();
                TimeSpan ts = timer.Elapsed;
                string elapsedTime = String.Format("{0:00} h and {1:00} m {2:00} s and {3:00} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                time_mark.Text = Convert.ToString(elapsedTime);
            }

                                   
        }
    }
}
