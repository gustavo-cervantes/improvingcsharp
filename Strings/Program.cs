using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gustavo";
            string sobreNome = "Roldão";
            Console.WriteLine(string.Concat(nome, sobreNome));

            // INTERPOLAÇÃO DE STRINGS
            Console.WriteLine($"{nome} {sobreNome}");

            string nomeCompleto = $"{nome} {sobreNome}";
            Console.WriteLine(nomeCompleto);
            int posicao = nomeCompleto.IndexOf("G");
            Console.WriteLine(posicao);

            // PEGAR O SOBRENOME A PARTIR DA STRING

            string nomeFinal = nomeCompleto.Substring(posicao);
            Console.WriteLine(nomeFinal);
            Console.WriteLine(nomeCompleto.ToUpper());
            Console.WriteLine(nomeCompleto.ToLower());

        }
    }
}