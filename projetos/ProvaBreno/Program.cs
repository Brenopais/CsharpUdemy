using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaBreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeVovo = "";
            string nomeBebe = "";
            int idadeMaxima = int.MinValue;
            int idadeMinima = int.MaxValue;
            int pessoascMais25 = 0;

            Console.Write("Informe a quantidade de participantes: ");
            int Qparticipantes = int.Parse(Console.ReadLine());
            

            // Loop para cada participante
            for (int i = 1; i <= Qparticipantes; i++)
            {
                Console.Write($"Nome do participante {i}: ");
                string nome = Console.ReadLine();

                Console.Write($"Idade do participante {i}: ");
                int idade = int.Parse(Console.ReadLine());

                // Verifica se é o vovô
                if (idade > idadeMaxima)
                {
                    idadeMaxima = idade;
                    nomeVovo = nome;
                }

                // Verifica se é o bebê
                if (idade < idadeMinima)
                {
                    idadeMinima = idade;
                    nomeBebe = nome;
                }

                // Conta os participantes com mais de 25 anos
                if (idade > 25)
                {
                    pessoascMais25++;
                }
            }
            // Mostra o nome do vovô
            Console.WriteLine($"O vovô(ó) da viagem é: {nomeVovo}");

            // Mostra o nome do bebê
            Console.WriteLine($"O bebê da viagem é: {nomeBebe}");

            // Calcula e mostra a porcentagem de participantes com mais de 25 anos
            double porcentagemMais25 = ((double)pessoascMais25 / Qparticipantes) * 100;
            Console.WriteLine($"Porcentagem de participantes com mais de 25 anos: {porcentagemMais25}%");

        }
    }
}
