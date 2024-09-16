using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace improvingcsharp
{
    internal class strings
    {
        static void Main(string[] args)
        {
            string nome = "Gustavo";
            string sobreNome = "Roldão";
            Console.WriteLine(string.Concat(nome, sobreNome));

            // INTERPOLAÇÃO DE STRINGS
            Console.WriteLine($"{nome} {sobreNome}");
        }
    }
}
