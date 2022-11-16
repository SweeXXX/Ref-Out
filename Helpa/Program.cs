using System;
using System.Linq;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Collections;

namespace Home
{
    
    class Program
    {
        static void Main()
        {
            double[] dd = { 1.2, 23.5, 12, 123, 12 };
            double[] kk = { 1, 2, 3, 4 };
            K2(dd, kk);

            static void K2(double[] d, double[] k)
            {
                //d[0]++;
                Console.WriteLine(String.Join(" ", d));
                d = k;
                d[0]++;
                k[1]++;
                Console.WriteLine(string.Join(" ", d));
                Console.WriteLine(string.Join(" ", k));

            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", dd));
            Console.WriteLine(string.Join(" ", kk));


            //static void K3(ref string str, out string str2)
            //{
            //    str += "O!";
            //    str2 = str+"МАЙНКРАФТ ЭТО МОЯ ЖИЗНЬ!";
            //}
            //string s = "asfa";
            //string s2 = null;
            //Console.WriteLine();
            //Console.WriteLine(s);
            //Console.WriteLine(s2);
            //K3(ref s,  out s2);
            //Console.WriteLine(s);
            //Console.WriteLine(s2);


        }


    }
    
}
