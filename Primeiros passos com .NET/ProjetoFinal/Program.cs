﻿using System;
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string opcaoUsuario = OpcoesUsuario();
            var indiceAluno = 0;

            while (opcaoUsuario.toUpper() != 'X')
            {
                switch (opcaoUsuario)
                {
                    case 1:
                        Console.WriteLine("Informe o nome do Aluno: ");

                        var aluno = new Aluno();

                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Me informe a nota do Aluno");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {

                            aluno.Nota = nota;

                        }
                        else
                        {
                            throw new ArgumentException("O Valor da nota deve ser Decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case 2:
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");

                            }
                        }

                        break;

                    case 3:
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal += alunos[i].Nota;
                                nrAlunos++;
                            }

                        }

                        var mediaGeral = notaTotal / alunos;
                        Conceito conceitoGeral;

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;

                        }



                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = OpcoesUsuario();

            }
        }
        private static string OpcoesUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno;");
            Console.WriteLine("2 - Listar alunos;");
            Console.WriteLine("3 - Calcular média geral;");
            Console.WriteLine("X - Sair;");

            Console.WriteLine();

            opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;

        }

    }


