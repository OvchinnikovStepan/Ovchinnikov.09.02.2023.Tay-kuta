using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тау_Кита
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] A = a.Split(new char[] { ' ' });
            for (int i = 0; i < A.Length; i++)
            {
                char[] B = A[i].ToCharArray();
                char[] C = new char[B.Length];
                for (int t = 0; t < C.Length; t++)
                {
                    int d;
                    if (t % 2 == 0) { d = 1; }
                    else {d = -1; }
                    C[t] = B[B.Length / 2 + ((t+1)/2)*d];
                }
                A[i] = new string(C);
            }
            string[] T = new string[A.Length];
            for (int t = 0; t < A.Length; t++)
            {
                int d;
                if (t % 2 == 0) { d = 1; }
                else { d = -1; }
                T[t] = A[A.Length / 2 + ((t + 1) / 2) * d];
            }

            for (int i=0; i < A.Length; i++)
            {
                Console.Write(T[i]);
                if (i < A.Length)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine(" ");
        }
    }
}
