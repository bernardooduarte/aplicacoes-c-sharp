using System;

namespace LinhaQuadradoCubo {
    class Program {
        static void Main(string[] args) {

            int qtd_linhas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd_linhas; i++) {

                int linha = i;
                int quadrado = i * i;
                int cubo = i * i * i;

                Console.WriteLine($"{linha} {quadrado} {cubo}");
            }
        }
    }
}
