using System;

namespace MaiorMenor {
    class Program {

        public static void Main(string[] args) {

            MaiorMenor[] nums = new MaiorMenor[5];

            for (int i = 0; i < nums.Length; i++) {
                Console.Write($"Insira o {i + 1}º número: ");
                int numeros = int.Parse(Console.ReadLine());
                nums[i] = new MaiorMenor(numeros);
            }

            int maior = nums[0].Nums;
            int menor = nums[0].Nums;

            Console.WriteLine();

            for (int i = 0; i < nums.Length; i++) {
                if (nums[i].Nums > maior) {
                    maior = nums[i].Nums;
                }
                if (nums[i].Nums < menor) {
                    menor = nums[i].Nums;
                }
            }

            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Menor: " + menor);
        }
    }
}