using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        int fromBase = int.Parse(Console.ReadLine());//br sistema
        int toBase = int.Parse(Console.ReadLine());//kum koq broina
        string converted = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
        Console.WriteLine(converted);
                   
    }
}
