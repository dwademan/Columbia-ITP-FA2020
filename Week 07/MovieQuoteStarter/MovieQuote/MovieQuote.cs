using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MovieQuote
{
    class MovieQuote
    {
        private string Text;
        private string Author;
        private int Year;

        public MovieQuote(string text, string author, int year)
        {
            Text = text;
            Author = author;
            Year = year;
        }

        public void Display()
        {
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine($"\n\"{Text}\"");
            WriteLine($"  — {Author} ({Year})\n");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
