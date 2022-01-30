using System;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
            string[] array =
            {
                "abc",
                "12",
                "asd",
                "dd",
                "123",
                "123d"
            };

            var result = new string[array.Length];
            var realSize = 0;

