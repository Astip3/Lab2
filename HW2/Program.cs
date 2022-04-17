// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Cryptography;
using HW2;


class Program
{
    public static void Main()
    {

        Console.Write("GENERAL CHECK:");
        Console.WriteLine();

        Console.WriteLine(RomanNumber.Add(new RomanNumber(20), new RomanNumber(10)));
        Console.WriteLine(RomanNumber.Sub(new RomanNumber(20), new RomanNumber(10)));
        Console.WriteLine(RomanNumber.Mul(new RomanNumber(20), new RomanNumber(10)));
        Console.WriteLine(RomanNumber.Div(new RomanNumber(20), new RomanNumber(10)));
        Console.WriteLine();

        RomanNumber[] romanNumberArraySum = new RomanNumber[10];

        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.Write(i + ". " + "SUM:");
            Console.WriteLine();
            romanNumberArraySum[i] = RomanNumber.Add(new RomanNumber((ushort)(rnd.Next(1, 1000))),
            new RomanNumber((ushort)(new Random().Next(1, 1000))));

            Console.Write(romanNumberArraySum[i] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();

        RomanNumber[] romanNumberArraySub = new RomanNumber[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write(i + ". " + "SUB:");
            Console.WriteLine();
            romanNumberArraySub[i] = RomanNumber.Sub(new RomanNumber((ushort)(rnd.Next(501, 1000))),
            new RomanNumber((ushort)(new Random().Next(1, 500))));

            Console.Write(romanNumberArraySub[i] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();

        RomanNumber[] romanNumberArrayMul = new RomanNumber[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write(i + ". " + "MUL:");
            Console.WriteLine();
            romanNumberArrayMul[i] = RomanNumber.Mul(new RomanNumber((ushort)(rnd.Next(1, 100))),
            new RomanNumber((ushort)(new Random().Next(1, 100))));

            Console.Write(romanNumberArrayMul[i] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();

        RomanNumber[] romanNumberArrayDiv = new RomanNumber[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write(i + ". " + "DIV:");
            Console.WriteLine();
            romanNumberArrayDiv[i] = new RomanNumber((ushort)((i + 1) * 2));
            romanNumberArrayDiv[i] = RomanNumber.Div(romanNumberArrayDiv[i], new RomanNumber((ushort)2));

            Console.Write(romanNumberArrayDiv[i] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}