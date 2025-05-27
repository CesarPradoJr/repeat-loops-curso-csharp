namespace repeat_loops_curso_csharp
{
    internal class PrimeiroExercicio
    {
        internal void  Executar()
        {
            int opcao;
            int total = 0;
            Console.WriteLine("Deseja adicionar um produto ao estoque?");
            Console.WriteLine("1 - Sim | 0 - Não");
            opcao = int.Parse(Console.ReadLine());

            while (opcao != 0) 
            {
                if (opcao == 1)
                {
                    Console.WriteLine("Quantidade:");
                    int quantidade = int.Parse(Console.ReadLine());
                    total += quantidade;
                    Console.WriteLine($"Estoque atual: {total}.");
                    Console.WriteLine("Deseja continuar?");
                    Console.WriteLine("1 - Sim | 0 - Não");
                    opcao = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
            Console.WriteLine("Obrigado por usar nosso sistema de estoque!");
        }
    }
}
