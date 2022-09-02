using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluçao_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Cont_m = 0, Cont_f = 0, Cont, Num_op, Num_maior = 0;
            double Tot_pecas = 0, Tot_folha = 0, Media_m = 0, Media_f = 0, SM = 724.00, Pecas_op, Salario_op, Salario_maior = 0;
            char Sexo_op;
            Console.WriteLine("Calculo de dados da empresa.");
            for (Cont = 1; Cont <= 15; Cont++)
            {
                Console.Write("\n\nDigite o seu numero: ");
                Num_op = int.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de peças fabricadas por voce: ");
                Pecas_op = double.Parse(Console.ReadLine());
                Console.Write("Imforme seu sexo com um caractere: ");
                Sexo_op = char.Parse(Console.ReadLine());
                while (Sexo_op != 'M' && Sexo_op != 'm' && Sexo_op != 'F' && Sexo_op != 'f')
                {
                    Console.Write("Sexo invalido! Imforme seu sexo novamente: ");
                    Sexo_op = char.Parse(Console.ReadLine());
                }
                if (Pecas_op <= 30)
                {
                    Salario_op = SM;
                }
                else if (Pecas_op > 30 && Pecas_op <= 35)
                {
                    Salario_op = SM + ((Pecas_op - 30) * 3 / 100 * SM);
                }
                else
                {
                    Salario_op = SM + ((Pecas_op - 30) * 5 / 100 * SM);
                }
                Console.WriteLine("\nOperario de numero: {0} tem o salario de: {1:f2}", Num_op, Salario_op);
                Tot_folha = Tot_folha + Salario_op;
                Tot_pecas = Tot_pecas + Pecas_op;
                if (Sexo_op == 'M' || Sexo_op == 'm')
                {
                    Media_m = Media_m + Pecas_op;
                    Cont_m = Cont_m + 1;
                }
                else
                {
                    Media_f = Media_f + Pecas_op;
                    Cont_f = Cont_f + 1;
                }
                if (Cont == 1)
                {
                    Salario_maior = Salario_op;
                    Num_maior = Num_op;
                }
                else if (Salario_op > Salario_maior)
                {
                    Salario_maior = Salario_op;
                    Num_maior = Num_op;
                }
            }
            if (Cont_m == 0)
            {
                Media_m = 0;
            }
            else
            {
                Media_m = Media_m / Cont_m;
            }
            if (Cont_f == 0)
            {
                Media_f = 0;
            }
            else
            {
                Media_f = Media_f / Cont_f;
            }
            Console.Write("\nO valor total da folha de pagamento é de: {0:f2}\nO numero total de peças fabricadas é de: {1}\nA média de peças fabricadas pelos homens é de: {2:f2}\nA média de peças fabricadas pelas mulheres é de: {3:f2} \nO número do operário ou operária de maior salário é: {4}.", Tot_folha, Tot_pecas, Media_f, Media_m, Num_maior);
            Console.Write("\n\nPrecione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
