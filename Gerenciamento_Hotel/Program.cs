using System;

namespace Gerenciamento_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção;

            AcessoBD funcionario = new AcessoBD();

            painelDoHotel();



            void painelDoHotel()
            {
                do
                {
                    Console.WriteLine("\n\n---Bem vindo ao hotel - testes---\n\n");

                    Console.WriteLine("|----------------------------------|\n");
                    Console.WriteLine("|             -Painel-             |\n");
                    Console.WriteLine("|----------------------------------|\n");
                    Console.WriteLine("|    1 - Informações do hotel      |\n");
                    Console.WriteLine("|    2 - Verificar quartos         |\n");
                    Console.WriteLine("|    3 - Cadastrar funcionario              |\n");
                    Console.WriteLine("|    4 - Alterar...                |\n");
                    Console.WriteLine("|    5 - Deletar...                |\n");
                    Console.WriteLine("|    0 - Sair...                   |\n");
                    Console.WriteLine("|----------------------------------|\n");
 
                    Console.WriteLine("Digite a opção desejada: \n");
                    opção = int.Parse(Console.ReadLine());

                    if ((opção != 0) && (opção != 1) && (opção != 2) && (opção != 3) && (opção != 4) && (opção != 5))
                    {               
                        Console.WriteLine("ERRO!!! Não é uma das opções disponíveis!!\n-> Digite novamente \n");
                    }
                    if (opção == 1)
                    {
                        informacoesHotel();
                    }
                    if (opção == 2)
                    {
                        verificaQuartos();
                    }
                    if (opção == 3)
                    {
                        cadastrarFuncionario();
                    }
                    if (opção == 4)
                    {
                        altera();
                    }
                    if (opção == 5)
                    {
                        deleta();
                    }
                } while (opção != 0);
            }
 
            void informacoesHotel()
            {

            }
            void verificaQuartos()
            {

            }
            void cadastrarFuncionario()
            {
                string fun_nome, fun_sobrenome, fun_titulo;
                bool resposta;

                Console.WriteLine("\n\n\tCadastro de funcionario\n");
                Console.WriteLine("\nDigite o nome do funcionario: \n");
                fun_nome = Console.ReadLine();
                Console.WriteLine("\n\nDigite o nome do funcionario: \n");
                fun_sobrenome = Console.ReadLine();
                Console.WriteLine("\n\nDigite o nome do funcionario: \n");
                fun_titulo = Console.ReadLine();
                
                resposta = funcionario.inserirFuncionario(fun_nome, fun_sobrenome, fun_titulo);
            
                if (resposta)
                {
                    Console.WriteLine("\n\n - Inserção efetuada com sucesso!!!\n\n");
                }
                else
                {
                    Console.WriteLine("\n\n - Falha na inserção!!!\n\n");
                }
            }
            void altera()
            {

            }
            void deleta()
            {

            }
            Console.ReadKey();
        }
    }
}
