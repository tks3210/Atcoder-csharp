using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using static System.Console;
using static System.Math;
public class Program
{
    public static void Main(string[] args)
    {
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c = Int32.Parse(Console.ReadLine());
        int x = Int32.Parse(Console.ReadLine());

        int ans = 0;
        for (int i = 0; i <= a; i++)
        {
            for (int j = 0; j <= b; j++)
            {
                for (int k = 0; k <= c; k++)
                {
                    if (x == ((i*500) + (j*100) + (k*50))){
                        ans++;                        
                    }
                }                
            }
        }
        Console.WriteLine(ans);
    }
}