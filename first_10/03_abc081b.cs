using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;
using static System.Math;
public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

        int div = 2;
        int ans = -1;
        bool fin = true;
        while(fin){
            foreach (var item in input)
            {
                if ((item % div) != 0){
                    fin = false;
                }
            }
            div *= 2;
            ans++;
        }
        Console.WriteLine(ans);
    }
}