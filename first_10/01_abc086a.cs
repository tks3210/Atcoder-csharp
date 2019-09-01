using System;
 
public class HelloWorld
{
    
    public static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split(' ');
        int a = Int32.Parse(arr[0]);
        int b = Int32.Parse(arr[1]);

        string ret = ((a*b)%2 == 0) ? "Even" : "Odd";
        Console.WriteLine (ret);
    }
}
