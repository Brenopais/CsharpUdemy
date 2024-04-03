using System;
using MeuProjeto.Models;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de participantes: ");
            int quantidadeParticipantes = int.Parse(Console.ReadLine());

            string[] nomes = new string[quantidadeParticipantes];
            int[] idades = new int[quantidadeParticipantes];

            for (int i = 0; i < quantidadeParticipantes; i++)
            {
                Console.Write($"Nome do participante {i + 1}: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Idade do participante {i + 1}: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            string vovo = Viagem.IdentificarVovo(nomes, idades);
            string bebe = Viagem.IdentificarBebe(nomes, idades);
            double porcentagemMaisDe25 = Viagem.CalcularPorcentagemMaisDe25(idades);

            Console.WriteLine($"O vovô(ó) da viagem é: {vovo}");
            Console.WriteLine($"O bebê da viagem é: {bebe}");
            Console.WriteLine($"Porcentagem de participantes com mais de 25 anos: {porcentagemMaisDe25}%");
        }
    }
}

