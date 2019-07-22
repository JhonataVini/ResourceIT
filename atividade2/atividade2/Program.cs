using System;

namespace atividade2
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Um funcionário de uma empresa recebe aumento salarial anualmente.Sabe - se que:
            //Esse funcionário foi contratado em 2005, com salário 
            //inicial de R$ 1.000,00.Em 2006, ele recebeu aumento de 1,5 % sobre seu salário inicial.
            // A partir de 2007(inclusive), os aumentos salariais
            //sempre corresponderam ao dobro do percentual do ano anterior. Faça um programa que
            //determine o salário atual desse funcionário.


           float salario_ini = 1000,
                salario_total,
                percentual;

            float funcionario;

            Console.WriteLine(" #################################### ");
            Console.WriteLine(" Funcionario recebe = " + salario_ini+ " Em 2005");
            percentual = ((float)15/100)*1000;

            Console.WriteLine(" #################################### ");
            salario_total = salario_ini + percentual;
            Console.WriteLine(" Funcionario recebe = " + salario_total + " Em 2006");

            Console.WriteLine(" #################################### ");
            salario_total = salario_ini + (percentual * 2);
            Console.WriteLine(" Funcionario recebe = " + salario_total + " Em 2007");

            Console.WriteLine(" #################################### ");
            Console.WriteLine(" Percentual de reajuste é = "+percentual);

            Console.WriteLine(" #################################### ");
            Console.ReadKey();

        }
    }
}
