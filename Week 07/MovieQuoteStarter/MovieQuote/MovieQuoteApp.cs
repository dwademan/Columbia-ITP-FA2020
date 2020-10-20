using System;
using static System.Console;

namespace MovieQuote
{
    class MovieQuoteApp
    {
        public void Run()
        {
            Title = "Movie Quote of the Day";

            WaitForKey();
        }

        private void WaitForKey()
        {
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("(Press any key)");
            ReadKey(true);
        }
    }
}
