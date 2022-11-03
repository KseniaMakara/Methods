using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApi;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Data(4, 1E-20, 10, 12, 10000, 10);
            var ht = WinApiFuncs.CreateThread(Thread, d);
            Console.WriteLine("Started");
            Console.WriteLine($"Wait for {d.s} sec");
            var ret = WinApiFuncs.WaitForSingleObject(ht, d.s * 1000);
            //Ви вроді сказали, що це не треба, бо воно не працює, я просто закоментую
            //if (ret != WinApiFuncs.WAIT_OBJECT_0)
            //{
            //    WinApiFuncs.TerminateThread(ht);
            //}
            WinApiFuncs.CloseHandle(ht);
            Console.WriteLine("Finish, Press Enter");
            Console.ReadLine();

        }
        static void Thread(IntPtr data)
        {
            var d = (Data)WinApiFuncs.ToObject(data);
            ulong i = 0;
            int sign = 1;
            double a, s=0;
            do
            {
                a = (Math.Pow(d.x, 2) + 1) /(5 * i + 3);
                s += sign * a;
                sign = -sign;
                i+=1;


                if (i % (ulong)d.t == 0)
                {
                    Console.SetCursorPosition(d.z, d.y);
                    Console.WriteLine($"s={s}");
                }
            }
            while (a > d.Eps);
        }
    }
    struct Data{
        public double x;
        public double Eps;
        public int z;
        public int y;
        public int t;
        public uint s;
        public Data(double x, double Eps, int z, int y, int t, uint s)
        {
            this.x = x;
            this.Eps = Eps;
            this.z = z;
            this.y = y;
            this.t = t;
            this.s = s;
        }
    }
}
