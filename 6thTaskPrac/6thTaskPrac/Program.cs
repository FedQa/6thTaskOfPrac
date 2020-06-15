using System;

namespace _6thTaskPrac
{
    class Program
    {
        static void Main(string[] args)
        {

//Ввести а1, а2, а3, N. 
//Построить последовательность чисел ак = 0.7* ак–1 – 0.2* ак-2 + k* ак–3. 
//Проверить, образуют ли первые N элементов, стоящие на нечетных местах, монотонную подпоследовательность (неубывающую или невозрастающую).
            Console.WriteLine("Введите кол-во членов последовательности:");
            int N = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[N+1];
            for (int k = 1; k < 4; k++)
            {
                Console.WriteLine($"Введите a{k}");
                a[k] = Convert.ToDouble(Console.ReadLine());
            }
            for(int k=4; k<=N; k++)
            {
                a[k] = 0.7 * a[k - 1] - 0.2 * a[k - 2] + k * a[k - 3];
            }
            Console.WriteLine("Последовательность:");
            for (int i = 1; i <=N; i++)
            {
                Console.Write(a[i] + " ");
            }
            bool ok = true;
            for (int i = 1; i <= N; i++)
            {
                if(i%2==1)
                {
                    if(a[i]>a[i+1])
                    {
                        ok = false;
                        break;
                    }
                }
              
            }

            if (ok) Console.WriteLine("последовательность возрастающая");
            else
            {
                ok = true;
                for (int i = 0; i < N - 1; i++)
                {
                    if (i % 2 == 1)
                    {
                        if (a[i] < a[i + 1])
                        {
                            ok = false;
                            break;
                        }
                    }

                }
                if (ok) Console.WriteLine("последовательность убывающая");
            }
        }
    }
}
