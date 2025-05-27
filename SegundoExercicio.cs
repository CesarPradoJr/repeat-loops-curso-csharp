namespace repeat_loops_curso_csharp
{
    internal class SegundoExercicio
    {
        internal void Executar()
        {
            int numeroSecreto = 4;
            Console.Write("Tente adivinhar o número entre 1 e 10: ");
            int numeroUsuario = int.Parse(Console.ReadLine());

            while (numeroUsuario > 0)
            {
                if (numeroUsuario > 0 && numeroUsuario < 11)
                {
                    if(numeroUsuario > numeroSecreto)
                    {
                        Console.Write("O número é menor, tente novamente :");
                        numeroUsuario = int.Parse (Console.ReadLine());
                    }
                    if (numeroUsuario < numeroSecreto)
                    {
                        Console.Write("O número é maior, tente novamente :");
                        numeroUsuario = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Parabéns, você acertou!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("O número deve estar entre 1 e 10");
                    Console.Write("Tente novamente :");
                    numeroUsuario = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
