using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();
c.Soma(1, 2);
c.Subtrair(1, 2);
c.Multiplicar(1, 2);
c.Dividir(1, 2);

Console.WriteLine($"{c.Soma(1, 2)}");
Console.WriteLine($"{c.Subtrair(1, 2)}");
Console.WriteLine($"{c.Multiplicar(1, 2)}");
Console.WriteLine($"{c.Dividir(1, 2)}");