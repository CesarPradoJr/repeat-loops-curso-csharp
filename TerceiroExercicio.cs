using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeat_loops_curso_csharp
{
    internal class TerceiroExercicio
    {
        internal void Executar()
        {
            List<string> alunos = new List<string>{"Ana", "João", "Carlos", "Mariana"};
            Console.Write("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            while (nomeAluno != null)
            {
                if( alunos.Contains(nomeAluno) )
                {
                    Console.WriteLine($"O aluno {nomeAluno} está presente na posição: {alunos.IndexOf(nomeAluno)}");
                    break;
                }
                else
                {
                    Console.WriteLine($"O aluno {nomeAluno} não está presente na lista.");
                    break;
                }
            }
        }
    }
}
