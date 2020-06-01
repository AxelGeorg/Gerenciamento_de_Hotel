using System;

namespace Gerenciamento_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, opcao_painel;

            funcionarioDAO funcionario = new funcionarioDAO();

            painel();







    



            void painel()
            {
                do
                {

                    Console.WriteLine("\n\n----- Bem vindo ao hotel -----\n\n");

                    Console.WriteLine("|----------------------------------|\n");
                    Console.WriteLine("|             -Painel-             |\n");
                    Console.WriteLine("|----------------------------------|\n");
                    Console.WriteLine("|    1 - Login                     |\n");
                    Console.WriteLine("|    2 - Informações do hotel      |\n");
                    Console.WriteLine("|    0 - Sair...                   |\n");
                    Console.WriteLine("|----------------------------------|\n");
 
                    Console.WriteLine(" - Digite a opção desejada: \n");
                    opcao_painel = int.Parse(Console.ReadLine());

                    if ((opcao != 0) && (opcao != 1) && (opcao != 2))
                    {               
                        Console.WriteLine("ERRO!!! Não é uma das opções disponíveis!!\n-> Digite novamente \n");
                    }
                    if (opcao == 1)
                    {
                        informacoesHotel();
                    }
                    if (opcao == 2)
                    {
                        verificaQuartos();
                    }

                }while(opcao_painel != 0);
            }










            void painelDoHotel()
            {
                do
                {

                    Console.WriteLine("\n\n----- Bem vindo ao hotel -----\n\n");

                    Console.WriteLine("|----------------------------------|\n");
                    Console.WriteLine("|             -Painel-             |\n");
                    Console.WriteLine("|----------------------------------|\n");
                    Console.WriteLine("|    1 - Informações do hotel      |\n");
                    Console.WriteLine("|    2 - Verificar quartos         |\n");
                    Console.WriteLine("|    3 - Funcionários              |\n");
                    Console.WriteLine("|    4 - Alterar...                |\n");
                    Console.WriteLine("|    5 - Deletar...                |\n");
                    Console.WriteLine("|    0 - Sair...                   |\n");
                    Console.WriteLine("|----------------------------------|\n");
 
                    Console.WriteLine("Digite a opção desejada: \n");
                    opcao = int.Parse(Console.ReadLine());

                    if ((opcao != 0) && (opcao != 1) && (opcao != 2) && (opcao != 3) && (opcao != 4) && (opcao != 5))
                    {               
                        Console.WriteLine("ERRO!!! Não é uma das opções disponíveis!!\n-> Digite novamente \n");
                    }
                    if (opcao == 1)
                    {
                        informacoesHotel();
                    }
                    if (opcao == 2)
                    {
                        verificaQuartos();
                    }
                    if (opcao == 3)
                    {
                        funcionarios();
                    }
                    if (opcao == 4)
                    {
                        altera();
                    }
                    if (opcao == 5)
                    {
                        deleta();
                    }
                } while (opcao != 0);
                //thread
            }
 
            void informacoesHotel()
            {

            }
            void verificaQuartos()
            {

            }
            void funcionarios()
            {
                int opcao_fun,fun_id;
                string fun_nome, fun_nomeNovo, fun_sobrenome, fun_sobrenomeNovo, fun_titulo , fun_tituloNovo;
                bool resposta;

                do
                {
                    Console.WriteLine("\n\n|----------------------------------|\n");
                    Console.WriteLine("|           -Funcionários-         |\n");
                    Console.WriteLine("|----------------------------------|\n");
                    Console.WriteLine("|    1 - Listar                    |\n");
                    Console.WriteLine("|    2 - Cadastrar                 |\n");
                    Console.WriteLine("|    3 - Alterar                   |\n");
                    Console.WriteLine("|    4 - Deletar                   |\n");
                    Console.WriteLine("|    0 - Voltar                    |\n");
                    Console.WriteLine("|----------------------------------|\n");
                    Console.WriteLine("Digite a opção desejada: \n");
                    opcao_fun = int.Parse(Console.ReadLine());


                    if ((opcao_fun != 0) && (opcao_fun != 1) && (opcao_fun != 2) && (opcao_fun != 3) && (opcao_fun != 4))
                    {
                        Console.WriteLine("ERRO!!! Não é uma das opções disponíveis!!\n-> Digite novamente \n");
                    }

                    if (opcao_fun == 1)
                    {
                        Console.WriteLine("\n\n----Lista de funcionarios -----\n");
                        
                    }

                    if (opcao_fun == 2)
                    {
                        Console.WriteLine("\n\n\tCadastro de funcionario\n");
                        Console.WriteLine("\nDigite o nome do funcionario: \n");
                        fun_nome = Console.ReadLine();
                        Console.WriteLine("\n\nDigite o sobrenome do funcionario: \n");
                        fun_sobrenome = Console.ReadLine();
                        Console.WriteLine("\n\nDigite o título do funcionario: \n");
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

                    if (opcao_fun == 3)
                    {
                        int op;
                        do
                        {
                            Console.WriteLine("\n\n\tAlteração de funcionario\n");
                            Console.WriteLine("\n - Deseja alterar quais dados:\n" +
                                "   1 - Nome\n" +
                                "   2 - Sobrenome\n" +
                                "   3 - Título\n" +
                                "   4 - Todos os itens acima\n" +
                                "   0 - Voltar\n\n");
                            op = int.Parse(Console.ReadLine());

                            if ((op != 0) && (op != 1) && (op != 2) && (op != 3) && (op != 4))
                            {
                                Console.WriteLine("\nERRO!!! Não é uma das opções disponíveis!!\n-> Digite novamente \n\n\n");
                            }

                            if (op == 1)
                            {
                                Console.WriteLine("\nDigite o id do funcionario: \n");
                                fun_id = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n\nDigite o novo nome do funcionario: \n");
                                fun_nomeNovo = Console.ReadLine();

                                resposta = funcionario.alterarNomeFuncionario(fun_id, fun_nomeNovo);

                                if (resposta)
                                {
                                    Console.WriteLine("\n\n - Alteração efetuada com sucesso!!!\n\n");
                                }
                                else
                                {
                                    Console.WriteLine("\n\n - Falha na alteração!!!\n\n");
                                }
                            }

                            if (op == 2)
                            {
                                Console.WriteLine("\nDigite o id do funcionario: \n");
                                fun_id = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n\nDigite o novo sobrenome do funcionario: \n");
                                fun_sobrenomeNovo = Console.ReadLine();

                                resposta = funcionario.alterarSobrenomeFuncionario(fun_id, fun_sobrenomeNovo);

                                if (resposta)
                                {
                                    Console.WriteLine("\n\n - Alteração efetuada com sucesso!!!\n\n");
                                }
                                else
                                {
                                    Console.WriteLine("\n\n - Falha na alteração!!!\n\n");
                                }
                            }

                            if (op == 3)
                            {
                                Console.WriteLine("\nDigite o id do funcionario: \n");
                                fun_id = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n\nDigite o novo titulo do funcionario: \n");
                                fun_tituloNovo = Console.ReadLine();

                                resposta = funcionario.alterarTituloFuncionario(fun_id, fun_tituloNovo);

                                if (resposta)
                                {
                                    Console.WriteLine("\n\n - Alteração efetuada com sucesso!!!\n\n");
                                }
                                else
                                {
                                    Console.WriteLine("\n\n - Falha na alteração!!!\n\n");
                                }
                            }

                            if (op == 4)
                            {
                                Console.WriteLine("\nDigite o id do funcionario: \n");
                                fun_id = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n\nDigite o novo nome do funcionario: \n");
                                fun_nomeNovo = Console.ReadLine();
                                Console.WriteLine("\n\nDigite o novo sobrenome do funcionario: \n");
                                fun_sobrenomeNovo = Console.ReadLine();
                                Console.WriteLine("\n\nDigite o novo titulo do funcionario: \n");
                                fun_tituloNovo = Console.ReadLine();

                                resposta = funcionario.alterarTudoFuncionario(fun_id, fun_nomeNovo, fun_sobrenomeNovo, fun_tituloNovo);

                                if (resposta)
                                {
                                    Console.WriteLine("\n\n - Alteração efetuada com sucesso!!!\n\n");
                                }
                                else
                                {
                                    Console.WriteLine("\n\n - Falha na alteração!!!\n\n");
                                }
                            }
                        
                        } while (op != 0);
                    }
                    
                    if (opcao_fun == 4)
                    {
                        Console.WriteLine("\n\n\tExclusão de funcionario\n");
                        Console.WriteLine("\nDigite o id do funcionario: \n");
                        fun_id = int.Parse(Console.ReadLine().Trim());


                        resposta = funcionario.deletarFuncionario(fun_id);

                        if (resposta)
                        {
                            Console.WriteLine("\n\n - Exclusão efetuada com sucesso!!!\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\n - Falha na exclusão!!!\n\n");
                        }
                    }
                } while (opcao_fun != 0);
                //thread
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
