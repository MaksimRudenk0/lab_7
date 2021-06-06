using System;
using System.Collections.Generic;
using op_lab7;

class Knight : Figure
{
    public Knight(string name, int x, int y, Board board) : base(name, x, y, board) { }

    public override void CalculatePossibleKills()
    {
        //чикнуть на правильность направления хода
        var availablePoss = new List<Cell>()
        {
            new Cell(position.colNumber + 2, position.rowNumber + 1),
            new Cell(position.colNumber + 1, position.rowNumber + 2),
            new Cell(position.colNumber - 1, position.rowNumber + 2),
            new Cell(position.colNumber - 2, position.rowNumber + 1),
            new Cell(position.colNumber - 2, position.rowNumber - 1),
            new Cell(position.colNumber - 1, position.rowNumber - 2),
            new Cell(position.colNumber + 2, position.rowNumber + 1),
            new Cell(position.colNumber + 1, position.rowNumber - 2),
            new Cell(position.colNumber + 2, position.rowNumber - 1),
        };

        possibleKills = new List<Figure>();
        foreach (var pos in availablePoss)
        {
            possibleKills.Add(board.GetFigureOnCell(pos));
        }
    }

}