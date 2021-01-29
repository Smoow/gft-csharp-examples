using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    // Adicionar aluno
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else 
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;

                    // Listar alunos
                    case "2":
                        foreach (var i in alunos)
                        {
                            if (i.Nome != null)
                            {
                                Console.WriteLine($"Aluno: {i.Nome}, Nota {i.Nota}");
                            }
                        }
                        break;

                    // Calcular media geral
                    case "3":
                        decimal notaTotal = 0;
                        int nrAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++) 
                        {
                            if (alunos[i].Nome != null)
                            {
                                notaTotal += alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        ConceitoEnum conceitoGeral;


                        if (mediaGeral < 2)
                        {
                            conceitoGeral = ConceitoEnum.E;
                        }                        
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral = ConceitoEnum.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = ConceitoEnum.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceitoGeral = ConceitoEnum.B;
                        } 
                        else
                        {
                            conceitoGeral = ConceitoEnum.A;
                        }

                        Console.WriteLine($"Media geral: {mediaGeral} - Conceito: {conceitoGeral}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opcao desejada: ");
            Console.WriteLine("1 - Insira um novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
