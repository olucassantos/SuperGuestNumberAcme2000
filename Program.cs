using System;
using System.ComponentModel.Design;

namespace SuperGuestNumberAcme2000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int palpite;

            // Gerar um número aleatório entre 0 e 100
            Random random = new Random();
            int numeroSorteado = random.Next(0, 101);

            // Solicitar um palpite ao jogador
            Console.WriteLine("Qual o seu palpite?");
            palpite = int.Parse(Console.ReadLine());

            // Verifica se o jogador acertou
            if (palpite == numeroSorteado)
            {
                // SIM
                Console.WriteLine("Vitória!");
                Console.WriteLine($"O número sorteador era: {numeroSorteado}");
            }
            else
            {
                // Jogador não acertou, verifica se o numero é maior
                if (palpite > numeroSorteado)
                {
                    Console.WriteLine($"O seu palpite {palpite} é MAIOR que o sorteado!");
                } 
                else
                {
                    Console.WriteLine($"O seu palpite {palpite} é MENOR que o sorteado!");
                }

                // Segunda tentativa
                Console.WriteLine("Aperte uma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

                // Solicitar um segundo palpite ao jogador
                Console.WriteLine("Qual o seu segundo palpite?");
                palpite = int.Parse(Console.ReadLine());

                // Verifica se o jogador acertou
                if (palpite == numeroSorteado)
                {
                    Console.WriteLine("Vitória!");
                    Console.WriteLine($"O número sorteador era: {numeroSorteado}");
                }
                else
                {
                    // Jogador não acertou, verifica se o numero é maior
                    if (palpite > numeroSorteado)
                    {
                        Console.WriteLine($"O seu palpite {palpite} é MAIOR que o sorteado!");
                    }
                    else
                    {
                        Console.WriteLine($"O seu palpite {palpite} é MENOR que o sorteado!");
                    }

                    // Ultima tentativa
                    Console.WriteLine("Aperte uma tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();

                    // Solicitar um segundo palpite ao jogador
                    Console.WriteLine("Qual o seu ultimo palpite?");
                    palpite = int.Parse(Console.ReadLine());

                    // Verifica se o jogador acertou
                    if (palpite == numeroSorteado)
                    {
                        Console.WriteLine("Vitória!");
                        Console.WriteLine($"O número sorteador era: {numeroSorteado}");
                    }
                    else
                    {
                        // Mostra a derrota do jogador.
                        Console.WriteLine("DERROTA!");
                        Console.WriteLine($"O número sorteador era: {numeroSorteado}");
                    }
                }
            }
        }
    }
}
