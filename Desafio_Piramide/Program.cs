namespace DesafioPiramide;

internal class Program
{
    static void Main(string[] args)
    {
        int cerca = 1;
        int contador;
        Console.WriteLine("Digite um valor: ");
        int linhas = Convert.ToInt32(Console.ReadLine());
        contador = linhas;

        if (contador > 3 && contador <= 8)
            for (int i = 0; i < contador; i++)
            {
                for (int j = 1; j <= linhas; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= cerca; k++)
                {
                    Console.Write("#");
                }

                linhas--;
                cerca++;
                Console.WriteLine();
            }
        else
        {
            Console.WriteLine("As linhas devem estar maior que 3 e menor ou igual a 8!");
        }
        Console.ReadLine();
    }
}
