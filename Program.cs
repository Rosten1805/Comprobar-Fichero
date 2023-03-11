using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string ruta = "C:/campions.txt";
        string himno = "Añadir letra de tu equipo favorito";


        if (File.Exists(ruta))
        {
            Console.WriteLine("El Himno ha sido añadido");
        }
        else
        {
            // Crear el archivo y añadir el himno
            File.WriteAllText(ruta, himno);
            Console.WriteLine("Archivo creado y himno añadido.");
        }

        Console.ReadLine();
    }
}
