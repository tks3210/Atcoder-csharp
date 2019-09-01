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

        var ans = input.Min(x => {
            var c = 0;
            while (x % 2 == 0 && x != 0) {x >>= 1; ++c;}
            return c;
        });
        Console.WriteLine(ans);
    }
}