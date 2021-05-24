﻿using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
        
        private static string ReadFromKeybooard(string label)
        {
            Console.Write(label);
            string text = Console.ReadLine();

            return string.IsNullOrWhiteSpace(text)?null:text;
            
        }

        static void Assignement4UsingIf()
        {
            string text = ReadFromKeybooard("Text=");
            if (string.IsNullOrWhiteSpace(text))
            {
                text = ReadFromKeybooard("Text(second attempt)");
            }

            if (string.IsNullOrWhiteSpace(text))
            {
                text = ReadFromKeybooard("Text(third attempt)");
            }

            if (string.IsNullOrWhiteSpace(text))
            {
                text = ReadFromKeybooard("Nu am continut");
            }
            else
            {
                Console.WriteLine(text);
            }
        }

        static void Assignement4UsingNullcoalesce()
        {
            string text = ReadFromKeybooard("Text=")
                ?? ReadFromKeybooard("Text(second attempt)")
                ?? ReadFromKeybooard("Text(third attempt)")
                ?? ReadFromKeybooard("Nu am continut");

            Console.WriteLine(text);
        }
    }
}
