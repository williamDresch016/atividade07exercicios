using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            
        

        void atividade01 ()
        {
            double numero;
            Console.WriteLine("Digite um numero :");
            numero = double.Parse(Console.ReadLine());

            if (numero > 10)
            {
                numero = numero * 0.1;
            }
            Console.WriteLine("O resultado é: " + numero);

            Console.ReadKey();
        }

        void atividade77 ()
        {
            float numero;

            Console.WriteLine("Digite um Numero maior que 100 : ");
            numero = float.Parse(Console.ReadLine());

            if (numero > 100)
            {
                numero = numero + 150f;
                Console.WriteLine("Resultado : " + numero);
                Console.ReadKey();

            }

        }

        void atividade84 ()
        {

            float nota1, nota2, nota_media;
            Console.WriteLine("Digite a 2 media do aluno : ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 3 media do aluno :");
            nota2 = float.Parse(Console.ReadLine());

            nota_media = (nota1 + nota2) / 2;

            if (nota_media > 6)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }
            Console.ReadKey();
        }

        void atividade81 ()
        {
            string nome;
            int media;

            Console.WriteLine("Digite o Nome do Aluno: ");
            nome = Console.ReadLine();

            Console.WriteLine("Media do Aluno :");
            media = int.Parse(Console.ReadLine());

            if (media >= 6)
            {
                Console.WriteLine("Aluno Aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado!");

            }
        }
    }
}
