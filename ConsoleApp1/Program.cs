// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Hello, World!");


Console.WriteLine(ConvertToBinary(26));

Console.ReadLine();

string ConvertToBinary(int num) // 26
{
    string result = string.Empty;

    while(num > 0)
    {
        int remainder = num % 2;
        num = num / 2;
        result = remainder.ToString() + result;
    }

    Console.WriteLine("test change");

    return result;
}