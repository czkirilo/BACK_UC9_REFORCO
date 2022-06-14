using System;

namespace BACK_UC9_REFORCO
{
    class Program{
        static void Main(string[] args)
        {
            // Endereco end = new Endereco();
            // end.logradouro = "Rua X";
            // end.Numero = 100;
            // end.complemento = "Proximo ao senai";
            // end.enderecoComercial = true;


            // PessoaFisica novapf = new PessoaFisica();
            // novapf.endereco = end;
            // novapf.cpf = "12345";
            // novapf.dataNascimento = new DateTime (1994, 05, 19);
            // novapf.nome = "Caique";

            // Console.WriteLine(novapf.endereco.logradouro);
            // Console.WriteLine(novapf.nome);

      string? opcao;
      do
      {
        Console.WriteLine(@$"
      ****************************************************************
      *               Escolha uma das opções abaixo                  *
      ****************************************************************
      *                     PESSOA FÍSICA                            *
      *               1 - Cadastrar Pessoa Física                    *
      *               2 - Listar Pessoa Físisca                      *
      *               0 - Sair                                       *
      ****************************************************************
      ");
        opcao = Console.ReadLine();
        switch (opcao)
        {
          case "1":
            Endereco endPf = new Endereco();
            Console.WriteLine($"Digite seu Logradouro");                
            endPf.logradouro = Console.ReadLine();
            Console.WriteLine($"Digite o Numero");
            endPf.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o Complemento (Pressione ENTER para vazio)");
            endPf.complemento = Console.ReadLine();
            Console.WriteLine($"Este endereço é comercial? S/N");
            string enderecoComercial = Console.ReadLine().ToUpper();

            if (enderecoComercial == "S" )
            {
              endPf.enderecoComercial = true;
            }
            else{
              endPf.enderecoComercial = false;
            }

            PessoaFisica novapf = new PessoaFisica();
            novapf.endereco = endPf;

            Console.WriteLine($"Digite seu CPF (somente números)");
            novapf.cpf = Console.ReadLine();

            Console.WriteLine($"Digite seu Nome");
            novapf.nome = Console.ReadLine();


            Console.WriteLine($"Digite sua data de nascimento [AAAA,MM,DD");
            novapf.dataNascimento = DateTime.Parse(Console.ReadLine());     

           StreamWriter sw = new StreamWriter($"{novapf.nome}.txt");
           sw.Write($"{novapf.nome},{novapf.cpf}, {novapf.dataNascimento}, {novapf.endereco.logradouro}, {novapf.endereco.Numero} ");
           sw.Close();
            break;

          case "2":
                using(StreamReader sr = new StreamReader("Caique.txt")){
                    string linha;
                    while ((linha = sr.ReadLine()) !=null)
                    {
                       Console.WriteLine($"{linha}");
                    }
                }
                 Console.WriteLine("Aperte Enter para continuar");
                        Console.ReadLine();

            break;

          case "0":
            Console.WriteLine(@$"
      ****************************************************************
      *           Obrigado por utilizar o nosso sistema! S2          *
      ****************************************************************
      ");
            break;

          default:
            Console.WriteLine("Opção invaida, digite uma opção valida");
            break;
        }

      } while (opcao != "0");




        }
    }
}