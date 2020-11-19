using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays - Vetores !");//exibição da mensagem
            Console.WriteLine("");

            string[] nomes = new string[3];//criação de um array para receber 3 nomes
            int[] idades = new int[3]; //criação de um array para receber 3 idades


            for (var contador = 0; contador < 3; contador++) //começa contar pelo 0 , até 2, incrementando de 1 em 1
            {

                Console.Write($"Digite o {contador+1}º nome: ");//exibição da mensagem usando interpolação
                nomes[contador] = Console.ReadLine();//entrada e armazenamento do nome no array "nomes"
                Console.Write("Digite a idade: ");//exibição da mensagem
                idades[contador] = int.Parse(Console.ReadLine());//entrada e armazenamento da idade no array "idades"
                Console.WriteLine("");//espaçamento
            }
                Console.WriteLine("---------------------------");//espaçamento
                Console.WriteLine("");//espaçamento
                Console.WriteLine("Nomes e Idades Cadastrados:");//exibição da mensagem 
                Console.WriteLine("");//espaçamento

            for (var contador = 0; contador < 3; contador++) // vai exibir de 1 em 1 ,começando em 0 até 2,ou seja os 3 cadastros
            {   //for que apresentará os nomes e idades cadastrados no 1° for
                Console.WriteLine("Nome: "+nomes[contador]);//vai pegar o 1°nome pelo array e exibir
                Console.WriteLine("Idade: "+idades[contador]+ " anos ");//vai pegar a 1° idade pelo array e exibir
                Console.WriteLine("");//espaçamento
            }

            Console.WriteLine("---Fim do Cadastro---");//exibição da mensagem
            
        }
    }
}
