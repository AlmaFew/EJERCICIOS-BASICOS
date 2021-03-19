using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            contenido = vial.ReadAllText(fichero);
            string[] lineas = contenido.Split(Environment.NewLine);
            foreach (string linea in lineas)
            {
                Console.WriteLine(linea);
            }
    }
}
