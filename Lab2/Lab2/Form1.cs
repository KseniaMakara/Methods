using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MatrixPlace.RowCount = (int)Rows.Value;
            MatrixPlace.ColumnCount = (int)Columns.Value;
            VectorGrid.RowCount = 1;
            VectorGrid.ColumnCount = (int)Rows.Value;
            xVect.RowCount = 1;
            xVect.ColumnCount = (int)Rows.Value;

        }

        private void Rows_ValueChanged(object sender, EventArgs e)
        {
            MatrixPlace.RowCount = (int)Rows.Value;
            VectorGrid.ColumnCount = (int)Rows.Value;
            xVect.ColumnCount = (int)Rows.Value;

        }

        private void Columns_ValueChanged(object sender, EventArgs e)
        {
            MatrixPlace.ColumnCount = (int)Columns.Value;

        }

        private void generateButt_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < MatrixPlace.ColumnCount; i++)
            {
                for (int j = 0; j < MatrixPlace.RowCount; j++)
                {
                    MatrixPlace[i, j].Value = rand.Next(-10, 10);
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double[,] arr = new double[(int)Rows.Value, (int)Rows.Value];
            double[] X0 = new double[(int)Rows.Value];
            double[] newVector = new double[(int)Rows.Value];


            int row = (int)Rows.Value;
            int col = (int)Columns.Value;

            for (int i = 0; i < row; i++) //
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToDouble(MatrixPlace[j, i].Value);

                }
                X0[i] = Convert.ToDouble(xVect[i, 0].Value);
                newVector[i] = Convert.ToDouble(VectorGrid[i, 0].Value);
            }

            col += 1;


            double[,] A = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {

                    A[i, j] = arr[i, j];
                }

            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= row; j++)
                {
                    if (j == row)
                    {
                        A[i, j] = newVector[i];
                    }
                }
            }

            double[] XI = new double[(int)Rows.Value];

            double[,] temp = new double[row, col];

            double[] b = new double[row];

            for (int i = 0; i < row; i++)
            {
                b[i] = A[i, i];
                A[i, i] = 0;
            }
            for (int i = 0; i < row; i++)
            {
                double n = A[i, row] / b[i];
                temp[i, 0] = n;
                int k = 1;
                for (int j = 0; j < row; j++)
                {
                    temp[i, k] = -1 * (A[i, j] / b[i]);

                    k++;
                }
            }

            double inpEps = Convert.ToDouble(enterEps.Text);
            int iter = 0;

            Seidel(temp, row, X0, XI, inpEps, iter);
    }

        public void Seidel(double[,] temp, int row, double[] X0, double[] XI, double inpEps, int iter)
        {
            string x = "";
            double[] local = new double[row];
            double[,] dop = new double[row, row + 1];
            double error = 0;
            do
            {
                error = 0;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j <= row; j++)
                    {

                        if (j != 0)
                        {
                            dop[i, j] = temp[i, j] * X0[j - 1];
                        }
                        else
                        {
                            dop[i, j] = temp[i, j];
                        }

                        XI[i] += dop[i, j];
                    }
                    local[i] = X0[i];
                    X0[i] = XI[i];
                    double eps = Math.Abs(XI[i] - local[i]);
                    if (eps > error) { error = eps; }
                }
                for (int i = 0; i < row; i++)
                {
                    XI[i] = 0;
                }
                iter++;
                for (int i = 0; i < row; i++)
                {
                    x += $"X{i + 1}= {X0[i]} \n";

                }
            }
            while (error >= inpEps);
            richTextBox1.Text = x;
            textBox2.Text = Convert.ToString(iter);

        }

        public void Relaxation(double[,] A, double[] b, int row, double inpEps, double w)
        {
            double norma;
            string x_iter = "";
            double[] xn = new double[row];
            double[] x = new double[row];
            for (int i = 0; i < row; i++)
            {
                xn[i] = Convert.ToDouble(xVect[i, 0].Value); //масив з Х
            }
            int k = 0;
            do
            {
                k++;
                norma = 0;
                for (int i = 0; i < row; i++)
                {
                    x[i] = b[i];
                    for (int j = 0; j < row; j++)
                    {
                        if (i != j)
                        {
                            x[i] = x[i] - A[i, j] * x[j];
                        }
                    }
                    x[i] /= A[i, i];
                    x[i] = w * x[i] + (1 - w) * xn[i];
                    if (Math.Abs(x[i] - xn[i]) > norma)
                        norma = Math.Abs(x[i] - xn[i]);
                    xn[i] = x[i];

                }
                for (int i = 0; i < row; i++)
                {
                    x_iter += $"X{i + 1}= {xn[i]} \n";

                }

            }
            while (norma >= 0.01);
            RelaxationGrid.Text = x_iter;
            textBox3.Text = Convert.ToString(k);

        }

        public void Iteration(double[,] temp, int row, double[] X0, double[] XI, double inpEps, int iter)
        {
            double[,] dop = new double[row, row + 1];
            double error = 0; 
            string x = "";
            do
            {
                error = 0;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j <= row; j++)
                    {

                        if (j != 0)
                        {
                            dop[i, j] = temp[i, j] * X0[j - 1];
                        }
                        else
                        {
                            dop[i, j] = temp[i, j];
                        }

                        XI[i] += dop[i, j];
                    }
                    double eps = Math.Abs(XI[i] - X0[i]);
                    if (eps > error) { error = eps; }
                }
                for (int i = 0; i < row; i++)
                {
                    X0[i] = XI[i];
                    XI[i] = 0;
                }
                iter++;
                for (int i = 0; i < row; i++)
                {
                    x += $"  X{i + 1}= {X0[i]}\n";

                }
            }
            while (error >= inpEps);
           
           
            JacobiOutput.Text = x;
            textBox1.Text = Convert.ToString(iter);

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            double[,] arr = new double[(int)Rows.Value, (int)Rows.Value];
            double[] X0 = new double[(int)Rows.Value];
            double[] newVector = new double[(int)Rows.Value];


            int row = (int)Rows.Value;
            int col = (int)Columns.Value;

            for (int i = 0; i < row; i++) //масив з числами від гріда 
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToDouble(MatrixPlace[j, i].Value);

                }
                X0[i] = Convert.ToDouble(xVect[i, 0].Value); //масив з Х
                newVector[i] = Convert.ToDouble(VectorGrid[i, 0].Value);
            }

            col +=1;


            double[,] A = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {

                    A[i, j] = arr[i, j];
                }

            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= row; j++)
                {
                    if (j == row)
                    {
                        A[i, j] = newVector[i];
                    }
                }
            }

            double[] XI = new double[(int)Rows.Value];

            double[,] temp = new double[row, col];

            double[] b = new double[row];

            for (int i = 0; i < row; i++)
            {
                b[i] = A[i, i];
                A[i, i] = 0;
            }
            for (int i = 0; i < row; i++)
            {
                double n = A[i, row] / b[i];
                temp[i, 0] = n;
                int k = 1;
                for (int j = 0; j < row; j++)
                {
                    temp[i, k] = -1 * (A[i, j] / b[i]);

                    k++;
                }
            }

            double inpEps = Convert.ToDouble(enterEps.Text);
            int iter = 0;
            Iteration(temp, row, X0, XI, inpEps, iter);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double omega = Convert.ToDouble(omegaInp.Text);

            double[,] arr = new double[(int)Rows.Value, (int)Rows.Value];
            double[] X0 = new double[(int)Rows.Value];
            double[] newVector = new double[(int)Rows.Value];


            int row = (int)Rows.Value;
            int col = (int)Columns.Value;

            for (int i = 0; i < row; i++) //масив з числами від гріда 
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToDouble(MatrixPlace[j, i].Value);

                }
                X0[i] = Convert.ToDouble(xVect[i, 0].Value); //масив з Х
                newVector[i] = Convert.ToDouble(VectorGrid[i, 0].Value);
            }

            col += 1;
            double[] XI = new double[(int)Rows.Value];
            double inpEps = Convert.ToDouble(enterEps.Text);
            int iter = 0;
            Relaxation(arr, newVector, row, inpEps, omega);
        }
    }
}