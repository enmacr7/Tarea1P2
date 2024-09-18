using System;
using Formas;
class Programa
{
    static void Main(string[] args)
    {
        Shape[] formas = new Shape[]
        {
            new Rectangulo(25, 35),
            new Triangulo(25, 35),
            new Circle(44)
        };

        double[] areas = new double[formas.Length];

        for (int i = 0; i < formas.Length; i++)
        {
            areas[i] = formas[i].CalculateSurface();
            Console.WriteLine($"El área de la forma {i + 1} es: {areas[i]:F2}");
        }
    }
}

