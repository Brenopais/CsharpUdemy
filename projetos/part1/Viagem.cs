using System;

namespace MeuProjeto.Models
{
    public class Viagem
    {
        public static string IdentificarVovo(string[] nomes, int[] idades)
        {
            int indiceVovo = 0;
            int maiorIdade = idades[0];

            for (int i = 1; i < idades.Length; i++)
            {
                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    indiceVovo = i;
                }
            }

            return nomes[indiceVovo];
        }

        public static string IdentificarBebe(string[] nomes, int[] idades)
        {
            int indiceBebe = 0;
            int menorIdade = idades[0];

            for (int i = 1; i < idades.Length; i++)
            {
                if (idades[i] < menorIdade)
                {
                    menorIdade = idades[i];
                    indiceBebe = i;
                }
            }

            return nomes[indiceBebe];
        }

        public static double CalcularPorcentagemMaisDe25(int[] idades)
        {
            int totalParticipantes = idades.Length;
            int maisDe25 = 0;

            foreach (int idade in idades)
            {
                if (idade > 25)
                {
                    maisDe25++;
                }
            }

            return (double)maisDe25 / totalParticipantes * 100;
        }
    }
}
