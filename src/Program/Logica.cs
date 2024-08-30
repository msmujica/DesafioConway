/*
 La clase Logica contiene la lógica del Juego de la Vida. 
 Su responsabilidad es tomar el tablero actual y calcular el siguiente estado del tablero según las reglas del juego. 
 La misma colabora con Tablero.
 */
namespace Ucu.Poo.GameOfLife;

public class Logica
{
    public Logica()
    {
    }

    public bool[,] setLogica(bool[,] matriz)
    {
        bool[,] gameBoard = matriz;
        // Obtenemos el ancho y el largo del tablero.
        int boardWidth = gameBoard.GetLength(0);
        int boardHeight = gameBoard.GetLength(1);

        // Creamos una copia del tablero para hacer cambios sin afectar al tablero original.
        bool[,] cloneboard = new bool[boardWidth, boardHeight];
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                
                // Contamos las celulas vecinas.
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        // Verifica que el vecino este vivo.
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j])
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                
                if (gameBoard[x, y])
                {
                    aliveNeighbors--;
                }

                if (gameBoard[x, y] && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneboard[x, y] = false;
                }
                else if (gameBoard[x, y] && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard[x, y] = false;
                }
                else if (!gameBoard[x, y] && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard[x, y] = true;
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard[x, y] = gameBoard[x, y];
                }
            }
        }

        gameBoard = cloneboard;
        return gameBoard;
    }
}