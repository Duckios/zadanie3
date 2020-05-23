using System;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace pract3
{
    class Program
    {
        static void Main(string[] args)
        {
            int zadanie = ToInt32(ReadLine());
            switch (zadanie)
            {
                case 1:
                    int[] s = new int[5] { 1, 2, -3, 4, 0 };
                    int minM = 0;
                    int mod = 0;
                    int ind = 0;
                    for (int i = 0; i < s.Length; i++)
                    {
                        if ((Abs(s[i])) < Abs(s[minM]))
                        {
                            ind = i;
                            mod = s[i];
                        }
                    }
                    WriteLine($"Минимальное число {mod},его индекс {ind}");
                    break;
                case 2:
                    int[] m = new int[10] { 6, 4, 1, 7, 4, 76, 23, 5, 6, 23, };
                    int k=0;
                    string povtor="";
                    for (int i = 0; i < m.Length; i++)
                    {
                        for (int j = 0; j < m.Length; j++)
                        {
                            if (m[i] == m[j]) k++;
                        }
                        if (k > 1)
                        {
                            povtor = povtor + m[i] + " ";
                            k = 0;
                        }
                    }
                    WriteLine(povtor);
                    break;
                case 3:
                    int[] r = new int[10];
                    Random random = new Random();
                    WriteLine("Весь массив: ");
                    for (int i = 0; i < r.Length; i++)
                    {
                        r[i] = random.Next(-100, 100);
                        
                        WriteLine(r[i]);
                    }
                    WriteLine("Положительные: ");
                    for (int i = 0; i < r.Length; i++)
                    {
                        if (r[i] < 0) r[i] = 0;
                        else WriteLine(r[i]);
                    }
                    break;
            }
        }
    }
        
}    


