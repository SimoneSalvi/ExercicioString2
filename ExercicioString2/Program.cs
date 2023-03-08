using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Informe uma string: ");
        string texto1 = Console.ReadLine();

        Console.WriteLine("Informe uma string: ");
        string texto2 = Console.ReadLine();

        // comparar duas strings

        ComparaStrings(texto1, texto2);

        void ComparaStrings (string a, string b)
        {
            if (a.Equals(b))
            {
                Console.WriteLine("São iguais.");
            }
            else
            {
                Console.WriteLine("São diferentes.");
            }
        }

    }
}