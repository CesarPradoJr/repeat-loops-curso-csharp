using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeat_loops_curso_csharp
{
    internal class DecimoExercicio
    {
        internal void Executar()
        {
            int qtdNumerosImpar = 0;
            for ( int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                int numeroUsuario = int.Parse(Console.ReadLine());
                if ( numeroUsuario % 2 == 0 )
                {
                    continue;
                }
                else
                {
                    qtdNumerosImpar++;
                }
            }
            Console.WriteLine($"Você digitou {qtdNumerosImpar} números ímpares.");
        }
    }
}
