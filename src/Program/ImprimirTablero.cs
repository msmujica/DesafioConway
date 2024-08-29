using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;


public class ImprimirTablero
{
    public ImprimirTablero()
    {
    }
    
    public void imprimirTableros(bool[,] matriz, Logica logica)
    {
        bool[,] matrizGame = matriz; //variable que representa el tablero.
        int width =  matrizGame.GetLength(0);//variabe que representa el ancho del tablero.
        int height = matrizGame.GetLength(1);//variabe que representa altura del tablero.
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            
            // Recorremos las filas y las columnas del tablero.
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    // Si la celula esta viva la reeplazamos por |X|, en caso de que este muerta se le agrega ___.
                    if(matrizGame[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            // Mostramos el tablero
            Console.WriteLine(s.ToString());
            
            // Actualizamos el tablero aplicando a Logica
            matrizGame = logica.setLogica(matrizGame);
            
            // Se hace una pausa de 300 milisegundos
            Thread.Sleep(300);
        }
    }   
}