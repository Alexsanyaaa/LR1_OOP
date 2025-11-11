using System;
using System.IO;

namespace css
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;

            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");

            Console.SetOut(new_out);
            Console.SetIn(new_in);

            double apo, boo, css, ew, ddd;
            double f, g;

            apo = Convert.ToDouble(Console.ReadLine());
            boo = Convert.ToDouble(Console.ReadLine());
            css = Convert.ToDouble(Console.ReadLine());
            ew = Convert.ToDouble(Console.ReadLine());
            ddd = Convert.ToDouble(Console.ReadLine());

            if ((apo == 0) || (boo == 0) || (ew < 0) || ddd == 0 || css == 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                f = 1 / 100  - 1 / apo - 1 / (boo * boo);
                Console.WriteLine(String.Format("{0:0.000}", f));

                g = 1 / (css * css) + System.Math.Sqrt(ew) / (System.Math.Pow(ddd, 3));
                Console.WriteLine(String.Format("{0:0.000}", g));
            }

            Console.SetOut(save_out);
            Console.SetIn(save_in);
            new_out.Close();
            new_in.Close();
        }
    }
}