// See https://aka.ms/new-console-template for more information
using System;

namespace UsingCurrent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ty gia: ");
            float usd = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so USD ban co: ");
            float myUSD = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so tien viet ban co sau khi doi la: " + usd * myUSD);
        }
    }
}
