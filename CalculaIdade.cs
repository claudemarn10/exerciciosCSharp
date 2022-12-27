using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Elabore um algoritmo  que calcule a idade média de cinco alunos
namespace CalculaMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declara variaveis    
            Double idade1 = 0;
            Double idade2 = 0;
            Double idade3 = 0;
            Double idade4 = 0;
            Double idade5 = 0;
            Double media = 0;

            //solicita ao usuario
            Console.WriteLine("Informe a idade 1º");
            idade1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe a idade 2º");
            idade2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a idade 3º");
            idade3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a idade 4º");
            idade4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a idade 5º");
            idade5 = Convert.ToDouble(Console.ReadLine());
                             

            media = (idade1 + idade1 + idade3 + idade4 + idade5) / 5;
            Console.WriteLine("A idade média dos alunos é:" + media);

            Console.ReadKey();
        }
    }
}
