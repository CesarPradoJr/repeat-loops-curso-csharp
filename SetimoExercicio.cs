using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeat_loops_curso_csharp
{
    internal class SetimoExercicio
    {
        internal void Executar()
        {
            int numeroUsuario;
            int resultado = 0;
            Console.Write("Informe o número a ser mostrada a tabela de multiplicação: ");
            numeroUsuario = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10;  i++)
            {
                resultado = numeroUsuario * i;
                Console.WriteLine($"{numeroUsuario} * {i} = {resultado}");
            }
        }
    }
}
