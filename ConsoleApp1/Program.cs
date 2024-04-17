// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Hello, World!");


Console.WriteLine(ConvertToBinary(26));

Console.ReadLine();
//*Build a console application to convert from base-ten to base-two
// using the following algorithm.

//Input value is repeatedly divided by 2, with the remainders
// giving the binary digits in the base-two representation from
// left to right.

// For example, the base-two representation of 26 is 11010.

// 26 / 2 = 13, R 0
// 13 / 2 = 6, R 1
// 6 / 2 = 3, R 0
// 3 / 2 = 1, R 1
// 1 / 2 = 0, R 1

//*/

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