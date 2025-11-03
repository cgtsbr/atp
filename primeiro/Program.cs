class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("MEU PRIMEIRO PROGRAMA");
        Console.WriteLine("=====================\n");
        Console.Write("Digite seu nome:");
        string trem = Console.ReadLine();
        Console.WriteLine("Olá {0}. \n \t Seja bem vindo!", trem);
        int x, y; //declaração de variáveis inteiras
        double resultado;
        Console.Write("Digite um número:");
        x = int.Parse(Console.ReadLine());
        Console.Write("Digite outro número:");
        y = int.Parse(Console.ReadLine());
        resultado = x + y;
        Console.WriteLine("Resultado: " + resultado);
        Console.Write("{0} + {1} = {2} \n", x, y, resultado);
        Console.Write("{2} - {1} = {0}", x, y, resultado);
        resultado = (double)x / y;
        Console.WriteLine("Resultado: {0:f2}", resultado);
        Console.WriteLine("Resultado: {0:C}", resultado);
        int r = x % y;
        Console.WriteLine("Resto da divisão: " + r);
    }
}