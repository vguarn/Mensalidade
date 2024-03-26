using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensalidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da anuidade do curso: ");
             double anuidade = double.Parse(Console.ReadLine());
             double mensalidade = anuidade / 12;
            Console.WriteLine("Digite o valor da matrícula: ");
             double matricula = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do material do curso: ");
             double material = double.Parse(Console.ReadLine());

            int cont = 2;

            double mensalidade1 = mensalidade + material + matricula;
            Console.WriteLine("Mensalidade 1, valor: " +mensalidade1.ToString("C"));

            while (cont >1 && cont <=12) 
            { 
                Console.WriteLine("Mensalidade " + cont + "valor: " +mensalidade.ToString("C"));
                cont++;
            }

            Console.ReadKey();

        }
    }
}
