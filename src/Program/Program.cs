using Ucu.Poo.GameOfLife;
using System.IO;

Lector url = new Lector();
Tablero tab = new Tablero();
Logica log = new Logica();
ImprimirTablero imp = new ImprimirTablero();

string[] content = url.getLeerArchivo("board.txt");
bool[,] matriz = tab.getLeerTablero(content);
bool[,] newmatriz = log.logic(matriz);
imp.imprimir(newmatriz);

