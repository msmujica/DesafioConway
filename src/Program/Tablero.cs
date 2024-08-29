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
        // Se crea un tablero 2D de booleanos.
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        
        //Recorremos cada linea del eje Y e X.
        for (int  y = 0; y < contentLines.Length; y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                // Si se encuentra un 1, se marca la posicion como True.
                if(contentLines[y][x] == '1')
                { 
                    board[x, y] = true;
                }
            }
        }
        //Devolvemos el tablero de booleanos.
        return board;
    }
}