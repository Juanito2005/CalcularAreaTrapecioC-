namespace CalcularAreaTrapecioC_
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, bienvenido al programa para calcular el area de un trapecio :)");
            LogicaPrograma logica = new LogicaPrograma();

            float baseMa = logica.ValidacionEntrada("Ingresa la base mayor del trapecio:");
            float baseMe = logica.ValidacionEntrada("Ingresa la base menor del trapecio:");
            float altura = logica.ValidacionEntrada("Por ultimo ingresa la altura del trapecio:");

            float resultado = logica.CalcularAreaTrapecio(baseMa, baseMe, altura);
            logica.MostrarResultado(resultado);

        }
    }
}
