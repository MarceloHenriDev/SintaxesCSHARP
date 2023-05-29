using System.Globalization;
namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            // if else mas com sintaxe diferente. expressão condicional ternaria
            // (condição) ? valor_se_verdadeiro : valor_se_falso
         
            Console.WriteLine(desconto);

        }
    }
}
