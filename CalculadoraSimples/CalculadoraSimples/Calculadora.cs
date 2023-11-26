namespace CalculadoraSimples {
    class Calculadora {

        public static double Adicao(double a, double b) {
            return a + b;
        }

        public static double Subtracao(double a, double b) {
            return a - b;
        }

        public static double Multiplicacao(double a, double b) {
            return a * b;
        }

        public static double Divisao(double a, double b) {
            if(b != 0) {
                return a / b;
            } else {
                return 0;
            }
        }
    }
}
