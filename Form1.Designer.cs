namespace HW1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stock_price = new System.Windows.Forms.TextBox();
            this.strike_price = new System.Windows.Forms.TextBox();
            this.risk_free_rate = new System.Windows.Forms.TextBox();
            this.volatility = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.steps = new System.Windows.Forms.TextBox();
            this.EuropeanCall = new System.Windows.Forms.RadioButton();
            this.EuropeanPut = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Trials = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Option_result = new System.Windows.Forms.TextBox();
            this.SE_result = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Delta = new System.Windows.Forms.TextBox();
            this.Gamma = new System.Windows.Forms.TextBox();
            this.Vega = new System.Windows.Forms.TextBox();
            this.Thelta = new System.Windows.Forms.TextBox();
            this.Rho = new System.Windows.Forms.TextBox();
            this.Antithetic = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.time_mark = new System.Windows.Forms.Label();
            this.control_variate = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pccore = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Threading = new System.Windows.Forms.CheckBox();
            this.AsianCall = new System.Windows.Forms.RadioButton();
            this.AsianPut = new System.Windows.Forms.RadioButton();
            this.DigitalCall = new System.Windows.Forms.RadioButton();
            this.DigitalPut = new System.Windows.Forms.RadioButton();
            this.downout = new System.Windows.Forms.RadioButton();
            this.upout = new System.Windows.Forms.RadioButton();
            this.LookbackCall = new System.Windows.Forms.RadioButton();
            this.LookbackPut = new System.Windows.Forms.RadioButton();
            this.RangeCall = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.downin = new System.Windows.Forms.RadioButton();
            this.upin = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Strike price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Risk-free rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Volatility";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stpes";
            // 
            // stock_price
            // 
            this.stock_price.Location = new System.Drawing.Point(187, 34);
            this.stock_price.Name = "stock_price";
            this.stock_price.Size = new System.Drawing.Size(100, 20);
            this.stock_price.TabIndex = 6;
            this.stock_price.Text = "50";
            // 
            // strike_price
            // 
            this.strike_price.Location = new System.Drawing.Point(187, 71);
            this.strike_price.Name = "strike_price";
            this.strike_price.Size = new System.Drawing.Size(100, 20);
            this.strike_price.TabIndex = 7;
            this.strike_price.Text = "60";
            // 
            // risk_free_rate
            // 
            this.risk_free_rate.Location = new System.Drawing.Point(187, 111);
            this.risk_free_rate.Name = "risk_free_rate";
            this.risk_free_rate.Size = new System.Drawing.Size(100, 20);
            this.risk_free_rate.TabIndex = 8;
            this.risk_free_rate.Text = "0.05";
            // 
            // volatility
            // 
            this.volatility.Location = new System.Drawing.Point(187, 145);
            this.volatility.Name = "volatility";
            this.volatility.Size = new System.Drawing.Size(100, 20);
            this.volatility.TabIndex = 9;
            this.volatility.Text = "0.5";
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(187, 183);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(100, 20);
            this.Time.TabIndex = 10;
            this.Time.Text = "1";
            // 
            // steps
            // 
            this.steps.Location = new System.Drawing.Point(187, 220);
            this.steps.Name = "steps";
            this.steps.Size = new System.Drawing.Size(100, 20);
            this.steps.TabIndex = 11;
            this.steps.Text = "2";
            // 
            // EuropeanCall
            // 
            this.EuropeanCall.AutoSize = true;
            this.EuropeanCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuropeanCall.Location = new System.Drawing.Point(39, 311);
            this.EuropeanCall.Name = "EuropeanCall";
            this.EuropeanCall.Size = new System.Drawing.Size(167, 22);
            this.EuropeanCall.TabIndex = 12;
            this.EuropeanCall.TabStop = true;
            this.EuropeanCall.Text = "European Call Option";
            this.EuropeanCall.UseVisualStyleBackColor = true;
            // 
            // EuropeanPut
            // 
            this.EuropeanPut.AutoSize = true;
            this.EuropeanPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuropeanPut.Location = new System.Drawing.Point(251, 311);
            this.EuropeanPut.Name = "EuropeanPut";
            this.EuropeanPut.Size = new System.Drawing.Size(164, 22);
            this.EuropeanPut.TabIndex = 13;
            this.EuropeanPut.TabStop = true;
            this.EuropeanPut.Text = "European Put Option";
            this.EuropeanPut.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(237, 674);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Trials";
            // 
            // Trials
            // 
            this.Trials.Location = new System.Drawing.Point(187, 260);
            this.Trials.Name = "Trials";
            this.Trials.Size = new System.Drawing.Size(100, 20);
            this.Trials.TabIndex = 16;
            this.Trials.Text = "100000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(362, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Option result";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(362, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Standard Error";
            // 
            // Option_result
            // 
            this.Option_result.Location = new System.Drawing.Point(514, 32);
            this.Option_result.Name = "Option_result";
            this.Option_result.Size = new System.Drawing.Size(100, 20);
            this.Option_result.TabIndex = 19;
            // 
            // SE_result
            // 
            this.SE_result.Location = new System.Drawing.Point(514, 78);
            this.SE_result.Name = "SE_result";
            this.SE_result.Size = new System.Drawing.Size(100, 20);
            this.SE_result.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(362, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Delta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(362, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Gamma";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(362, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Vega";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(362, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Thelta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(362, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Rho";
            // 
            // Delta
            // 
            this.Delta.Location = new System.Drawing.Point(514, 119);
            this.Delta.Name = "Delta";
            this.Delta.Size = new System.Drawing.Size(100, 20);
            this.Delta.TabIndex = 26;
            // 
            // Gamma
            // 
            this.Gamma.Location = new System.Drawing.Point(514, 159);
            this.Gamma.Name = "Gamma";
            this.Gamma.Size = new System.Drawing.Size(100, 20);
            this.Gamma.TabIndex = 27;
            // 
            // Vega
            // 
            this.Vega.Location = new System.Drawing.Point(514, 194);
            this.Vega.Name = "Vega";
            this.Vega.Size = new System.Drawing.Size(100, 20);
            this.Vega.TabIndex = 28;
            // 
            // Thelta
            // 
            this.Thelta.Location = new System.Drawing.Point(514, 230);
            this.Thelta.Name = "Thelta";
            this.Thelta.Size = new System.Drawing.Size(100, 20);
            this.Thelta.TabIndex = 29;
            // 
            // Rho
            // 
            this.Rho.Location = new System.Drawing.Point(514, 270);
            this.Rho.Name = "Rho";
            this.Rho.Size = new System.Drawing.Size(100, 20);
            this.Rho.TabIndex = 30;
            // 
            // Antithetic
            // 
            this.Antithetic.AutoSize = true;
            this.Antithetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antithetic.Location = new System.Drawing.Point(212, 562);
            this.Antithetic.Name = "Antithetic";
            this.Antithetic.Size = new System.Drawing.Size(153, 24);
            this.Antithetic.TabIndex = 31;
            this.Antithetic.Text = "Antithetic Method";
            this.Antithetic.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 593);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "The time used :";
            // 
            // time_mark
            // 
            this.time_mark.AutoSize = true;
            this.time_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_mark.Location = new System.Drawing.Point(174, 593);
            this.time_mark.Name = "time_mark";
            this.time_mark.Size = new System.Drawing.Size(140, 20);
            this.time_mark.TabIndex = 33;
            this.time_mark.Text = "time will show here";
            // 
            // control_variate
            // 
            this.control_variate.AutoSize = true;
            this.control_variate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_variate.Location = new System.Drawing.Point(407, 562);
            this.control_variate.Name = "control_variate";
            this.control_variate.Size = new System.Drawing.Size(185, 24);
            this.control_variate.TabIndex = 34;
            this.control_variate.Text = "control variate Method";
            this.control_variate.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(385, 589);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 24);
            this.label16.TabIndex = 35;
            this.label16.Text = "PC Cores";
            // 
            // pccore
            // 
            this.pccore.AutoSize = true;
            this.pccore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pccore.Location = new System.Drawing.Point(524, 589);
            this.pccore.Name = "pccore";
            this.pccore.Size = new System.Drawing.Size(0, 24);
            this.pccore.TabIndex = 36;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(42, 639);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(563, 23);
            this.progressBar1.TabIndex = 37;
            // 
            // Threading
            // 
            this.Threading.AutoSize = true;
            this.Threading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Threading.Location = new System.Drawing.Point(34, 562);
            this.Threading.Name = "Threading";
            this.Threading.Size = new System.Drawing.Size(128, 24);
            this.Threading.TabIndex = 41;
            this.Threading.Text = "Multithreading";
            this.Threading.UseVisualStyleBackColor = true;
            // 
            // AsianCall
            // 
            this.AsianCall.AutoSize = true;
            this.AsianCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsianCall.Location = new System.Drawing.Point(39, 352);
            this.AsianCall.Name = "AsianCall";
            this.AsianCall.Size = new System.Drawing.Size(148, 24);
            this.AsianCall.TabIndex = 42;
            this.AsianCall.TabStop = true;
            this.AsianCall.Text = "Asian Call Option";
            this.AsianCall.UseVisualStyleBackColor = true;
            // 
            // AsianPut
            // 
            this.AsianPut.AutoSize = true;
            this.AsianPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsianPut.Location = new System.Drawing.Point(251, 352);
            this.AsianPut.Name = "AsianPut";
            this.AsianPut.Size = new System.Drawing.Size(146, 24);
            this.AsianPut.TabIndex = 43;
            this.AsianPut.TabStop = true;
            this.AsianPut.Text = "Asian Put Option";
            this.AsianPut.UseVisualStyleBackColor = true;
            // 
            // DigitalCall
            // 
            this.DigitalCall.AutoSize = true;
            this.DigitalCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigitalCall.Location = new System.Drawing.Point(39, 395);
            this.DigitalCall.Name = "DigitalCall";
            this.DigitalCall.Size = new System.Drawing.Size(152, 24);
            this.DigitalCall.TabIndex = 44;
            this.DigitalCall.TabStop = true;
            this.DigitalCall.Text = "Digital Call Option";
            this.DigitalCall.UseVisualStyleBackColor = true;
            // 
            // DigitalPut
            // 
            this.DigitalPut.AutoSize = true;
            this.DigitalPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigitalPut.Location = new System.Drawing.Point(251, 395);
            this.DigitalPut.Name = "DigitalPut";
            this.DigitalPut.Size = new System.Drawing.Size(150, 24);
            this.DigitalPut.TabIndex = 45;
            this.DigitalPut.TabStop = true;
            this.DigitalPut.Text = "Digital Put Option";
            this.DigitalPut.UseVisualStyleBackColor = true;
            // 
            // downout
            // 
            this.downout.AutoSize = true;
            this.downout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downout.Location = new System.Drawing.Point(185, 437);
            this.downout.Name = "downout";
            this.downout.Size = new System.Drawing.Size(126, 24);
            this.downout.TabIndex = 46;
            this.downout.TabStop = true;
            this.downout.Text = "Down and out";
            this.downout.UseVisualStyleBackColor = true;
            // 
            // upout
            // 
            this.upout.AutoSize = true;
            this.upout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upout.Location = new System.Drawing.Point(327, 437);
            this.upout.Name = "upout";
            this.upout.Size = new System.Drawing.Size(106, 24);
            this.upout.TabIndex = 47;
            this.upout.TabStop = true;
            this.upout.Text = "Up and out";
            this.upout.UseVisualStyleBackColor = true;
            // 
            // LookbackCall
            // 
            this.LookbackCall.AutoSize = true;
            this.LookbackCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookbackCall.Location = new System.Drawing.Point(39, 477);
            this.LookbackCall.Name = "LookbackCall";
            this.LookbackCall.Size = new System.Drawing.Size(180, 24);
            this.LookbackCall.TabIndex = 48;
            this.LookbackCall.TabStop = true;
            this.LookbackCall.Text = "LookBack Call option ";
            this.LookbackCall.UseVisualStyleBackColor = true;
            // 
            // LookbackPut
            // 
            this.LookbackPut.AutoSize = true;
            this.LookbackPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookbackPut.Location = new System.Drawing.Point(251, 477);
            this.LookbackPut.Name = "LookbackPut";
            this.LookbackPut.Size = new System.Drawing.Size(177, 24);
            this.LookbackPut.TabIndex = 49;
            this.LookbackPut.TabStop = true;
            this.LookbackPut.Text = "LookBack Put Option";
            this.LookbackPut.UseVisualStyleBackColor = true;
            // 
            // RangeCall
            // 
            this.RangeCall.AutoSize = true;
            this.RangeCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangeCall.Location = new System.Drawing.Point(38, 522);
            this.RangeCall.Name = "RangeCall";
            this.RangeCall.Size = new System.Drawing.Size(156, 24);
            this.RangeCall.TabIndex = 50;
            this.RangeCall.TabStop = true;
            this.RangeCall.Text = "Range Call Option";
            this.RangeCall.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(41, 438);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 20);
            this.label17.TabIndex = 51;
            this.label17.Text = "Barrier Option";
            // 
            // downin
            // 
            this.downin.AutoSize = true;
            this.downin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downin.Location = new System.Drawing.Point(450, 437);
            this.downin.Name = "downin";
            this.downin.Size = new System.Drawing.Size(115, 24);
            this.downin.TabIndex = 52;
            this.downin.TabStop = true;
            this.downin.Text = "Down and in";
            this.downin.UseVisualStyleBackColor = true;
            // 
            // upin
            // 
            this.upin.AutoSize = true;
            this.upin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upin.Location = new System.Drawing.Point(580, 438);
            this.upin.Name = "upin";
            this.upin.Size = new System.Drawing.Size(95, 24);
            this.upin.TabIndex = 53;
            this.upin.TabStop = true;
            this.upin.Text = "Up and in";
            this.upin.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(19, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(477, 15);
            this.label18.TabIndex = 54;
            this.label18.Text = "Assume that for Digital and Barrier Option, the payoff is 1 if meet the payoff re" +
    "quirement";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 720);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.upin);
            this.Controls.Add(this.downin);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.RangeCall);
            this.Controls.Add(this.LookbackPut);
            this.Controls.Add(this.LookbackCall);
            this.Controls.Add(this.upout);
            this.Controls.Add(this.downout);
            this.Controls.Add(this.DigitalPut);
            this.Controls.Add(this.DigitalCall);
            this.Controls.Add(this.AsianPut);
            this.Controls.Add(this.AsianCall);
            this.Controls.Add(this.Threading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pccore);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.control_variate);
            this.Controls.Add(this.time_mark);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Antithetic);
            this.Controls.Add(this.Rho);
            this.Controls.Add(this.Thelta);
            this.Controls.Add(this.Vega);
            this.Controls.Add(this.Gamma);
            this.Controls.Add(this.Delta);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SE_result);
            this.Controls.Add(this.Option_result);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Trials);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EuropeanPut);
            this.Controls.Add(this.EuropeanCall);
            this.Controls.Add(this.steps);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.volatility);
            this.Controls.Add(this.risk_free_rate);
            this.Controls.Add(this.strike_price);
            this.Controls.Add(this.stock_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stock_price;
        private System.Windows.Forms.TextBox strike_price;
        private System.Windows.Forms.TextBox risk_free_rate;
        private System.Windows.Forms.TextBox volatility;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox steps;
        private System.Windows.Forms.RadioButton EuropeanCall;
        private System.Windows.Forms.RadioButton EuropeanPut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Trials;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Option_result;
        private System.Windows.Forms.TextBox SE_result;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Delta;
        private System.Windows.Forms.TextBox Gamma;
        private System.Windows.Forms.TextBox Vega;
        private System.Windows.Forms.TextBox Thelta;
        private System.Windows.Forms.TextBox Rho;
        private System.Windows.Forms.CheckBox Antithetic;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label time_mark;
        private System.Windows.Forms.CheckBox control_variate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label pccore;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox Threading;
        private System.Windows.Forms.RadioButton AsianCall;
        private System.Windows.Forms.RadioButton AsianPut;
        private System.Windows.Forms.RadioButton DigitalCall;
        private System.Windows.Forms.RadioButton DigitalPut;
        private System.Windows.Forms.RadioButton downout;
        private System.Windows.Forms.RadioButton upout;
        private System.Windows.Forms.RadioButton LookbackCall;
        private System.Windows.Forms.RadioButton LookbackPut;
        private System.Windows.Forms.RadioButton RangeCall;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton downin;
        private System.Windows.Forms.RadioButton upin;
        private System.Windows.Forms.Label label18;
    }
}

