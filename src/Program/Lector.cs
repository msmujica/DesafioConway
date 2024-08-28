using System.IO;

namespace Ucu.Poo.GameOfLife;

public class Lector
{

    private string url;

    public string Name
    {
        get { return url; }
        set { url = value; }
    }

    public Lector(string url)
    {
        this.url = url;
    }

    public void setLeerArchivo(Lector urls)
    {
        string content = File.ReadAllText(urls.url);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        for (int  y=0; y<contentLines.Length;y++)
        {
            for (int x=0; x<contentLines[y].Length; x++)
            {
                if(contentLines[y][x]=='1')
                {
                    board[x,y]=true;
                }
            }
        }
    }
}