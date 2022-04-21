using System;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Se crea la clase ConsolePrinter para poder cumplir con SRP, ya que previamente
    /// quien poseía la responsabilidad de imprimir en consola era Recipe, pero pensando a futuro
    /// puede ser que queramos más de una forma de imprimir, no solo en consola sino que capaz en papel,
    /// y además podríamos querer agregar el costo de la receta, lo cual serian 2 razones de cambio
    /// si no fuera por la nueva clase ConsolePrinter.
    /// </summary>
    public class ConsolePrinter
    {
        public static void Print(StringBuilder text)
        {
            Console.WriteLine(text);
        }
    }
}