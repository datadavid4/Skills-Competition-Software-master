using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float r = int.Parse(getInput("請輸入徑向距離(r) = "));
            int n = int.Parse(getInput("請輸入徑向多項式的次數(n) = "));


            for (int m = -n; m <= n; m++)
            {
                if ((n - Math.Abs(m)) % 2 == 0)
                {
                    WL($"計算徑向多項式(radial polynomials) ..., r = {r}, n = {n}, m = {m}");
                    WL($"所求之徑向多項式為 = {getAns(r, n, m)}");
                }
            }


            Console.Read();
        }

        static int getAns(float r, int n, int m)
        {
            int result = 1;

            for (int s = 0; s <= n - Math.Abs(m); s++)
            {

            }


            return result;
        }
        static int getFactorial(int n)
        {
            if (n == 1) return n;
            else return n * getFactorial(n - 1);
        }
        static string getInput(string title)
        {
            Console.Write($"{title}");
            return RL();
        }
        static void W(string str)
        {
            Console.Write(str);
        }
        static void WL(string str)
        {
            Console.WriteLine(str);
        }
        static string RL()
        {
            return Console.ReadLine();
        }
    }
}
