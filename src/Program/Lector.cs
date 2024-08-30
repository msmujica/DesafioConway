/*
 El lector su única responsabilidad es leer un archivo y devolver su contenido.
 Esto se va bien con SRP, ya que se encarga exclusivamente de la entrada de datos.
 La misma no colabora con ninguna.
*/
using System;
using System.IO;

namespace Ucu.Poo.GameOfLife;

public class Lector
{
    public Lector()
    {
    }

public string[] getLeerArchivo(string url)
    {
        // Se lee el contenido del archivo en un solo string, (direccion proveido por "url").
        string content = File.ReadAllText(url);
        // Dividimos el contenido de lineas separadas por un espacio, esto se deposita en un array de strings.
        string[] contentLines = content.Split('\n');

        // Devolvemos el array de strings.
        return contentLines;
    }
}