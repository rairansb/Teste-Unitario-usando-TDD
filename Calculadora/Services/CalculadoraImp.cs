namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }   

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }   

        public int Dividir(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            throw new System.DivideByZeroException();
        }

        public bool EhPar(int a){
            return a % 2 == 0;
        }
    }
}