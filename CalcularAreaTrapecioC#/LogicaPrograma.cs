using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaTrapecioC_
{
    internal class LogicaPrograma
    {
        internal float CalcularAreaTrapecio(float baseMayor, float baseMenor, float altura)
        {
            float area = ((baseMayor + baseMenor) * altura) / 2;
            return area;
        }

        internal void MostrarResultado(float resultado)
        {
            Console.WriteLine("Y el area del trapecio en base a tus datos introducidos es: ");
            Console.WriteLine(resultado);
        }

        internal float ValidacionEntrada(string texto)
        {
            float numero;
            while (true)
            {
                Console.WriteLine(texto);
                string entradaString = Console.ReadLine();
                if (float.TryParse(entradaString, out numero) && numero > 0)
                {
                    return numero;
                }
                else if (float.TryParse(entradaString, out numero) && numero <= 0)
                {
                    Console.WriteLine("El número debe ser positivo. Ingresa otro valor :)");
                }
                else
                {
                    Console.WriteLine("Las letras y simbolos no son permitidos!!!");
                }
            }
        }
    }
}
