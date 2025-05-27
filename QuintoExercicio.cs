using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeat_loops_curso_csharp
{
    internal class QuintoExercicio
    {
        internal void Executar()
        {
            int opcao;
            int temperatura = 0;
            int convercao = 0;

            do
            {
                Console.WriteLine("1 - Celsius para Fahrenheit");
                Console.WriteLine("2 - Fahrenheit para Celsius");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a temperatura:");
                        temperatura = int.Parse(Console.ReadLine());
                        convercao = (temperatura * 9 / 5) + 32;
                        Console.WriteLine($"{temperatura}ºC equivalem a {convercao}ºF");
                        break;
                    case 2:
                        Console.WriteLine("Digite a temperatura:");
                        temperatura = int.Parse(Console.ReadLine());
                        convercao = (temperatura - 32) * 5 / 9;
                        Console.WriteLine($"{temperatura}ºF equivalem a {convercao}ºC");
                        break;
                    case 3:
                        Console.WriteLine("Encerrando a aplicação.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }
            while (opcao != 3);
        }
    }
}
