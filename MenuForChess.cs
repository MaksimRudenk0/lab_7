using System;
using System.Collections.Generic;

namespace op_lab7
{
    public class MenuForChess
    {
        private static int _index = 0;
        public static string DrawMenu(List<string> items)
        {

            for (int i = 0; i < items.Count; i++)
            {
                if (i == _index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (_index == items.Count - 1)
                {
                    _index = 0; //Remove the comment to return to the topmost item in the list
                }
                else { _index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (_index <= 0)
                {
                    _index = items.Count - 1; //Remove the comment to return to the item in the bottom of the list
                }
                else { _index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[_index];
            }
            else
            {
                
                return "";
            }
            Console.Clear();
            return "";
        }
    }
}

