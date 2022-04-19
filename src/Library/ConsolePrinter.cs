using System;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Se crea la clase ConsolePrinter para poder cumplir con SRP, ya que previamente
    /// quien poseia la responsabilidad de imprimir en consola era Recipe, pero pensando a futuro
    /// puede ser que quieramos mas de una forma de imprimir, no solo en consola sino que capaz en papel.
    /// </summary>
    public class ConsolePrinter
    {
        public static void Print(StringBuilder text)
        {
            Console.WriteLine(text);
        }
    }
}