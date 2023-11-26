using System;

namespace NumerosPares {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira a quantidade de números inteiros: ");
            int qtd = int.Parse(Console.ReadLine());

            int[] numeros = new int[qtd];

            Console.WriteLine();
            for (int i = 0; i < numeros.Length; i++) {
                Console.Write($"Insira o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("Os números inteiros pares são: ");

            for (int i = 0; i < numeros.Length; i++) {
                if (numeros[i] % 2 == 0) {
                    Console.Write(numeros[i] + " ");
                }
            }
        }
    }
}
