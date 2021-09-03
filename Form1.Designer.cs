namespace AIComputingGraphics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.epochs_er = new System.Windows.Forms.Button();
            this.epochs_tb = new System.Windows.Forms.TextBox();
            this.epochs = new System.Windows.Forms.Label();
            this.sim_start = new System.Windows.Forms.Button();
            this.sim_update = new System.Windows.Forms.Button();
            this.sim_abort = new System.Windows.Forms.Button();
            this.simulation = new System.Windows.Forms.Label();
            this.bias_values = new System.Windows.Forms.Label();
            this.b2_tb = new System.Windows.Forms.TextBox();
            this.b1_tb = new System.Windows.Forms.TextBox();
            this.bias_b1 = new System.Windows.Forms.Label();
            this.bias_b2 = new System.Windows.Forms.Label();
            this.bias_b4 = new System.Windows.Forms.Label();
            this.bias_b3 = new System.Windows.Forms.Label();
            this.b3_tb = new System.Windows.Forms.TextBox();
            this.b4_tb = new System.Windows.Forms.TextBox();
            this.bias_update = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Label();
            this.x1_input = new System.Windows.Forms.Label();
            this.x1_tb = new System.Windows.Forms.TextBox();
            this.x2_input = new System.Windows.Forms.Label();
            this.x2_tb = new System.Windows.Forms.TextBox();
            this.input_er = new System.Windows.Forms.Button();
            this.output_er = new System.Windows.Forms.Button();
            this.output_y2 = new System.Windows.Forms.Label();
            this.y2_tb = new System.Windows.Forms.TextBox();
            this.output_y1 = new System.Windows.Forms.Label();
            this.y1_tb = new System.Windows.Forms.TextBox();
            this.outputline1 = new System.Windows.Forms.Label();
            this.outputline2 = new System.Windows.Forms.Label();
            this.lr1 = new System.Windows.Forms.Label();
            this.lr_tb = new System.Windows.Forms.TextBox();
            this.lr_er = new System.Windows.Forms.Button();
            this.lr2 = new System.Windows.Forms.Label();
            this.initialwl1 = new System.Windows.Forms.Label();
            this.w1_tb = new System.Windows.Forms.TextBox();
            this.w2_tb = new System.Windows.Forms.TextBox();
            this.w4_tb = new System.Windows.Forms.TextBox();
            this.w3_tb = new System.Windows.Forms.TextBox();
            this.w8_tb = new System.Windows.Forms.TextBox();
            this.w7_tb = new System.Windows.Forms.TextBox();
            this.w6_tb = new System.Windows.Forms.TextBox();
            this.w5_tb = new System.Windows.Forms.TextBox();
            this.iw1 = new System.Windows.Forms.Label();
            this.iw2 = new System.Windows.Forms.Label();
            this.iw4 = new System.Windows.Forms.Label();
            this.iw3 = new System.Windows.Forms.Label();
            this.iw8 = new System.Windows.Forms.Label();
            this.iw7 = new System.Windows.Forms.Label();
            this.iw6 = new System.Windows.Forms.Label();
            this.iw5 = new System.Windows.Forms.Label();
            this.initialwl2 = new System.Windows.Forms.Label();
            this.weight_update = new System.Windows.Forms.Button();
            this.Dx1Name = new System.Windows.Forms.Label();
            this.Dx2Name = new System.Windows.Forms.Label();
            this.Db1Name = new System.Windows.Forms.Label();
            this.Db3Name = new System.Windows.Forms.Label();
            this.Db2Name = new System.Windows.Forms.Label();
            this.Db4Name = new System.Windows.Forms.Label();
            this.Dy1Name = new System.Windows.Forms.Label();
            this.Dy2Name = new System.Windows.Forms.Label();
            this.Dw1 = new System.Windows.Forms.Label();
            this.Dw2 = new System.Windows.Forms.Label();
            this.Dw5 = new System.Windows.Forms.Label();
            this.Dw3 = new System.Windows.Forms.Label();
            this.Dw4 = new System.Windows.Forms.Label();
            this.Dw7 = new System.Windows.Forms.Label();
            this.Dw6 = new System.Windows.Forms.Label();
            this.Dh1Name = new System.Windows.Forms.Label();
            this.Dh2Name = new System.Windows.Forms.Label();
            this.Dh1 = new System.Windows.Forms.Label();
            this.Dh2 = new System.Windows.Forms.Label();
            this.Dy1 = new System.Windows.Forms.Label();
            this.Dy2 = new System.Windows.Forms.Label();
            this.Dw8 = new System.Windows.Forms.Label();
            this.Dx1 = new System.Windows.Forms.Label();
            this.Dx2 = new System.Windows.Forms.Label();
            this.Db1 = new System.Windows.Forms.Label();
            this.Db3 = new System.Windows.Forms.Label();
            this.Db2 = new System.Windows.Forms.Label();
            this.Db4 = new System.Windows.Forms.Label();
            this.Iteration_Status = new System.Windows.Forms.ProgressBar();
            this.Simulation_Progress_Name = new System.Windows.Forms.Label();
            this.Iteration_Handler = new System.ComponentModel.BackgroundWorker();
            this.Sim_Duration = new System.Windows.Forms.Label();
            this.Err_Acc_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Acc_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // epochs_er
            // 
            this.epochs_er.AutoSize = true;
            this.epochs_er.BackColor = System.Drawing.Color.DimGray;
            this.epochs_er.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.epochs_er.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epochs_er.ForeColor = System.Drawing.SystemColors.Control;
            this.epochs_er.Location = new System.Drawing.Point(153, 67);
            this.epochs_er.Name = "epochs_er";
            this.epochs_er.Size = new System.Drawing.Size(103, 35);
            this.epochs_er.TabIndex = 0;
            this.epochs_er.Text = "Enter";
            this.epochs_er.UseVisualStyleBackColor = false;
            this.epochs_er.Click += new System.EventHandler(this.epochs_er_Click);
            // 
            // epochs_tb
            // 
            this.epochs_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epochs_tb.Location = new System.Drawing.Point(153, 28);
            this.epochs_tb.Name = "epochs_tb";
            this.epochs_tb.Size = new System.Drawing.Size(103, 31);
            this.epochs_tb.TabIndex = 1;
            this.epochs_tb.Text = "1000000";
            this.epochs_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.epochs_tb_KeyPress);
            // 
            // epochs
            // 
            this.epochs.AutoSize = true;
            this.epochs.BackColor = System.Drawing.SystemColors.Control;
            this.epochs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epochs.ForeColor = System.Drawing.Color.RoyalBlue;
            this.epochs.Location = new System.Drawing.Point(44, 30);
            this.epochs.Name = "epochs";
            this.epochs.Size = new System.Drawing.Size(103, 25);
            this.epochs.TabIndex = 2;
            this.epochs.Text = "EPOCHS";
            // 
            // sim_start
            // 
            this.sim_start.AutoSize = true;
            this.sim_start.BackColor = System.Drawing.Color.DimGray;
            this.sim_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sim_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sim_start.ForeColor = System.Drawing.SystemColors.Control;
            this.sim_start.Location = new System.Drawing.Point(460, 67);
            this.sim_start.Name = "sim_start";
            this.sim_start.Size = new System.Drawing.Size(103, 35);
            this.sim_start.TabIndex = 3;
            this.sim_start.Text = "Start";
            this.sim_start.UseVisualStyleBackColor = false;
            this.sim_start.Click += new System.EventHandler(this.sim_start_Click);
            // 
            // sim_update
            // 
            this.sim_update.AutoSize = true;
            this.sim_update.BackColor = System.Drawing.Color.DimGray;
            this.sim_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sim_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sim_update.ForeColor = System.Drawing.SystemColors.Control;
            this.sim_update.Location = new System.Drawing.Point(328, 67);
            this.sim_update.Name = "sim_update";
            this.sim_update.Size = new System.Drawing.Size(103, 35);
            this.sim_update.TabIndex = 4;
            this.sim_update.Text = "Update";
            this.sim_update.UseVisualStyleBackColor = false;
            this.sim_update.Click += new System.EventHandler(this.sim_update_Click);
            // 
            // sim_abort
            // 
            this.sim_abort.AutoSize = true;
            this.sim_abort.BackColor = System.Drawing.Color.DimGray;
            this.sim_abort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sim_abort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sim_abort.ForeColor = System.Drawing.SystemColors.Control;
            this.sim_abort.Location = new System.Drawing.Point(592, 67);
            this.sim_abort.Name = "sim_abort";
            this.sim_abort.Size = new System.Drawing.Size(103, 35);
            this.sim_abort.TabIndex = 5;
            this.sim_abort.Text = "Abort";
            this.sim_abort.UseVisualStyleBackColor = false;
            this.sim_abort.Click += new System.EventHandler(this.sim_abort_Click);
            // 
            // simulation
            // 
            this.simulation.AutoSize = true;
            this.simulation.BackColor = System.Drawing.SystemColors.Control;
            this.simulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulation.ForeColor = System.Drawing.Color.RoyalBlue;
            this.simulation.Location = new System.Drawing.Point(385, 28);
            this.simulation.Name = "simulation";
            this.simulation.Size = new System.Drawing.Size(250, 25);
            this.simulation.TabIndex = 6;
            this.simulation.Text = "Simulation Control Panel";
            // 
            // bias_values
            // 
            this.bias_values.AutoSize = true;
            this.bias_values.BackColor = System.Drawing.SystemColors.Control;
            this.bias_values.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bias_values.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bias_values.Location = new System.Drawing.Point(830, 28);
            this.bias_values.Name = "bias_values";
            this.bias_values.Size = new System.Drawing.Size(181, 25);
            this.bias_values.TabIndex = 7;
            this.bias_values.Text = "Input Bias Values";
            // 
            // b2_tb
            // 
            this.b2_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2_tb.Location = new System.Drawing.Point(811, 100);
            this.b2_tb.Name = "b2_tb";
            this.b2_tb.Size = new System.Drawing.Size(103, 31);
            this.b2_tb.TabIndex = 8;
            this.b2_tb.Text = "0.0";
            // 
            // b1_tb
            // 
            this.b1_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1_tb.Location = new System.Drawing.Point(811, 61);
            this.b1_tb.Name = "b1_tb";
            this.b1_tb.Size = new System.Drawing.Size(103, 31);
            this.b1_tb.TabIndex = 9;
            this.b1_tb.Text = "0.0";
            // 
            // bias_b1
            // 
            this.bias_b1.AutoSize = true;
            this.bias_b1.BackColor = System.Drawing.SystemColors.Control;
            this.bias_b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bias_b1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bias_b1.Location = new System.Drawing.Point(767, 63);
            this.bias_b1.Name = "bias_b1";
            this.bias_b1.Size = new System.Drawing.Size(36, 25);
            this.bias_b1.TabIndex = 13;
            this.bias_b1.Text = "b1";
            // 
            // bias_b2
            // 
            this.bias_b2.AutoSize = true;
            this.bias_b2.BackColor = System.Drawing.SystemColors.Control;
            this.bias_b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bias_b2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bias_b2.Location = new System.Drawing.Point(767, 102);
            this.bias_b2.Name = "bias_b2";
            this.bias_b2.Size = new System.Drawing.Size(36, 25);
            this.bias_b2.TabIndex = 14;
            this.bias_b2.Text = "b2";
            // 
            // bias_b4
            // 
            this.bias_b4.AutoSize = true;
            this.bias_b4.BackColor = System.Drawing.SystemColors.Control;
            this.bias_b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bias_b4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bias_b4.Location = new System.Drawing.Point(953, 102);
            this.bias_b4.Name = "bias_b4";
            this.bias_b4.Size = new System.Drawing.Size(36, 25);
            this.bias_b4.TabIndex = 18;
            this.bias_b4.Text = "b4";
            // 
            // bias_b3
            // 
            this.bias_b3.AutoSize = true;
            this.bias_b3.BackColor = System.Drawing.SystemColors.Control;
            this.bias_b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bias_b3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bias_b3.Location = new System.Drawing.Point(953, 63);
            this.bias_b3.Name = "bias_b3";
            this.bias_b3.Size = new System.Drawing.Size(36, 25);
            this.bias_b3.TabIndex = 17;
            this.bias_b3.Text = "b3";
            // 
            // b3_tb
            // 
            this.b3_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3_tb.Location = new System.Drawing.Point(997, 61);
            this.b3_tb.Name = "b3_tb";
            this.b3_tb.Size = new System.Drawing.Size(103, 31);
            this.b3_tb.TabIndex = 16;
            this.b3_tb.Text = "0.99";
            // 
            // b4_tb
            // 
            this.b4_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4_tb.Location = new System.Drawing.Point(997, 100);
            this.b4_tb.Name = "b4_tb";
            this.b4_tb.Size = new System.Drawing.Size(103, 31);
            this.b4_tb.TabIndex = 15;
            this.b4_tb.Text = "0.0";
            // 
            // bias_update
            // 
            this.bias_update.AutoSize = true;
            this.bias_update.BackColor = System.Drawing.Color.DimGray;
            this.bias_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bias_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bias_update.ForeColor = System.Drawing.SystemColors.Control;
            this.bias_update.Location = new System.Drawing.Point(1130, 75);
            this.bias_update.Name = "bias_update";
            this.bias_update.Size = new System.Drawing.Size(185, 35);
            this.bias_update.TabIndex = 19;
            this.bias_update.Text = "Update Bias Values";
            this.bias_update.UseVisualStyleBackColor = false;
            this.bias_update.Click += new System.EventHandler(this.bias_update_Click);
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.BackColor = System.Drawing.SystemColors.Control;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.Color.RoyalBlue;
            this.input.Location = new System.Drawing.Point(44, 253);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(133, 25);
            this.input.TabIndex = 20;
            this.input.Text = "Input Values";
            // 
            // x1_input
            // 
            this.x1_input.AutoSize = true;
            this.x1_input.BackColor = System.Drawing.SystemColors.Control;
            this.x1_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1_input.ForeColor = System.Drawing.Color.RoyalBlue;
            this.x1_input.Location = new System.Drawing.Point(57, 288);
            this.x1_input.Name = "x1_input";
            this.x1_input.Size = new System.Drawing.Size(35, 25);
            this.x1_input.TabIndex = 22;
            this.x1_input.Text = "x1";
            // 
            // x1_tb
            // 
            this.x1_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1_tb.Location = new System.Drawing.Point(98, 286);
            this.x1_tb.Name = "x1_tb";
            this.x1_tb.Size = new System.Drawing.Size(103, 31);
            this.x1_tb.TabIndex = 21;
            this.x1_tb.Text = "0.05";
            // 
            // x2_input
            // 
            this.x2_input.AutoSize = true;
            this.x2_input.BackColor = System.Drawing.SystemColors.Control;
            this.x2_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2_input.ForeColor = System.Drawing.Color.RoyalBlue;
            this.x2_input.Location = new System.Drawing.Point(57, 327);
            this.x2_input.Name = "x2_input";
            this.x2_input.Size = new System.Drawing.Size(35, 25);
            this.x2_input.TabIndex = 24;
            this.x2_input.Text = "x2";
            // 
            // x2_tb
            // 
            this.x2_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2_tb.Location = new System.Drawing.Point(98, 325);
            this.x2_tb.Name = "x2_tb";
            this.x2_tb.Size = new System.Drawing.Size(103, 31);
            this.x2_tb.TabIndex = 23;
            this.x2_tb.Text = "0.10";
            // 
            // input_er
            // 
            this.input_er.AutoSize = true;
            this.input_er.BackColor = System.Drawing.Color.DimGray;
            this.input_er.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.input_er.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_er.ForeColor = System.Drawing.SystemColors.Control;
            this.input_er.Location = new System.Drawing.Point(98, 364);
            this.input_er.Name = "input_er";
            this.input_er.Size = new System.Drawing.Size(103, 35);
            this.input_er.TabIndex = 25;
            this.input_er.Text = "Enter";
            this.input_er.UseVisualStyleBackColor = false;
            this.input_er.Click += new System.EventHandler(this.input_er_Click);
            // 
            // output_er
            // 
            this.output_er.AutoSize = true;
            this.output_er.BackColor = System.Drawing.Color.DimGray;
            this.output_er.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.output_er.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_er.ForeColor = System.Drawing.SystemColors.Control;
            this.output_er.Location = new System.Drawing.Point(98, 559);
            this.output_er.Name = "output_er";
            this.output_er.Size = new System.Drawing.Size(103, 35);
            this.output_er.TabIndex = 31;
            this.output_er.Text = "Enter";
            this.output_er.UseVisualStyleBackColor = false;
            this.output_er.Click += new System.EventHandler(this.output_er_Click);
            // 
            // output_y2
            // 
            this.output_y2.AutoSize = true;
            this.output_y2.BackColor = System.Drawing.SystemColors.Control;
            this.output_y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_y2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.output_y2.Location = new System.Drawing.Point(57, 522);
            this.output_y2.Name = "output_y2";
            this.output_y2.Size = new System.Drawing.Size(35, 25);
            this.output_y2.TabIndex = 30;
            this.output_y2.Text = "y2";
            // 
            // y2_tb
            // 
            this.y2_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y2_tb.Location = new System.Drawing.Point(98, 520);
            this.y2_tb.Name = "y2_tb";
            this.y2_tb.Size = new System.Drawing.Size(103, 31);
            this.y2_tb.TabIndex = 29;
            this.y2_tb.Text = "0.99";
            // 
            // output_y1
            // 
            this.output_y1.AutoSize = true;
            this.output_y1.BackColor = System.Drawing.SystemColors.Control;
            this.output_y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_y1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.output_y1.Location = new System.Drawing.Point(57, 483);
            this.output_y1.Name = "output_y1";
            this.output_y1.Size = new System.Drawing.Size(35, 25);
            this.output_y1.TabIndex = 28;
            this.output_y1.Text = "y1";
            // 
            // y1_tb
            // 
            this.y1_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y1_tb.Location = new System.Drawing.Point(98, 481);
            this.y1_tb.Name = "y1_tb";
            this.y1_tb.Size = new System.Drawing.Size(103, 31);
            this.y1_tb.TabIndex = 27;
            this.y1_tb.Text = "0.01";
            // 
            // outputline1
            // 
            this.outputline1.AutoSize = true;
            this.outputline1.BackColor = System.Drawing.SystemColors.Control;
            this.outputline1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputline1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.outputline1.Location = new System.Drawing.Point(44, 423);
            this.outputline1.Name = "outputline1";
            this.outputline1.Size = new System.Drawing.Size(146, 25);
            this.outputline1.TabIndex = 26;
            this.outputline1.Text = "Target Output";
            // 
            // outputline2
            // 
            this.outputline2.AutoSize = true;
            this.outputline2.BackColor = System.Drawing.SystemColors.Control;
            this.outputline2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputline2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.outputline2.Location = new System.Drawing.Point(44, 448);
            this.outputline2.Name = "outputline2";
            this.outputline2.Size = new System.Drawing.Size(79, 25);
            this.outputline2.TabIndex = 32;
            this.outputline2.Text = "Values";
            // 
            // lr1
            // 
            this.lr1.AutoSize = true;
            this.lr1.BackColor = System.Drawing.SystemColors.Control;
            this.lr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lr1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lr1.Location = new System.Drawing.Point(44, 157);
            this.lr1.Name = "lr1";
            this.lr1.Size = new System.Drawing.Size(96, 25);
            this.lr1.TabIndex = 35;
            this.lr1.Text = "Learning";
            // 
            // lr_tb
            // 
            this.lr_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lr_tb.Location = new System.Drawing.Point(153, 155);
            this.lr_tb.Name = "lr_tb";
            this.lr_tb.Size = new System.Drawing.Size(103, 31);
            this.lr_tb.TabIndex = 34;
            this.lr_tb.Text = "0.0001";
            // 
            // lr_er
            // 
            this.lr_er.AutoSize = true;
            this.lr_er.BackColor = System.Drawing.Color.DimGray;
            this.lr_er.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lr_er.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lr_er.ForeColor = System.Drawing.SystemColors.Control;
            this.lr_er.Location = new System.Drawing.Point(153, 194);
            this.lr_er.Name = "lr_er";
            this.lr_er.Size = new System.Drawing.Size(103, 35);
            this.lr_er.TabIndex = 33;
            this.lr_er.Text = "Enter";
            this.lr_er.UseVisualStyleBackColor = false;
            this.lr_er.Click += new System.EventHandler(this.lr_er_Click);
            // 
            // lr2
            // 
            this.lr2.AutoSize = true;
            this.lr2.BackColor = System.Drawing.SystemColors.Control;
            this.lr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lr2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lr2.Location = new System.Drawing.Point(44, 182);
            this.lr2.Name = "lr2";
            this.lr2.Size = new System.Drawing.Size(56, 25);
            this.lr2.TabIndex = 36;
            this.lr2.Text = "Rate";
            // 
            // initialwl1
            // 
            this.initialwl1.AutoSize = true;
            this.initialwl1.BackColor = System.Drawing.SystemColors.Control;
            this.initialwl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialwl1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.initialwl1.Location = new System.Drawing.Point(218, 663);
            this.initialwl1.Name = "initialwl1";
            this.initialwl1.Size = new System.Drawing.Size(137, 25);
            this.initialwl1.TabIndex = 37;
            this.initialwl1.Text = "Initial Weight";
            // 
            // w1_tb
            // 
            this.w1_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w1_tb.Location = new System.Drawing.Point(379, 661);
            this.w1_tb.Name = "w1_tb";
            this.w1_tb.Size = new System.Drawing.Size(103, 31);
            this.w1_tb.TabIndex = 38;
            this.w1_tb.Text = "0.15";
            // 
            // w2_tb
            // 
            this.w2_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w2_tb.Location = new System.Drawing.Point(506, 661);
            this.w2_tb.Name = "w2_tb";
            this.w2_tb.Size = new System.Drawing.Size(103, 31);
            this.w2_tb.TabIndex = 39;
            this.w2_tb.Text = "0.25";
            // 
            // w4_tb
            // 
            this.w4_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w4_tb.Location = new System.Drawing.Point(760, 661);
            this.w4_tb.Name = "w4_tb";
            this.w4_tb.Size = new System.Drawing.Size(103, 31);
            this.w4_tb.TabIndex = 41;
            this.w4_tb.Text = "0.30";
            // 
            // w3_tb
            // 
            this.w3_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w3_tb.Location = new System.Drawing.Point(633, 661);
            this.w3_tb.Name = "w3_tb";
            this.w3_tb.Size = new System.Drawing.Size(103, 31);
            this.w3_tb.TabIndex = 40;
            this.w3_tb.Text = "0.20";
            // 
            // w8_tb
            // 
            this.w8_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w8_tb.Location = new System.Drawing.Point(1268, 661);
            this.w8_tb.Name = "w8_tb";
            this.w8_tb.Size = new System.Drawing.Size(103, 31);
            this.w8_tb.TabIndex = 45;
            this.w8_tb.Text = "0.55";
            // 
            // w7_tb
            // 
            this.w7_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w7_tb.Location = new System.Drawing.Point(1141, 661);
            this.w7_tb.Name = "w7_tb";
            this.w7_tb.Size = new System.Drawing.Size(103, 31);
            this.w7_tb.TabIndex = 44;
            this.w7_tb.Text = "0.45";
            // 
            // w6_tb
            // 
            this.w6_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w6_tb.Location = new System.Drawing.Point(1014, 661);
            this.w6_tb.Name = "w6_tb";
            this.w6_tb.Size = new System.Drawing.Size(103, 31);
            this.w6_tb.TabIndex = 43;
            this.w6_tb.Text = "0.50";
            // 
            // w5_tb
            // 
            this.w5_tb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w5_tb.Location = new System.Drawing.Point(887, 661);
            this.w5_tb.Name = "w5_tb";
            this.w5_tb.Size = new System.Drawing.Size(103, 31);
            this.w5_tb.TabIndex = 42;
            this.w5_tb.Text = "0.40";
            // 
            // iw1
            // 
            this.iw1.AutoSize = true;
            this.iw1.BackColor = System.Drawing.SystemColors.Control;
            this.iw1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iw1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iw1.Location = new System.Drawing.Point(411, 700);
            this.iw1.Name = "iw1";
            this.iw1.Size = new System.Drawing.Size(39, 25);
            this.iw1.TabIndex = 46;
            this.iw1.Text = "w1";
            // 
            // iw2
            // 
            this.iw2.AutoSize = true;
            this.iw2.BackColor = System.Drawing.SystemColors.Control;
            this.iw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iw2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iw2.Location = new System.Drawing.Point(538, 700);
            this.iw2.Name = "iw2";
            this.iw2.Size = new System.Drawing.Size(39, 25);
            this.iw2.TabIndex = 47;
            this.iw2.Text = "w2";
            // 
            // iw4
            // 
            this.iw4.AutoSize = true;
            this.iw4.BackColor = System.Drawing.SystemColors.Control;
            this.iw4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iw4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iw4.Location = new System.Drawing.Point(792, 700);
            this.iw4.Name = "iw4";
            this.iw4.Size = new System.Drawing.Size(39, 25);
            this.iw4.TabIndex = 49;
            this.iw4.Text = "w4";
            // 
            // iw3
            // 
            this.iw3.AutoSize = true;
            this.iw3.BackColor = System.Drawing.SystemColors.Control;
            this.iw3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iw3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iw3.Location = new System.Drawing.Point(665, 700);
            this.iw3.Name = "iw3";
            this.iw3.Size = new System.Drawing.Size(39, 25);
            this.iw3.TabIndex = 48;
            this.iw3.Text = "w3";
            // 
            // iw8
            // 
            this.iw8.AutoSize = true;
            this.iw8.BackColor = System.Drawing.SystemColors.Control;
            this.iw8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iw8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iw8.Location = new System.Drawing.Point(1300, 700);
            this.iw8.Name = "iw8";
            this.iw8.Size = new System.Drawing.Size(39, 25);
            this.iw8.TabIndex = 53;
            this.iw8.Text = "w8";
            // 
            // iw7
            // 
            this.iw7.AutoSize = true;
            this.iw7.BackColor = System.Drawing.SystemColors.Control;
            this.iw7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iw7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iw7.Location = new System.Drawing.Point(1173, 700);
            this.iw7.Name = "iw7";
            this.iw7.Size = new System.Drawing.Size(39, 25);
            this.iw7.TabIndex = 52;
            this.iw7.Text = "w7";
            // 
            // iw6
            // 
            this.iw6.AutoSize = true;
            this.iw6.BackColor = System.Drawing.SystemColors.Control;
            this.iw6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iw6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iw6.Location = new System.Drawing.Point(1046, 700);
            this.iw6.Name = "iw6";
            this.iw6.Size = new System.Drawing.Size(39, 25);
            this.iw6.TabIndex = 51;
            this.iw6.Text = "w6";
            // 
            // iw5
            // 
            this.iw5.AutoSize = true;
            this.iw5.BackColor = System.Drawing.SystemColors.Control;
            this.iw5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iw5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iw5.Location = new System.Drawing.Point(919, 700);
            this.iw5.Name = "iw5";
            this.iw5.Size = new System.Drawing.Size(39, 25);
            this.iw5.TabIndex = 50;
            this.iw5.Text = "w5";
            // 
            // initialwl2
            // 
            this.initialwl2.AutoSize = true;
            this.initialwl2.BackColor = System.Drawing.SystemColors.Control;
            this.initialwl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialwl2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.initialwl2.Location = new System.Drawing.Point(218, 688);
            this.initialwl2.Name = "initialwl2";
            this.initialwl2.Size = new System.Drawing.Size(79, 25);
            this.initialwl2.TabIndex = 54;
            this.initialwl2.Text = "Values";
            // 
            // weight_update
            // 
            this.weight_update.AutoSize = true;
            this.weight_update.BackColor = System.Drawing.Color.DimGray;
            this.weight_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.weight_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_update.ForeColor = System.Drawing.SystemColors.Control;
            this.weight_update.Location = new System.Drawing.Point(792, 733);
            this.weight_update.Name = "weight_update";
            this.weight_update.Size = new System.Drawing.Size(205, 35);
            this.weight_update.TabIndex = 55;
            this.weight_update.Text = "Update Weight Values";
            this.weight_update.UseVisualStyleBackColor = false;
            this.weight_update.Click += new System.EventHandler(this.weight_update_Click);
            // 
            // Dx1Name
            // 
            this.Dx1Name.AutoSize = true;
            this.Dx1Name.BackColor = System.Drawing.SystemColors.Control;
            this.Dx1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dx1Name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dx1Name.Location = new System.Drawing.Point(328, 243);
            this.Dx1Name.Name = "Dx1Name";
            this.Dx1Name.Size = new System.Drawing.Size(35, 25);
            this.Dx1Name.TabIndex = 56;
            this.Dx1Name.Text = "x1";
            // 
            // Dx2Name
            // 
            this.Dx2Name.AutoSize = true;
            this.Dx2Name.BackColor = System.Drawing.SystemColors.Control;
            this.Dx2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dx2Name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dx2Name.Location = new System.Drawing.Point(328, 498);
            this.Dx2Name.Name = "Dx2Name";
            this.Dx2Name.Size = new System.Drawing.Size(35, 25);
            this.Dx2Name.TabIndex = 57;
            this.Dx2Name.Text = "x2";
            // 
            // Db1Name
            // 
            this.Db1Name.AutoSize = true;
            this.Db1Name.BackColor = System.Drawing.SystemColors.Control;
            this.Db1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Db1Name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Db1Name.Location = new System.Drawing.Point(519, 155);
            this.Db1Name.Name = "Db1Name";
            this.Db1Name.Size = new System.Drawing.Size(36, 25);
            this.Db1Name.TabIndex = 58;
            this.Db1Name.Text = "b1";
            // 
            // Db3Name
            // 
            this.Db3Name.AutoSize = true;
            this.Db3Name.BackColor = System.Drawing.SystemColors.Control;
            this.Db3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Db3Name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Db3Name.Location = new System.Drawing.Point(712, 155);
            this.Db3Name.Name = "Db3Name";
            this.Db3Name.Size = new System.Drawing.Size(36, 25);
            this.Db3Name.TabIndex = 59;
            this.Db3Name.Text = "b3";
            // 
            // Db2Name
            // 
            this.Db2Name.AutoSize = true;
            this.Db2Name.BackColor = System.Drawing.SystemColors.Control;
            this.Db2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Db2Name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Db2Name.Location = new System.Drawing.Point(519, 593);
            this.Db2Name.Name = "Db2Name";
            this.Db2Name.Size = new System.Drawing.Size(36, 25);
            this.Db2Name.TabIndex = 60;
            this.Db2Name.Text = "b2";
            // 
            // Db4Name
            // 
            this.Db4Name.AutoSize = true;
            this.Db4Name.BackColor = System.Drawing.SystemColors.Control;
            this.Db4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Db4Name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Db4Name.Location = new System.Drawing.Point(712, 593);
            this.Db4Name.Name = "Db4Name";
            this.Db4Name.Size = new System.Drawing.Size(36, 25);
            this.Db4Name.TabIndex = 61;
            this.Db4Name.Text = "b4";
            // 
            // Dy1Name
            // 
            this.Dy1Name.AutoSize = true;
            this.Dy1Name.BackColor = System.Drawing.SystemColors.Control;
            this.Dy1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dy1Name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dy1Name.Location = new System.Drawing.Point(830, 243);
            this.Dy1Name.Name = "Dy1Name";
            this.Dy1Name.Size = new System.Drawing.Size(35, 25);
            this.Dy1Name.TabIndex = 62;
            this.Dy1Name.Text = "y1";
            // 
            // Dy2Name
            // 
            this.Dy2Name.AutoSize = true;
            this.Dy2Name.BackColor = System.Drawing.SystemColors.Control;
            this.Dy2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dy2Name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dy2Name.Location = new System.Drawing.Point(830, 498);
            this.Dy2Name.Name = "Dy2Name";
            this.Dy2Name.Size = new System.Drawing.Size(35, 25);
            this.Dy2Name.TabIndex = 63;
            this.Dy2Name.Text = "y2";
            // 
            // Dw1
            // 
            this.Dw1.AutoSize = true;
            this.Dw1.BackColor = System.Drawing.SystemColors.Control;
            this.Dw1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dw1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dw1.Location = new System.Drawing.Point(447, 231);
            this.Dw1.Name = "Dw1";
            this.Dw1.Size = new System.Drawing.Size(94, 25);
            this.Dw1.TabIndex = 64;
            this.Dw1.Text = "w1=0.15";
            // 
            // Dw2
            // 
            this.Dw2.AutoSize = true;
            this.Dw2.BackColor = System.Drawing.SystemColors.Control;
            this.Dw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dw2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dw2.Location = new System.Drawing.Point(355, 325);
            this.Dw2.Name = "Dw2";
            this.Dw2.Size = new System.Drawing.Size(94, 25);
            this.Dw2.TabIndex = 65;
            this.Dw2.Text = "w2=0.25";
            // 
            // Dw5
            // 
            this.Dw5.AutoSize = true;
            this.Dw5.BackColor = System.Drawing.SystemColors.Control;
            this.Dw5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dw5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dw5.Location = new System.Drawing.Point(638, 231);
            this.Dw5.Name = "Dw5";
            this.Dw5.Size = new System.Drawing.Size(94, 25);
            this.Dw5.TabIndex = 66;
            this.Dw5.Text = "w5=0.40";
            // 
            // Dw3
            // 
            this.Dw3.AutoSize = true;
            this.Dw3.BackColor = System.Drawing.SystemColors.Control;
            this.Dw3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dw3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dw3.Location = new System.Drawing.Point(355, 423);
            this.Dw3.Name = "Dw3";
            this.Dw3.Size = new System.Drawing.Size(94, 25);
            this.Dw3.TabIndex = 67;
            this.Dw3.Text = "w3=0.20";
            // 
            // Dw4
            // 
            this.Dw4.AutoSize = true;
            this.Dw4.BackColor = System.Drawing.SystemColors.Control;
            this.Dw4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dw4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dw4.Location = new System.Drawing.Point(447, 522);
            this.Dw4.Name = "Dw4";
            this.Dw4.Size = new System.Drawing.Size(94, 25);
            this.Dw4.TabIndex = 68;
            this.Dw4.Text = "w4=0.30";
            // 
            // Dw7
            // 
            this.Dw7.AutoSize = true;
            this.Dw7.BackColor = System.Drawing.SystemColors.Control;
            this.Dw7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dw7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dw7.Location = new System.Drawing.Point(730, 325);
            this.Dw7.Name = "Dw7";
            this.Dw7.Size = new System.Drawing.Size(94, 25);
            this.Dw7.TabIndex = 69;
            this.Dw7.Text = "w7=0.45";
            // 
            // Dw6
            // 
            this.Dw6.AutoSize = true;
            this.Dw6.BackColor = System.Drawing.SystemColors.Control;
            this.Dw6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dw6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dw6.Location = new System.Drawing.Point(730, 423);
            this.Dw6.Name = "Dw6";
            this.Dw6.Size = new System.Drawing.Size(94, 25);
            this.Dw6.TabIndex = 70;
            this.Dw6.Text = "w6=0.50";
            // 
            // Dh1Name
            // 
            this.Dh1Name.AutoSize = true;
            this.Dh1Name.BackColor = System.Drawing.SystemColors.Control;
            this.Dh1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dh1Name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dh1Name.Location = new System.Drawing.Point(574, 295);
            this.Dh1Name.Name = "Dh1Name";
            this.Dh1Name.Size = new System.Drawing.Size(39, 25);
            this.Dh1Name.TabIndex = 71;
            this.Dh1Name.Text = "H1";
            // 
            // Dh2Name
            // 
            this.Dh2Name.AutoSize = true;
            this.Dh2Name.BackColor = System.Drawing.SystemColors.Control;
            this.Dh2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dh2Name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dh2Name.Location = new System.Drawing.Point(570, 456);
            this.Dh2Name.Name = "Dh2Name";
            this.Dh2Name.Size = new System.Drawing.Size(39, 25);
            this.Dh2Name.TabIndex = 72;
            this.Dh2Name.Text = "H2";
            // 
            // Dh1
            // 
            this.Dh1.AutoSize = true;
            this.Dh1.BackColor = System.Drawing.SystemColors.Control;
            this.Dh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dh1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dh1.Location = new System.Drawing.Point(568, 246);
            this.Dh1.Name = "Dh1";
            this.Dh1.Size = new System.Drawing.Size(38, 24);
            this.Dh1.TabIndex = 73;
            this.Dh1.Text = "0.0";
            // 
            // Dh2
            // 
            this.Dh2.AutoSize = true;
            this.Dh2.BackColor = System.Drawing.SystemColors.Control;
            this.Dh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dh2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dh2.Location = new System.Drawing.Point(568, 506);
            this.Dh2.Name = "Dh2";
            this.Dh2.Size = new System.Drawing.Size(38, 24);
            this.Dh2.TabIndex = 74;
            this.Dh2.Text = "0.0";
            // 
            // Dy1
            // 
            this.Dy1.AutoSize = true;
            this.Dy1.BackColor = System.Drawing.SystemColors.Control;
            this.Dy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dy1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dy1.Location = new System.Drawing.Point(761, 246);
            this.Dy1.Name = "Dy1";
            this.Dy1.Size = new System.Drawing.Size(38, 24);
            this.Dy1.TabIndex = 75;
            this.Dy1.Text = "0.0";
            // 
            // Dy2
            // 
            this.Dy2.AutoSize = true;
            this.Dy2.BackColor = System.Drawing.SystemColors.Control;
            this.Dy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dy2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dy2.Location = new System.Drawing.Point(761, 506);
            this.Dy2.Name = "Dy2";
            this.Dy2.Size = new System.Drawing.Size(38, 24);
            this.Dy2.TabIndex = 76;
            this.Dy2.Text = "0.0";
            // 
            // Dw8
            // 
            this.Dw8.AutoSize = true;
            this.Dw8.BackColor = System.Drawing.SystemColors.Control;
            this.Dw8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dw8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dw8.Location = new System.Drawing.Point(638, 522);
            this.Dw8.Name = "Dw8";
            this.Dw8.Size = new System.Drawing.Size(94, 25);
            this.Dw8.TabIndex = 77;
            this.Dw8.Text = "w8=0.55";
            // 
            // Dx1
            // 
            this.Dx1.AutoSize = true;
            this.Dx1.BackColor = System.Drawing.SystemColors.Control;
            this.Dx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dx1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dx1.Location = new System.Drawing.Point(375, 247);
            this.Dx1.Name = "Dx1";
            this.Dx1.Size = new System.Drawing.Size(49, 24);
            this.Dx1.TabIndex = 78;
            this.Dx1.Text = "0.05";
            // 
            // Dx2
            // 
            this.Dx2.AutoSize = true;
            this.Dx2.BackColor = System.Drawing.SystemColors.Control;
            this.Dx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dx2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Dx2.Location = new System.Drawing.Point(375, 506);
            this.Dx2.Name = "Dx2";
            this.Dx2.Size = new System.Drawing.Size(49, 24);
            this.Dx2.TabIndex = 79;
            this.Dx2.Text = "0.10";
            // 
            // Db1
            // 
            this.Db1.AutoSize = true;
            this.Db1.BackColor = System.Drawing.SystemColors.Control;
            this.Db1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Db1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Db1.Location = new System.Drawing.Point(568, 161);
            this.Db1.Name = "Db1";
            this.Db1.Size = new System.Drawing.Size(49, 24);
            this.Db1.TabIndex = 80;
            this.Db1.Text = "0.35";
            // 
            // Db3
            // 
            this.Db3.AutoSize = true;
            this.Db3.BackColor = System.Drawing.SystemColors.Control;
            this.Db3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Db3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Db3.Location = new System.Drawing.Point(761, 161);
            this.Db3.Name = "Db3";
            this.Db3.Size = new System.Drawing.Size(49, 24);
            this.Db3.TabIndex = 81;
            this.Db3.Text = "0.60";
            // 
            // Db2
            // 
            this.Db2.AutoSize = true;
            this.Db2.BackColor = System.Drawing.SystemColors.Control;
            this.Db2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Db2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Db2.Location = new System.Drawing.Point(568, 591);
            this.Db2.Name = "Db2";
            this.Db2.Size = new System.Drawing.Size(49, 24);
            this.Db2.TabIndex = 82;
            this.Db2.Text = "0.35";
            // 
            // Db4
            // 
            this.Db4.AutoSize = true;
            this.Db4.BackColor = System.Drawing.SystemColors.Control;
            this.Db4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Db4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Db4.Location = new System.Drawing.Point(761, 591);
            this.Db4.Name = "Db4";
            this.Db4.Size = new System.Drawing.Size(49, 24);
            this.Db4.TabIndex = 83;
            this.Db4.Text = "0.60";
            // 
            // Iteration_Status
            // 
            this.Iteration_Status.Location = new System.Drawing.Point(958, 184);
            this.Iteration_Status.Name = "Iteration_Status";
            this.Iteration_Status.Size = new System.Drawing.Size(478, 23);
            this.Iteration_Status.TabIndex = 84;
            // 
            // Simulation_Progress_Name
            // 
            this.Simulation_Progress_Name.AutoSize = true;
            this.Simulation_Progress_Name.BackColor = System.Drawing.SystemColors.Control;
            this.Simulation_Progress_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Simulation_Progress_Name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Simulation_Progress_Name.Location = new System.Drawing.Point(1086, 156);
            this.Simulation_Progress_Name.Name = "Simulation_Progress_Name";
            this.Simulation_Progress_Name.Size = new System.Drawing.Size(205, 25);
            this.Simulation_Progress_Name.TabIndex = 85;
            this.Simulation_Progress_Name.Text = "Simulation Progress";
            // 
            // Iteration_Handler
            // 
            this.Iteration_Handler.WorkerReportsProgress = true;
            this.Iteration_Handler.WorkerSupportsCancellation = true;
            this.Iteration_Handler.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Iteration_Handler_DoWork);
            this.Iteration_Handler.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Iteration_Handler_ProgressChanged);
            this.Iteration_Handler.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Iteration_Handler_RunWorkerCompleted);
            // 
            // Sim_Duration
            // 
            this.Sim_Duration.AutoSize = true;
            this.Sim_Duration.BackColor = System.Drawing.SystemColors.Control;
            this.Sim_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sim_Duration.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Sim_Duration.Location = new System.Drawing.Point(953, 210);
            this.Sim_Duration.Name = "Sim_Duration";
            this.Sim_Duration.Size = new System.Drawing.Size(285, 20);
            this.Sim_Duration.TabIndex = 86;
            this.Sim_Duration.Text = "Simulation Duration: 00:00:00:00";
            // 
            // Err_Acc_Chart
            // 
            chartArea3.Name = "ChartArea1";
            this.Err_Acc_Chart.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.Err_Acc_Chart.Legends.Add(legend3);
            this.Err_Acc_Chart.Location = new System.Drawing.Point(958, 283);
            this.Err_Acc_Chart.Name = "Err_Acc_Chart";
            this.Err_Acc_Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "error";
            this.Err_Acc_Chart.Series.Add(series3);
            this.Err_Acc_Chart.Size = new System.Drawing.Size(478, 320);
            this.Err_Acc_Chart.TabIndex = 87;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1512, 798);
            this.Controls.Add(this.Err_Acc_Chart);
            this.Controls.Add(this.Sim_Duration);
            this.Controls.Add(this.Simulation_Progress_Name);
            this.Controls.Add(this.Iteration_Status);
            this.Controls.Add(this.Db4);
            this.Controls.Add(this.Db2);
            this.Controls.Add(this.Db3);
            this.Controls.Add(this.Db1);
            this.Controls.Add(this.Dx2);
            this.Controls.Add(this.Dx1);
            this.Controls.Add(this.Dw8);
            this.Controls.Add(this.Dy2);
            this.Controls.Add(this.Dy1);
            this.Controls.Add(this.Dh2);
            this.Controls.Add(this.Dh1);
            this.Controls.Add(this.Dh2Name);
            this.Controls.Add(this.Dh1Name);
            this.Controls.Add(this.Dw6);
            this.Controls.Add(this.Dw7);
            this.Controls.Add(this.Dw4);
            this.Controls.Add(this.Dw3);
            this.Controls.Add(this.Dw5);
            this.Controls.Add(this.Dw2);
            this.Controls.Add(this.Dw1);
            this.Controls.Add(this.Dy2Name);
            this.Controls.Add(this.Dy1Name);
            this.Controls.Add(this.Db4Name);
            this.Controls.Add(this.Db2Name);
            this.Controls.Add(this.Db3Name);
            this.Controls.Add(this.Db1Name);
            this.Controls.Add(this.Dx2Name);
            this.Controls.Add(this.Dx1Name);
            this.Controls.Add(this.weight_update);
            this.Controls.Add(this.initialwl2);
            this.Controls.Add(this.iw8);
            this.Controls.Add(this.iw7);
            this.Controls.Add(this.iw6);
            this.Controls.Add(this.iw5);
            this.Controls.Add(this.iw4);
            this.Controls.Add(this.iw3);
            this.Controls.Add(this.iw2);
            this.Controls.Add(this.iw1);
            this.Controls.Add(this.w8_tb);
            this.Controls.Add(this.w7_tb);
            this.Controls.Add(this.w6_tb);
            this.Controls.Add(this.w5_tb);
            this.Controls.Add(this.w4_tb);
            this.Controls.Add(this.w3_tb);
            this.Controls.Add(this.w2_tb);
            this.Controls.Add(this.w1_tb);
            this.Controls.Add(this.initialwl1);
            this.Controls.Add(this.lr2);
            this.Controls.Add(this.lr1);
            this.Controls.Add(this.lr_tb);
            this.Controls.Add(this.lr_er);
            this.Controls.Add(this.outputline2);
            this.Controls.Add(this.output_er);
            this.Controls.Add(this.output_y2);
            this.Controls.Add(this.y2_tb);
            this.Controls.Add(this.output_y1);
            this.Controls.Add(this.y1_tb);
            this.Controls.Add(this.outputline1);
            this.Controls.Add(this.input_er);
            this.Controls.Add(this.x2_input);
            this.Controls.Add(this.x2_tb);
            this.Controls.Add(this.x1_input);
            this.Controls.Add(this.x1_tb);
            this.Controls.Add(this.input);
            this.Controls.Add(this.bias_update);
            this.Controls.Add(this.bias_b4);
            this.Controls.Add(this.bias_b3);
            this.Controls.Add(this.b3_tb);
            this.Controls.Add(this.b4_tb);
            this.Controls.Add(this.bias_b2);
            this.Controls.Add(this.bias_b1);
            this.Controls.Add(this.b1_tb);
            this.Controls.Add(this.b2_tb);
            this.Controls.Add(this.bias_values);
            this.Controls.Add(this.simulation);
            this.Controls.Add(this.sim_abort);
            this.Controls.Add(this.sim_update);
            this.Controls.Add(this.sim_start);
            this.Controls.Add(this.epochs);
            this.Controls.Add(this.epochs_tb);
            this.Controls.Add(this.epochs_er);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "AI Neural Network Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Err_Acc_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button epochs_er;
        private System.Windows.Forms.TextBox epochs_tb;
        private System.Windows.Forms.Label epochs;
        private System.Windows.Forms.Button sim_start;
        private System.Windows.Forms.Button sim_update;
        private System.Windows.Forms.Button sim_abort;
        private System.Windows.Forms.Label simulation;
        private System.Windows.Forms.Label bias_values;
        private System.Windows.Forms.TextBox b2_tb;
        private System.Windows.Forms.TextBox b1_tb;
        private System.Windows.Forms.Label bias_b1;
        private System.Windows.Forms.Label bias_b2;
        private System.Windows.Forms.Label bias_b4;
        private System.Windows.Forms.Label bias_b3;
        private System.Windows.Forms.TextBox b3_tb;
        private System.Windows.Forms.TextBox b4_tb;
        private System.Windows.Forms.Button bias_update;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Label x1_input;
        private System.Windows.Forms.TextBox x1_tb;
        private System.Windows.Forms.Label x2_input;
        private System.Windows.Forms.TextBox x2_tb;
        private System.Windows.Forms.Button input_er;
        private System.Windows.Forms.Button output_er;
        private System.Windows.Forms.Label output_y2;
        private System.Windows.Forms.TextBox y2_tb;
        private System.Windows.Forms.Label output_y1;
        private System.Windows.Forms.TextBox y1_tb;
        private System.Windows.Forms.Label outputline1;
        private System.Windows.Forms.Label outputline2;
        private System.Windows.Forms.Label lr1;
        private System.Windows.Forms.TextBox lr_tb;
        private System.Windows.Forms.Button lr_er;
        private System.Windows.Forms.Label lr2;
        private System.Windows.Forms.Label initialwl1;
        private System.Windows.Forms.TextBox w1_tb;
        private System.Windows.Forms.TextBox w2_tb;
        private System.Windows.Forms.TextBox w4_tb;
        private System.Windows.Forms.TextBox w3_tb;
        private System.Windows.Forms.TextBox w8_tb;
        private System.Windows.Forms.TextBox w7_tb;
        private System.Windows.Forms.TextBox w6_tb;
        private System.Windows.Forms.TextBox w5_tb;
        private System.Windows.Forms.Label iw1;
        private System.Windows.Forms.Label iw2;
        private System.Windows.Forms.Label iw4;
        private System.Windows.Forms.Label iw3;
        private System.Windows.Forms.Label iw8;
        private System.Windows.Forms.Label iw7;
        private System.Windows.Forms.Label iw6;
        private System.Windows.Forms.Label iw5;
        private System.Windows.Forms.Label initialwl2;
        private System.Windows.Forms.Button weight_update;
        private System.Windows.Forms.Label Dx1Name;
        private System.Windows.Forms.Label Dx2Name;
        private System.Windows.Forms.Label Db1Name;
        private System.Windows.Forms.Label Db3Name;
        private System.Windows.Forms.Label Db2Name;
        private System.Windows.Forms.Label Db4Name;
        private System.Windows.Forms.Label Dy1Name;
        private System.Windows.Forms.Label Dy2Name;
        private System.Windows.Forms.Label Dw1;
        private System.Windows.Forms.Label Dw2;
        private System.Windows.Forms.Label Dw5;
        private System.Windows.Forms.Label Dw3;
        private System.Windows.Forms.Label Dw4;
        private System.Windows.Forms.Label Dw7;
        private System.Windows.Forms.Label Dw6;
        private System.Windows.Forms.Label Dh1Name;
        private System.Windows.Forms.Label Dh2Name;
        private System.Windows.Forms.Label Dh1;
        private System.Windows.Forms.Label Dh2;
        private System.Windows.Forms.Label Dy1;
        private System.Windows.Forms.Label Dy2;
        private System.Windows.Forms.Label Dw8;
        private System.Windows.Forms.Label Dx1;
        private System.Windows.Forms.Label Dx2;
        private System.Windows.Forms.Label Db1;
        private System.Windows.Forms.Label Db3;
        private System.Windows.Forms.Label Db2;
        private System.Windows.Forms.Label Db4;
        private System.Windows.Forms.ProgressBar Iteration_Status;
        private System.Windows.Forms.Label Simulation_Progress_Name;
        private System.ComponentModel.BackgroundWorker Iteration_Handler;
        private System.Windows.Forms.Label Sim_Duration;
        private System.Windows.Forms.DataVisualization.Charting.Chart Err_Acc_Chart;
    }
}

