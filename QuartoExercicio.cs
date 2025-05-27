﻿namespace repeat_loops_curso_csharp
{
    internal class QuartoExercicio
    {
        internal void Executar()
        {
            int senhaGerada = 0;
            int senhaAtual = 0;
            int opcao;


            do
            {
                Console.WriteLine("1 - Gerar nova senha");
                Console.WriteLine("2 - Chamar próxima senha");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        senhaGerada++;
                        Console.WriteLine($"Senha gerada: {senhaGerada.ToString("D3")}");
                        break;
                    case 2:
                        senhaAtual++;
                        Console.WriteLine($"Senha chamada: {senhaAtual.ToString("D3")}");
                        break;
                    case 3:
                        Console.WriteLine("Encerrando sistema");
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
