using System;
using System.Collections.Generic;
using System.Text;
namespace op_lab7
{
    class Program
    {

        static void Main(string[] args)
        {
            Board mineBoard = new();

            List<string> menuFifure = new()
            {
                "Ферзь",
                "Конь",
                "Пешка",
                //"Закончить программу"
            };
            List<string> addNewFigure = new()
            {
                "Добавить ещё одину фигуру",
                "Закончить"
            };
            //чертим пусутю

            PrintBoard(mineBoard);
            //забиваем клетку
            Cell playerCell1 = SetPlayerCell(mineBoard);
            
            //спросим у пользователя о 1 фигуре:
            Console.CursorVisible = false;


                Console.WriteLine(Choise(menuFifure));
            PrintBoard(mineBoard);
            while (true) 
            {
                string selectedMenuItem = MenuForChess.DrawMenu(addNewFigure);
                if (selectedMenuItem == "Добавить ещё одину фигуру")
                    Choise(menuFifure);
                else if (selectedMenuItem == "Закончить")
                    break;
            } 
            Console.Clear();
        }
        
        static string Choise(List<string> menu)
        {
            Console.WriteLine("Выберите фигуру: ");
            string selectedMenuItem = MenuForChess.DrawMenu(menu);
            return selectedMenuItem;
        }
        private static Cell SetPlayerCell(Board mineBoard)
        {
            Console.WriteLine("Введите клетку, в которой будет стоять фигура:");
            Console.Write("Введите номер строки: ");
            int rowForCell = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("Введите номер столбца: ");
            int columnForCell = Convert.ToInt32(Console.ReadLine()) - 1;

            mineBoard.board[rowForCell, columnForCell].occupied = true;
            return mineBoard.board[rowForCell, columnForCell];
        }

        private static void PrintBoard(Board mineBoard)
        {

            for (int i = 0; i < mineBoard.size; i++)
            {

                for (int j = 0; j < mineBoard.size; j++)
                {

                    Cell cell = mineBoard.board[i, j];
                    if (cell.occupied == true)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(" X ");
                        Console.ResetColor();

                    }
                    
                    else Console.Write(" . ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
        }

        private void ShowFiguresSteps(int x, int y, string figeureName)
        {
            switch (figeureName)
            {
                case "Пешка":
                    break;
                case "Конь":
                    break;
                case "Ферзь":
                    break;
            }
                
        }

    }
}

