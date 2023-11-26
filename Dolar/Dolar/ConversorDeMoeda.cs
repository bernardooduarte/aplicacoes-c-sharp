namespace Dolar {
    class ConversorDeMoeda {

        public static double IOF = 0.06;
        public static double CalcularValorTotal(double cotacao, double qtddolar) {

            return qtddolar * cotacao + cotacao * qtddolar * IOF;
        }


    }
}
