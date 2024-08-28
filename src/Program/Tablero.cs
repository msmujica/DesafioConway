using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Ucu.Poo.GameOfLife;

public class Tablero
{
    public Tablero(){
    }
    
    public bool[,] getLeerTablero(string[] contentLines)
    {
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        for (int  y = 0; y < contentLines.Length; y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if(contentLines[y][x] == '1')
                { 
                    board[x, y] = true;
                }
            }
        }
        return board;
    }
}