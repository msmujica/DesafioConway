using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;


public class ImprimirTablero
{
    public ImprimirTablero()
    {
    }
    
    public void imprimir(bool[,] bo)
    {
        bool[,] b = bo; //variable que representa el tablero
        int width =  b.GetLength(0);//variabe que representa el ancho del tablero
        int height = b.GetLength(1);//variabe que representa altura del tablero
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(b[x,y])
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
            Console.WriteLine(s.ToString());
            Logica logi = new Logica();
            logi.logic(b);
            Thread.Sleep(300);
        }
    }   
}