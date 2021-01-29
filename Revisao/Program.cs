using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opcao desejada: ");
            Console.WriteLine("1 - Insira um novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            while (opcaoUsuario.ToUpper() != "X") 
            {
                switch (opcaoUsuario)
                {
                    // Adicionar aluno
                    case "1":
                        break;

                    // Listar alunos
                    case "2":
                        break;
                        
                    // Calcular media geral
                    case "3":
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                Console.WriteLine("Informe a opcao desejada: ");
                Console.WriteLine("1 - Insira um novo aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Calcular media geral");
                Console.WriteLine("X - Sair");
                Console.WriteLine();

                opcaoUsuario = Console.ReadLine();
            }

        }
    }
}
