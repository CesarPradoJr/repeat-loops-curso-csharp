using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeat_loops_curso_csharp
{
    internal class NonoExercicio
    {
        internal void Executar()
        {
            List<double> notas = new List<double> { 8.5, 6.2, 9.1, 5.8, 7.4 };

            for (int i = 0; i < notas.Count; i++)
            {
                if (notas[i] > 7)
                {
                    Console.WriteLine($"O aluno com a nota {notas[i]} está indo muito bem!");
                }
                else
                {
                    Console.WriteLine($"O aluno com a nota {notas[i]} está abaixo da média!");
                }

            }
        }
    }
}
