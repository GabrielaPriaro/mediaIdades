//Problema "idades"
//Fazer um programa para ler o nome e idade de duas pessoas. Ao final mostrar uma mensagem com os
//nomes e a idade média entre essas pessoas, com uma casa decimal.

using System.Globalization;

namespace mediaIdades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double media;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();

            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();

            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            media = (double)(idade1 + idade2) / 2;

            Console.WriteLine($"A idade media de {nome1} e {nome2} eh de {media.ToString("F1", CI)} anos");
        }
    }
}
