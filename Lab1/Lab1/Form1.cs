using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
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
            }

            /// <summary>
            /// /
            /// </summary>
            /// <param name="a"></param>
            /// <param name="n"></param>
            /// <returns></returns>
            static int Operation(double[,] a, int n)
            {
                int i, j, k = 0, c, flag = 0;

                for (i = 0; i < n; i++)
                {
                    if (a[i, i] == 0)
                    {
                        c = 1;
                        while ((i + c) < n && a[i + c, i] == 0)
                            c++;
                        if ((i + c) == n)
                        {
                            flag = 1;
                            break;
                        }
                        for (j = i, k = 0; k <= n; k++)
                        {
                            double temp = a[j, k];
                            a[j, k] = a[j + c, k];
                            a[j + c, k] = temp;
                        }

                    }

                    for (j = 0; j < n; j++)
                    {

                        if (i != j)
                        {
                            double p = a[j, i] / a[i, i];

                            for (k = 0; k <= n; k++)
                                a[j, k] = a[j, k] - (a[i, k]) * p;
                        }
                    }
                }
                return flag;
            }
        static void getCofactor(double[,] mat, double[,] temp,
                               int p, int q, int n) 
        {
            int i = 0, j = 0;


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {


                    if (row != p && col != q)
                    {
                        temp[i, j++] = mat[row, col];


                        if (j == n - 1)
                        {
                            j = 0;
                            i++;
                        }
                        
                    }
                }
            }
        }
        ////////
        ///
        static void PrintMatrix(double[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }
        static void PrintMatrix1(double[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static double Determinant(double[,] mat, int n)
            {
            double D = 0;


            if (n == 1)
                return mat[0, 0];


            double[,] temp = new double[n, n];

            int sign = 1;

            for (int f = 0; f < n; f++)
            {
                getCofactor(mat, temp, 0, f, n);
                D += sign * mat[0, f]
                     * Determinant(temp, n - 1);
                
                sign = -sign;
            }

            return D;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        private double[] Result(double[,] a, int n, int flag)
            {
                double[] res = new double[n];

                if (flag == 2)
                    output1.Text = "Безліч коренів";

                else if (flag == 3)
                    output1.Text = "Немає розв'язків";

                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        res[i] += a[i, n] / a[i, i]; //останній ел масива ділиться на діагональний в кожному рядку
                        Console.WriteLine(res[i]);
                    }
                    string x = "";
                    for (int i = 0; i < n; i++)
                    {

                        x += $"  X{i + 1}= {res[i]}";

                    }
                    output1.Text = x;
                }

                return res;
            }
            private double[] GilbertResult(double[,] a, int n, int flag) // так само 
            {
                double[] res = new double[n];

                if (flag == 2)
                    outputGilb.Text = "Безліч коренів";

                else if (flag == 3)
                    outputGilb.Text = "Немає розв'язків";

                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        res[i] += a[i, n] / a[i, i];
                        Console.WriteLine(res[i]);
                    }
                    string x = "";
                    for (int i = 0; i < n; i++)
                    {

                        x += $"  X{i + 1}= {res[i]}";

                    }
                    outputGilb.Text = x;
                }

                return res;
            }
            static int Compatibility(double[,] a,
                                int n, int flag)
            {
                int i, j;
                double sum;

                flag = 3;
                for (i = 0; i < n; i++)
                {
                    sum = 0;
                    for (j = 0; j < n; j++)
                        sum = sum + a[i, j];// первіряє матрицю на сумісність 
                    if (sum == a[i, j])
                        flag = 2;
                }
                return flag;
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void JoinMatrix(double[,] A, double[,] adj, int N)
        {
            if (N == 1)
            {
                adj[0, 0] = 1;
                return;
            }


            int sign = 1;
            double[,] temp = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    getCofactor(A, temp, i, j, N);

                    sign = ((i + j) % 2 == 0) ? 1 : -1;


                    adj[j, i] = (sign) * (Determinant(temp, N - 1));
                }
            }
        }

        private bool inverse(double[,] A, double[,] inverse, int N)
        {

            double det = Determinant(A, N);
            if (det == 0)
            {

                return false;
            }


            double[,] adj = new double[N, N];
            JoinMatrix(A, adj, N);

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    inverse[i, j] = adj[i, j] / (float)det;

            return true;
        }
        private void generateButt_Click_1(object sender, EventArgs e)
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

        private void Rows_ValueChanged_1(object sender, EventArgs e)
        {
            MatrixPlace.RowCount = (int)Rows.Value;
        }

        private void Columns_ValueChanged_1(object sender, EventArgs e)
        {
            MatrixPlace.ColumnCount = (int)Columns.Value;
        }

        private void solButt_Click(object sender, EventArgs e)
        {
            int n = (int)Rows.Value, flag = 0;


            double[,] a = new double[(int)Rows.Value, (int)Columns.Value];
            for (int i = 0; i < (int)Rows.Value; i++)
            {
                for (int j = 0; j < (int)Columns.Value; j++)
                {
                    a[i, j] = Convert.ToDouble(MatrixPlace[j, i].Value);
                }
            }
            
            flag = Operation(a, n);
            
            if (flag == 1)
                flag = Compatibility(a, n, flag);
            Result(a, n, flag);
        }

        private void determ_Click(object sender, EventArgs e)
        {
            double[,] arr = new double[MatrixPlace.RowCount, MatrixPlace.ColumnCount];


            for (int i = 0; i < MatrixPlace.RowCount; i++)
            {
                for (int j = 0; j < MatrixPlace.ColumnCount; j++)
                {
                    arr[i, j] = Convert.ToDouble(MatrixPlace[j, i].Value);
                }
            }
            if (MatrixPlace.RowCount == MatrixPlace.ColumnCount)
            {
                detText.Text = Convert.ToString(Determinant(arr, (int)Rows.Value));

            }
            else
            {
                detText.Text = "Введіть матрицю розміром nxn";
            }
        }

        private void invMatr_Click(object sender, EventArgs e)
        {
            int N = MatrixPlace.RowCount;
            

            double[,] A = new double[MatrixPlace.RowCount, MatrixPlace.ColumnCount];


            for (int i = 0; i < MatrixPlace.RowCount; i++)
            {
                for (int j = 0; j < MatrixPlace.ColumnCount; j++)
                {
                    A[i, j] = Convert.ToDouble(MatrixPlace[j, i].Value);
                }
            }

            if (MatrixPlace.RowCount == MatrixPlace.ColumnCount)
            {

                detText.Text = Convert.ToString(Determinant(A, MatrixPlace.RowCount));
                double[,] adj = new double[N, N]; // To store adjoint of [,]A

                double[,] inv = new double[N, N]; // To store inverse of [,]A


                Console.Write("Input matrix is :\n");
                PrintMatrix(A, N);

                Console.Write("\nThe Adjoint is :\n");
                JoinMatrix(A, adj, N);
                PrintMatrix(adj, N);
                InverseGrid.RowCount = N;
                InverseGrid.ColumnCount = N;
                Console.Write("\nThe Inverse is :\n");
                if (inverse(A, inv, N))
                    PrintMatrix(inv, N);
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                        InverseGrid[j, i].Value = inv[i, j];
                }
            }
            else
            {
                detText.Text = "Введіть матрицю розміром nxn";
            }
        }

        //
        static double Max(double[] array)
        {
            double max = array[0];        // присвоєння елементу max значення першого елемента массива  
            for (int i = 0; i < array.Count(); i++) // робимо цикл перебору всіх елементів масива
            {
                if (max < array[i])    // якщо цей элемент більший за елемент max
                {
                    max = array[i];  // присвоєння елементу max значення  цього елемента
                }
            }
            return max;
        }

        private void gilbGen_Click(object sender, EventArgs e)
        {
            int m = (int)numericUpDown1.Value;
            double[,] A = new double[m, m];
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    double n = i + j - 1;
                    A[i - 1, j - 1] = 1 / n;
                }
            }
            PrintMatrix(A, m);
            double[] xi = new double[m];
            for (int i = 1; i <= m; i++)
            {
                xi[i - 1] = Math.Pow(i, 2);
                Console.WriteLine(xi[i - 1]);
                Console.WriteLine("--------------");
            }
            //допоміжний елемент для множення вектора на матрицю
            double[,] temp = new double[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    temp[j, i] = A[j, i] * xi[i];
                }
            }
            PrintMatrix(temp, m);
            // знаходження сумми у векторі
            double[] f = new double[m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    f[i] += temp[i, j];
                }
                Console.WriteLine(f[i]);
                Console.WriteLine("--------------");
            }
            //Створення пустої матриці розмірності [m,m+1] в яку ми копіюємо данні з матриці А 
            double[,] Ax = new double[m, m + 1];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    Ax[i, j] = A[i, j];
                }

            }
            PrintMatrix1(Ax, m);
            Console.WriteLine("--------------");
            //Далі ми додаємо у стовпчик m+1 значення із массиву f
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    if (j == m)

                        Ax[i, j] = f[i];
                }

            }
            PrintMatrix1(Ax, m);
            GilbertGrid.RowCount = m;
            GilbertGrid.ColumnCount = m + 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j <= m; j++)
                    GilbertGrid[j, i].Value = Ax[i, j];
            }
            Console.WriteLine("--------------");
            // Методом гауса знаходимо розв'язки
            int flag = 0;
            flag = Operation(Ax, m);
            Console.WriteLine("-----");
            Console.WriteLine(flag);
            if (flag == 1)
                flag = Compatibility(Ax, m, flag);
            double[] x = GilbertResult(Ax, m, flag);
            Console.WriteLine(x);
            
        }

    }
}
