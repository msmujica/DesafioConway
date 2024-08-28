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
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');

        return contentLines;
    }
}