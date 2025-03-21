using System;
using Spectre.Console;
using SoGoodLib;
public static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(SoGoodClass.SoGoodMethod());
        string pasta = "tux.jpg";
        int tamanho = 20;
        //Set the max width of the image.
        if (args.Length >= 2)
        {
            pasta = args[0];

            if (!int.TryParse(args[1], out tamanho) || tamanho <= 0)
            {
                tamanho = 20;
            }
        }
        //Render the image to the console
        CanvasImage image = new CanvasImage(pasta);
        image.MaxWidth(tamanho);
        //Render the image to the console
        AnsiConsole.Write(image);
    }
}