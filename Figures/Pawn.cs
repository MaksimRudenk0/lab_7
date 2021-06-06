using System;
using System.Collections.Generic;
using System.Text;
using op_lab7;

class Pawn : Figure
{
    public Pawn(string name, int x, int y, Board board) : base(name, x, y, board) { }

    public override void CalculatePossibleKills()
    {
        int xStep = 0;
        switch (color)
        {
            case 1:
                xStep = 1;
                break;
            case 2:
                xStep = -1;
                break;
        }
        //чикнуть на правильность направления хода
        var availablePoss = new List<Cell>()
        {
            new Cell(position.colNumber + 1, position.rowNumber + xStep),
            new Cell(position.colNumber + 1, position.rowNumber + xStep),
        };

        possibleKills = new List<Figure>();
        foreach (var pos in availablePoss)
        {
            //сделать проверку на цвет
            possibleKills.Add(board.GetFigureOnCell(pos));
        }
    }

}