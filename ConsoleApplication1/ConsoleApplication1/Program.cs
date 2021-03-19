using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el ancho del rectángulo: ");
            float ancho;
            ancho = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del rectángulo:");
            float altura;
            altura = float.Parse(Console.ReadLine());
            float area = altura * ancho;
            float perimetro = (altura * 2) + (ancho * 2);
            Console.WriteLine("El área del rectángulo es: " + area.ToString("f2") +
            " y el perímetro es: " + perimetro.ToString("F2"));
            Console.Write("Presione enter para continuar");
            Console.ReadLine();
            Console.Write("Ingrese la medida de un lado del cuadrado: ");
            float lado;
            lado = float.Parse(Console.ReadLine());
            float areac = lado * lado;
            float perimetroc = lado + lado + lado + lado;
            Console.WriteLine("El área del cuadrado es: { 0 }, y el perímetro es: { 1 }" ,areac,perimetroc);
            Console.Write("Presione enter para continuar");
            Console.ReadLine();
            Console.Write("Ingrese la base del triángulo equilátero: ");
            float baset;
            baset = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo equilátero: ");
            float alturat;
            alturat = float.Parse(Console.ReadLine());
            float areat = (baset * alturat) / 2;
            float perimetrot = baset * 3;
            Console.WriteLine("El área del triángulo es: " + areat.ToString("f2") +
            " y el perímetro es: " + perimetrot.ToString("F2"));
            Console.Write("Presione enter para salir");
            Console.ReadLine();
        }
    }
}
