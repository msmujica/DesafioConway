using Ucu.Poo.GameOfLife;

Lector url = new Lector();
Tablero tablero = new Tablero();
Logica logica = new Logica();
ImprimirTablero imprimir = new ImprimirTablero();

string[] content = url.getLeerArchivo("board.txt");
bool[,] matriz = tablero.getLeerTablero(content);
bool[,] newMatriz = logica.setLogica(matriz);
imprimir.imprimirTableros(newMatriz, logica);

