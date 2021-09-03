using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIComputingGraphics
{
    public partial class Form1 : Form
    {

        //Own Global Variables
        public static uint No_of_Inputs = 2;   //This value is always fixed, do not change this
        public static uint No_of_Outputs = 2;  //This value is always fixed, do not change this
        public static uint No_of_HNlayer = 1;  //This value is always fixed, do not change this

        public static uint TotalNeu_Circle_Create_Line = (1 + No_of_HNlayer) * No_of_Inputs;
        public static uint No_of_Rows = No_of_Inputs;
        public static uint TotalNeu_Line = TotalNeu_Circle_Create_Line * No_of_Rows;


        //Neural Variables
        public static float[] Inputs = new float[No_of_Inputs];
        public static float[] Target_Outputs = new float[No_of_Outputs];
        public static float[] Current_Outputs = new float[No_of_Outputs];
        public static float[,] HNlayer_Circle = new float[No_of_HNlayer, No_of_Inputs];
        public static float[] Weights = new float[TotalNeu_Line];
        public static float Total_Error = 0;

        //User Neural Network Control Variables with Demo Values
        public static uint EPOCHS = 1000000;
        public static float L_Rate = 0.0001F;
        public static float Neu_b1 = 0.0F;
        public static float Neu_b2 = 0.0F;
        public static float Neu_b3 = 0.99F;
        public static float Neu_b4 = 0.0F;

        //Other Variables
        public static DateTime SimStart_Time = DateTime.Now;

        public Form1()
        {
            InitializeComponent();

            //Input Values - Demo
            Inputs[0] = 0.05F;
            Inputs[1] = 0.1F;

            //Target Output Values - Demo
            Target_Outputs[0] = 0.01F;
            Target_Outputs[1] = 0.99F;

            //Initial Weights Values - Demo
            Weights[0] = 0.15F;
            Weights[1] = 0.25F;
            Weights[2] = 0.20F;
            Weights[3] = 0.30F;
            Weights[4] = 0.40F;
            Weights[5] = 0.50F;
            Weights[6] = 0.45F;
            Weights[7] = 0.55F;

            UpdateDiaVariables();

            //Chart Configuration
            Err_Acc_Chart.Titles.Add("Error and Accuracy Plot").Font = new Font("Arial", 10, FontStyle.Bold);
            //X axis
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisX.Title = "EPOCHS";
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisX.TitleAlignment = StringAlignment.Center;
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Auto;
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial", 8, FontStyle.Bold);
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisX.Maximum = 10;
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //Y axis
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisY.Title = "ERROR";
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisY.TitleAlignment = StringAlignment.Center;
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Auto;
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial", 8, FontStyle.Bold);
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            Err_Acc_Chart.ChartAreas["ChartArea1"].AxisY.Maximum = 1;

            Err_Acc_Chart.Series["error"].BorderWidth = 3;
        }
        void UpdateDiaVariables()
        {
            Dx1.Text = decimal.Round((decimal)Inputs[0], 2, MidpointRounding.AwayFromZero).ToString();
            Dx2.Text = decimal.Round((decimal)Inputs[1], 2, MidpointRounding.AwayFromZero).ToString();
            Db1.Text = decimal.Round((decimal)Neu_b1, 2, MidpointRounding.AwayFromZero).ToString();
            Db2.Text = decimal.Round((decimal)Neu_b2, 2, MidpointRounding.AwayFromZero).ToString();
            Db3.Text = decimal.Round((decimal)Neu_b3, 2, MidpointRounding.AwayFromZero).ToString();
            Db4.Text = decimal.Round((decimal)Neu_b4, 2, MidpointRounding.AwayFromZero).ToString();
            Dw1.Text = "w1=" + (decimal.Round((decimal)Weights[0], 2, MidpointRounding.AwayFromZero).ToString());
            Dw2.Text = "w2=" + (decimal.Round((decimal)Weights[1], 2, MidpointRounding.AwayFromZero).ToString());
            Dw3.Text = "w3=" + (decimal.Round((decimal)Weights[2], 2, MidpointRounding.AwayFromZero).ToString());
            Dw4.Text = "w4=" + (decimal.Round((decimal)Weights[3], 2, MidpointRounding.AwayFromZero).ToString());
            Dw5.Text = "w5=" + (decimal.Round((decimal)Weights[4], 2, MidpointRounding.AwayFromZero).ToString());
            Dw6.Text = "w6=" + (decimal.Round((decimal)Weights[5], 2, MidpointRounding.AwayFromZero).ToString());
            Dw7.Text = "w7=" + (decimal.Round((decimal)Weights[6], 2, MidpointRounding.AwayFromZero).ToString());
            Dw8.Text = "w8=" + (decimal.Round((decimal)Weights[7], 2, MidpointRounding.AwayFromZero).ToString());
            Dh1.Text = decimal.Round((decimal)HNlayer_Circle[No_of_HNlayer - 1, 0], 2, MidpointRounding.AwayFromZero).ToString();
            Dh2.Text = decimal.Round((decimal)HNlayer_Circle[No_of_HNlayer - 1, 1], 2, MidpointRounding.AwayFromZero).ToString();
            Dy1.Text = decimal.Round((decimal)Current_Outputs[0], 2, MidpointRounding.AwayFromZero).ToString();
            Dy2.Text = decimal.Round((decimal)Current_Outputs[1], 2, MidpointRounding.AwayFromZero).ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int Form_Width = 1530;
            int Form_Height = 845;
            float OrginPt_X = 0;
            float OrginPt_Y = 0;
            int NeuCircle_Width = 45;
            int NeuCircle_Height = 45;
            int NeuLine_Length = 100;
            Brush Val_Brush;
            Color Val_Colour = Color.FromName("DarkGreen");
            Val_Brush = new SolidBrush(Val_Colour);

            int l = 0;
            float[,] NeuCircle_Indexes = new float[6, 2];
            if (No_of_Inputs == No_of_Outputs)
            {
                for (int j = 0; j < No_of_Inputs; j++) //For Row Creation
                {
                    //Columns of Neural Circle Creation
                    for (int i = 0; i < (No_of_HNlayer + 2); i++)
                    {
                        OrginPt_X = ((float)Form_Width / 5.5F) + ((NeuCircle_Width + NeuLine_Length) * i);
                        OrginPt_Y = ((float)Form_Height / 4.5F) + ((Form_Height / 8) * 2 * j);

                        g.DrawEllipse(Pens.DarkBlue, OrginPt_X, OrginPt_Y, NeuCircle_Width, NeuCircle_Height);
                        NeuCircle_Indexes[l, 0] = OrginPt_X;
                        NeuCircle_Indexes[l, 1] = OrginPt_Y;
                        l++;
                    }
                }

                float[,,] NeuLine_Indexes = new float[2, No_of_Inputs, (No_of_HNlayer * 2) + 2];
                //Neural Straight line Creation
                for (int j = 0; j < No_of_Inputs; j++)
                {
                    //Columns of Neural link Creation
                    for (int i = 0; i < (2 + (No_of_HNlayer - 1)); i++)
                    {
                        OrginPt_X = ((float)Form_Width / 5.5F) + ((NeuCircle_Width + NeuLine_Length) * i);
                        OrginPt_Y = ((float)Form_Height / 4.5F) + ((Form_Height / 8) * 2 * j);

                        g.DrawLine(Pens.DarkGreen, OrginPt_X + NeuCircle_Width, OrginPt_Y + (NeuCircle_Height / 2), (OrginPt_X + NeuCircle_Width) + NeuLine_Length, OrginPt_Y + (NeuCircle_Height / 2));

                        NeuLine_Indexes[0, j, (i * 2)] = OrginPt_X + NeuCircle_Width;
                        NeuLine_Indexes[1, j, (i * 2)] = OrginPt_Y + (NeuCircle_Height / 2);
                        NeuLine_Indexes[0, j, (i * 2) + 1] = (OrginPt_X + NeuCircle_Width) + NeuLine_Length;
                        NeuLine_Indexes[1, j, (i * 2) + 1] = OrginPt_Y + (NeuCircle_Height / 2);

                    }
                }
                //Neural Cross lines Creation
                for (int j = 0; j < No_of_Inputs; j++)
                {
                    for (int i = 0; i < (No_of_HNlayer * 2) + 2; i = i + 2)
                    {
                        int temp = i + 1;
                        for (int k = 0; k < No_of_Inputs; k++)
                        {
                            if (k != j)
                            {
                                g.DrawLine(Pens.DarkGreen, NeuLine_Indexes[0, j, i], NeuLine_Indexes[1, j, i], NeuLine_Indexes[0, k, temp], NeuLine_Indexes[1, k, temp]);
                            }
                        }
                    }
                }
                //Bias Neural Line and Circle Creation
                for (int i = 0; i < 6; i++)
                {
                    if ((i == 1) || (i == 2))
                    {
                        g.DrawLine(Pens.DarkGreen, NeuCircle_Indexes[i, 0] + (45 / 2), NeuCircle_Indexes[i, 1], NeuCircle_Indexes[i, 0] + (45 / 2), NeuCircle_Indexes[i, 1] - 25);
                        g.DrawEllipse(Pens.DarkBlue, NeuCircle_Indexes[i, 0], NeuCircle_Indexes[i, 1] - 25 - NeuCircle_Height, NeuCircle_Width, NeuCircle_Height);
                    }
                    if ((i == 4) || (i == 5))
                    {
                        g.DrawLine(Pens.DarkGreen, NeuCircle_Indexes[i, 0] + (45 / 2), NeuCircle_Indexes[i, 1] + 45, NeuCircle_Indexes[i, 0] + (45 / 2), NeuCircle_Indexes[i, 1] + 45 + 25);
                        g.DrawEllipse(Pens.DarkBlue, NeuCircle_Indexes[i, 0], NeuCircle_Indexes[i, 1] + 45 + 25, NeuCircle_Width, NeuCircle_Height);
                    }
                }
                Val_Brush.Dispose();
            }
            else
            {
                //number of inputs and outputs are different
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == '\b')
            {
                return;
            }
            if ((int)e.KeyChar == '.')
            {
                return;
            }
            if ((e.KeyChar < '0') || (e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void sim_update_Click(object sender, EventArgs e)
        {
            //Update EPOCHS
            EPOCHS = uint.Parse(epochs_tb.Text);

            //Update Learning Rate
            L_Rate = float.Parse(lr_tb.Text);

            //Update Input Values
            Inputs[0] = float.Parse(x1_tb.Text);
            Inputs[1] = float.Parse(x2_tb.Text);
            Dx1.Text = decimal.Round((decimal)Inputs[0], 2, MidpointRounding.AwayFromZero).ToString();
            Dx2.Text = decimal.Round((decimal)Inputs[1], 2, MidpointRounding.AwayFromZero).ToString();

            //Update Required Target Output Values
            Target_Outputs[0] = float.Parse(y1_tb.Text);
            Target_Outputs[1] = float.Parse(y2_tb.Text);

            //Update Bias
            Neu_b1 = float.Parse(b1_tb.Text);
            Neu_b2 = float.Parse(b2_tb.Text);
            Neu_b3 = float.Parse(b3_tb.Text);
            Neu_b4 = float.Parse(b4_tb.Text);
            Db1.Text = decimal.Round((decimal)Neu_b1, 2, MidpointRounding.AwayFromZero).ToString();
            Db2.Text = decimal.Round((decimal)Neu_b2, 2, MidpointRounding.AwayFromZero).ToString();
            Db3.Text = decimal.Round((decimal)Neu_b3, 2, MidpointRounding.AwayFromZero).ToString();
            Db4.Text = decimal.Round((decimal)Neu_b4, 2, MidpointRounding.AwayFromZero).ToString();

            //Update Weights
            Weights[0] = float.Parse(w1_tb.Text);
            Weights[1] = float.Parse(w2_tb.Text);
            Weights[2] = float.Parse(w3_tb.Text);
            Weights[3] = float.Parse(w4_tb.Text);
            Weights[4] = float.Parse(w5_tb.Text);
            Weights[5] = float.Parse(w6_tb.Text);
            Weights[6] = float.Parse(w7_tb.Text);
            Weights[7] = float.Parse(w8_tb.Text);
            Dw1.Text = "w1=" + (decimal.Round((decimal)Weights[0], 2, MidpointRounding.AwayFromZero).ToString());
            Dw2.Text = "w2=" + (decimal.Round((decimal)Weights[1], 2, MidpointRounding.AwayFromZero).ToString());
            Dw3.Text = "w3=" + (decimal.Round((decimal)Weights[2], 2, MidpointRounding.AwayFromZero).ToString());
            Dw4.Text = "w4=" + (decimal.Round((decimal)Weights[3], 2, MidpointRounding.AwayFromZero).ToString());
            Dw5.Text = "w5=" + (decimal.Round((decimal)Weights[4], 2, MidpointRounding.AwayFromZero).ToString());
            Dw6.Text = "w6=" + (decimal.Round((decimal)Weights[5], 2, MidpointRounding.AwayFromZero).ToString());
            Dw7.Text = "w7=" + (decimal.Round((decimal)Weights[6], 2, MidpointRounding.AwayFromZero).ToString());
            Dw8.Text = "w8=" + (decimal.Round((decimal)Weights[7], 2, MidpointRounding.AwayFromZero).ToString());
        }

        private void sim_start_Click(object sender, EventArgs e)
        {
            //Setup Progress Bar
            Iteration_Status.Visible = true;
            Iteration_Status.Minimum = 1;
            Iteration_Status.Maximum = (int)EPOCHS;
            Iteration_Status.Value = 1;
            Iteration_Status.Step = 1;

            Iteration_Handler.RunWorkerAsync();

            sim_start.Enabled = false;
        }

        private void sim_abort_Click(object sender, EventArgs e)
        {
            //To Cancel asynchronous operation
            Iteration_Handler.CancelAsync();
            Iteration_Status.Value = 1;
            sim_start.Enabled = true;
        }

        private void epochs_er_Click(object sender, EventArgs e)
        {
            EPOCHS = uint.Parse(epochs_tb.Text);
            //System.Diagnostics.Debug.WriteLine(EPOCHS.ToString());
        }

        private void lr_er_Click(object sender, EventArgs e)
        {
            L_Rate = float.Parse(lr_tb.Text);
            //System.Diagnostics.Debug.WriteLine(L_Rate.ToString());
        }

        private void input_er_Click(object sender, EventArgs e)
        {
            Inputs[0] = float.Parse(x1_tb.Text);
            Inputs[1] = float.Parse(x2_tb.Text);
            Dx1.Text = decimal.Round((decimal)Inputs[0], 2, MidpointRounding.AwayFromZero).ToString();
            Dx2.Text = decimal.Round((decimal)Inputs[1], 2, MidpointRounding.AwayFromZero).ToString();
        }

        private void output_er_Click(object sender, EventArgs e)
        {
            Target_Outputs[0] = float.Parse(y1_tb.Text);
            Target_Outputs[1] = float.Parse(y2_tb.Text);
            //System.Diagnostics.Debug.WriteLine(Target_Outputs[0].ToString());
            //System.Diagnostics.Debug.WriteLine(Target_Outputs[1].ToString());
        }

        private void bias_update_Click(object sender, EventArgs e)
        {
            Neu_b1 = float.Parse(b1_tb.Text);
            Neu_b2 = float.Parse(b2_tb.Text);
            Neu_b3 = float.Parse(b3_tb.Text);
            Neu_b4 = float.Parse(b4_tb.Text);
            Db1.Text = decimal.Round((decimal)Neu_b1, 2, MidpointRounding.AwayFromZero).ToString();
            Db2.Text = decimal.Round((decimal)Neu_b2, 2, MidpointRounding.AwayFromZero).ToString();
            Db3.Text = decimal.Round((decimal)Neu_b3, 2, MidpointRounding.AwayFromZero).ToString();
            Db4.Text = decimal.Round((decimal)Neu_b4, 2, MidpointRounding.AwayFromZero).ToString();
        }

        private void weight_update_Click(object sender, EventArgs e)
        {
            Weights[0] = float.Parse(w1_tb.Text);
            Weights[1] = float.Parse(w2_tb.Text);
            Weights[2] = float.Parse(w3_tb.Text);
            Weights[3] = float.Parse(w4_tb.Text);
            Weights[4] = float.Parse(w5_tb.Text);
            Weights[5] = float.Parse(w6_tb.Text);
            Weights[6] = float.Parse(w7_tb.Text);
            Weights[7] = float.Parse(w8_tb.Text);
            Dw1.Text = "w1=" + (decimal.Round((decimal)Weights[0], 2, MidpointRounding.AwayFromZero).ToString());
            Dw2.Text = "w2=" + (decimal.Round((decimal)Weights[1], 2, MidpointRounding.AwayFromZero).ToString());
            Dw3.Text = "w3=" + (decimal.Round((decimal)Weights[2], 2, MidpointRounding.AwayFromZero).ToString());
            Dw4.Text = "w4=" + (decimal.Round((decimal)Weights[3], 2, MidpointRounding.AwayFromZero).ToString());
            Dw5.Text = "w5=" + (decimal.Round((decimal)Weights[4], 2, MidpointRounding.AwayFromZero).ToString());
            Dw6.Text = "w6=" + (decimal.Round((decimal)Weights[5], 2, MidpointRounding.AwayFromZero).ToString());
            Dw7.Text = "w7=" + (decimal.Round((decimal)Weights[6], 2, MidpointRounding.AwayFromZero).ToString());
            Dw8.Text = "w8=" + (decimal.Round((decimal)Weights[7], 2, MidpointRounding.AwayFromZero).ToString());
        }

        private void epochs_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == '\b')
            {
                return;
            }
            if ((e.KeyChar < '0') || (e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void Iteration_Handler_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //Take Current Time
                SimStart_Time = DateTime.Now;
                uint temp = 0;
                uint temp1 = 0;
                uint temp2 = 0;
                Err_Acc_Chart.Series["error"].Points.Clear();
                Err_Acc_Chart.ChartAreas["ChartArea1"].AxisX.Title = "EPOCHS (x" + ((int)(EPOCHS / 10)).ToString() + ")";

                for (int i = 0; i < EPOCHS; i++)
                {
                    //Report Progress Status
                    Iteration_Handler.ReportProgress(i + 1);
                    //Thread.Sleep(1);

                    //Check For Simulation Abort
                    if (Iteration_Handler.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    /*Check For Simulation Pause
                    while (pauseSim == 1)
                    {
                        //Check For Simulation Abort
                        if (abortSim == 1)
                        {
                            break;
                        }
                    }*/

                    //Hidden Layer Calculation
                    HNlayer_Circle[No_of_HNlayer - 1, 0] = 1 / (1 + (float)Math.Exp(((Inputs[0] * Weights[0]) + Neu_b1 + (Inputs[1] * Weights[2])) * -1));
                    HNlayer_Circle[No_of_HNlayer - 1, 1] = 1 / (1 + (float)Math.Exp(((Inputs[0] * Weights[1]) + Neu_b2 + (Inputs[1] * Weights[3])) * -1));

                    //Output Layer Calculation
                    Current_Outputs[0] = 1 / (1 + (float)Math.Exp(((HNlayer_Circle[No_of_HNlayer - 1, 0] * Weights[4]) + Neu_b3 + (HNlayer_Circle[No_of_HNlayer - 1, 1] * Weights[6])) * -1));
                    Current_Outputs[1] = 1 / (1 + (float)Math.Exp(((HNlayer_Circle[No_of_HNlayer - 1, 0] * Weights[5]) + Neu_b4 + (HNlayer_Circle[No_of_HNlayer - 1, 1] * Weights[7])) * -1));

                    //Error Calculation
                    Total_Error = ((float)(Math.Pow((Target_Outputs[0] - Current_Outputs[0]), 2)) / 2) + (((float)Math.Pow((Target_Outputs[1] - Current_Outputs[1]), 2)) / 2);
                    if ((temp1 == (uint)(EPOCHS / 10)) || (i == 0))
                    {
                        temp1 = 0;
                        Err_Acc_Chart.Series["error"].Points.AddXY(temp2++, Total_Error);
                    }
                    temp1++;
                    //System.Diagnostics.Debug.WriteLine(HNlayer_Circle[No_of_HNlayer-1, 0].ToString());
                    //System.Diagnostics.Debug.WriteLine(HNlayer_Circle[No_of_HNlayer-1, 1].ToString());
                    //System.Diagnostics.Debug.WriteLine(Current_Outputs[0].ToString());
                    //System.Diagnostics.Debug.WriteLine(Current_Outputs[1].ToString());
                    System.Diagnostics.Debug.WriteLine(Total_Error.ToString());

                    //Update new weights
                    Weights[0] = Weights[0] - (L_Rate * (((-(Target_Outputs[0] - Current_Outputs[0])) * (Current_Outputs[0] * (1 - Current_Outputs[0])) * Weights[4]) * ((-(Target_Outputs[1] - Current_Outputs[1])) * (Current_Outputs[1] * (1 - Current_Outputs[1])) * Weights[7]) * (HNlayer_Circle[No_of_HNlayer - 1, 0] * (1 - HNlayer_Circle[No_of_HNlayer - 1, 0])) * Inputs[0]));
                    Weights[1] = Weights[1] - (L_Rate * (((-(Target_Outputs[0] - Current_Outputs[0])) * (Current_Outputs[0] * (1 - Current_Outputs[0])) * Weights[6]) * ((-(Target_Outputs[1] - Current_Outputs[1])) * (Current_Outputs[1] * (1 - Current_Outputs[1])) * Weights[7]) * (HNlayer_Circle[No_of_HNlayer - 1, 1] * (1 - HNlayer_Circle[No_of_HNlayer - 1, 1])) * Inputs[0]));
                    Weights[2] = Weights[2] - (L_Rate * (((-(Target_Outputs[0] - Current_Outputs[0])) * (Current_Outputs[0] * (1 - Current_Outputs[0])) * Weights[4]) * ((-(Target_Outputs[1] - Current_Outputs[1])) * (Current_Outputs[1] * (1 - Current_Outputs[1])) * Weights[7]) * (HNlayer_Circle[No_of_HNlayer - 1, 0] * (1 - HNlayer_Circle[No_of_HNlayer - 1, 0])) * Inputs[1]));
                    Weights[3] = Weights[3] - (L_Rate * (((-(Target_Outputs[0] - Current_Outputs[0])) * (Current_Outputs[0] * (1 - Current_Outputs[0])) * Weights[6]) * ((-(Target_Outputs[1] - Current_Outputs[1])) * (Current_Outputs[1] * (1 - Current_Outputs[1])) * Weights[7]) * (HNlayer_Circle[No_of_HNlayer - 1, 1] * (1 - HNlayer_Circle[No_of_HNlayer - 1, 1])) * Inputs[1]));
                    //System.Diagnostics.Debug.WriteLine(Weights[0].ToString());
                    //System.Diagnostics.Debug.WriteLine(Weights[1].ToString());
                    //System.Diagnostics.Debug.WriteLine(Weights[2].ToString());
                    //System.Diagnostics.Debug.WriteLine(Weights[3].ToString());

                    Weights[4] = Weights[4] - (L_Rate * ((-(Target_Outputs[0] - Current_Outputs[0])) * (Current_Outputs[0] * (1 - Current_Outputs[0])) * HNlayer_Circle[No_of_HNlayer - 1, 0]));
                    Weights[5] = Weights[5] - (L_Rate * ((-(Target_Outputs[1] - Current_Outputs[1])) * (Current_Outputs[1] * (1 - Current_Outputs[1])) * HNlayer_Circle[No_of_HNlayer - 1, 0]));
                    Weights[6] = Weights[6] - (L_Rate * ((-(Target_Outputs[0] - Current_Outputs[0])) * (Current_Outputs[0] * (1 - Current_Outputs[0])) * HNlayer_Circle[No_of_HNlayer - 1, 1]));
                    Weights[7] = Weights[7] - (L_Rate * ((-(Target_Outputs[1] - Current_Outputs[1])) * (Current_Outputs[1] * (1 - Current_Outputs[1])) * HNlayer_Circle[No_of_HNlayer - 1, 1]));
                    //System.Diagnostics.Debug.WriteLine(Weights[4].ToString());
                    //System.Diagnostics.Debug.WriteLine(Weights[5].ToString());
                    //System.Diagnostics.Debug.WriteLine(Weights[6].ToString());
                    //System.Diagnostics.Debug.WriteLine(Weights[7].ToString());

                    //Periodically Updating Diagram Variables with respect to EPOCHS (i update every 100 iterations)
                    temp++;
                    if (temp >= 100)
                    {
                        temp = 0;
                        UpdateDiaVariables();

                        //Update Simulation Duration
                        Sim_Duration.Text = "Simulation Duration: " + DateTime.Now.Subtract(SimStart_Time).ToString();

                    }
                }
                //Updating Diagram Variables
                UpdateDiaVariables();

                //Update Simulation Duration
                Sim_Duration.Text = "Simulation Duration: " + DateTime.Now.Subtract(SimStart_Time).ToString();

                //Update Line Graph Last Point
                Err_Acc_Chart.Series["error"].Points.AddXY(temp2, Total_Error);
            }
            catch (Exception x)
            {
                MessageBox.Show("An error occured while performing operation" + x);
            }
        }

        private void Iteration_Handler_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Update Progress Bar
            Iteration_Status.Value = e.ProgressPercentage;
        }

        private void Iteration_Handler_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Operation Cancelled");
                sim_start.Enabled = true;
            }
            else
            {
                MessageBox.Show("Operation Completed");
                sim_start.Enabled = true;
            }
        }
    }
}

//Writing node and weight values
//Font Val_Font = new Font("Arial", 12, FontStyle.Bold);
//g.DrawString("0.95", Val_Font, Val_Brush, (OrginPt_X + NeuCircle_Width) + 50 - 15, (OrginPt_Y + (NeuCircle_Height / 2)) + 2);
