using System;

namespace ForAndForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR É UTILIZADO QUANDO SE SABE QUANTAS VEZES O BLOCO DE CÓDIGO DEVE SER EXECUTADO
            // ELE É MAIS RÁPIDO QUE O FOREACH

            for (int i = 0; i < 10; i++)                                                                    
            {
                Console.WriteLine(i);           
            }

            // FOREACH É UTILIZADO QUANDO SE QUER PERCORRER UMA COLEÇÃO DE DADOS
            // ELE É MAIS LENTO QUE O FOR, USADO EXCLUSIVAMENTE COM ARRAYS

            string[] nomes = { "Gustavo", "da", "Silveira", "Roldão" };

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }

}
