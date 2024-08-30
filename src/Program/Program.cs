using Ucu.Poo.GameOfLife;
// Se decidio dividir el codigo en 4 clases o tarjetas CRC, Imprimir Tablero, Lector, Logica y Tablero.
// Los mismos se explican la decision en cada clase, al inicio.


Lector url = new Lector();
Tablero tablero = new Tablero();
Logica logica = new Logica();
ImprimirTablero imprimir = new ImprimirTablero();

string[] content = url.getLeerArchivo("board.txt");
bool[,] matriz = tablero.getLeerTablero(content);
bool[,] newMatriz = logica.setLogica(matriz);
imprimir.imprimirTableros(newMatriz, logica);

