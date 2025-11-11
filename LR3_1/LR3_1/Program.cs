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

            double X, Y, Z;
            int t, N;
            Z = 0;
            //Тут должна быть отработка ошибок, но мне лень
            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            t = Convert.ToInt32(Console.ReadLine());

            switch (t)
            {
                case 0:
                    ForCycle(X, Y, N, Z);
                    break;
                case 1:
                    WhileCycle(X, Y, N, Z);
                    break;
                case 2:
                    doWhileCycle(X, Y, N, Z);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

            Console.SetOut(save_out);
            Console.SetIn(save_in);
            new_out.Close();
            new_in.Close();
        }

        static void ForCycle(double X, Double Y, int N, double Z)
        {
            for(int i = 1; i <= N; i++)
            {
                int step = i;
                if(i != 1)
                    step += 2;
                
                if(i % 2 != 0)
                    Z -= Math.Pow(X, step) / (step * (step + 1) * (step + 2));
                else
                    Z += Math.Pow(X, step) / (step * (step + 1) * (step + 2));

            }
            Console.WriteLine(String.Format("{0:0.00000}", Z));
        }

        static void WhileCycle(double X, Double Y, int N, double Z)
        {
            int i = 1;
            while(i <= N) { 
                int step = i;
                if (i != 1)
                    step += 2;

                if (i % 2 != 0)
                    Z -= Math.Pow(X, step) / (step * (step + 1) * (step + 2));
                else
                    Z += Math.Pow(X, step) / (step * (step + 1) * (step + 2));
                i++;
            }
            Console.WriteLine(String.Format("{0:0.00000}", Z));
        }

        static void doWhileCycle(double X, Double Y, int N, double Z)
        {
            int i = 1;
            do
            {
                int step = i;
                if (i != 1)
                    step += 2;

                if (i % 2 != 0)
                    Z -= Math.Pow(X, step) / (step * (step + 1) * (step + 2));
                else
                    Z += Math.Pow(X, step) / (step * (step + 1) * (step + 2));
                i++;
            } while (i <= N);
            Console.WriteLine(String.Format("{0:0.00000}", Z));
        }
    }
}