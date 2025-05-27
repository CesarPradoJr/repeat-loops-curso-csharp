namespace repeat_loops_curso_csharp
{
    internal class SextoExercicio
    {
        internal void Executar()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("A contagem chegou ao fim.");
        }
    }
}
