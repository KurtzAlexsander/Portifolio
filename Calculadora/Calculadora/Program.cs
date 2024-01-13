using Calculadora;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcao calculadora = new Funcao();
        Console.WriteLine("Olá bem vindo a esta calculadora simples.");
        Console.WriteLine("Aqui podemos somar, subtrair, multiplicar e dividir");

        int x;

        while (true)
        {
            Console.WriteLine("Escolha o primeiro número.");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out x))
            {
                break;
            }
        }
        int y;

        while (true)
        {
            Console.WriteLine("Escolha o segundo número.");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out y))
            {
                break;
            }
        }

        Console.WriteLine("Agora escolha:");
        Console.WriteLine("1-Adição(+)");
        Console.WriteLine("2-Subtração(-)");
        Console.WriteLine("3-Divisão(/)");
        Console.WriteLine("4-Multiplicação(*)");
        int escolha = 0;
       while (escolha>4||escolha<1) {
            Console.WriteLine("Favor escolher uma opção válida.");
                escolha = Convert.ToInt32(Console.ReadLine()); 
        }

        switch (escolha)
        {
            case 1: Console.WriteLine(calculadora.Soma(x, y));
                break;
            case 2:
                Console.WriteLine(calculadora.Subtracao(x, y));
                break;
            case 3:
                Console.WriteLine(calculadora.Divisao(x, y));
                break;
            case 4:
                Console.WriteLine(calculadora.Multiplicacao(x, y));
                break;

        }
    }
}