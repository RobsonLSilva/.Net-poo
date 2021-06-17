using System;

namespace Dio.Series
{
    public class Principal
    {
        Controller control = new Controller();
        public Principal(){
            string opcao = ObterOpcaoUsuario();
            string opcaoUsuario = string.Empty;

            while(opcao.ToUpper() != "X")
            {
                switch(opcao)
                {
                    case "1": //Series
                        opcaoUsuario = ObterOpcaoSeries();
                        while(opcaoUsuario.ToUpper() != "X")
                        {
                            switch(opcaoUsuario)
                            {
                                case "1":
                                    control.ListarSeries();
                                    break;
                                case "2":
                                    control.InserirSerie();
                                    break;
                                case "3":
                                    control.AtualizarSerie();
                                    break;
                                case "4":
                                    control.ExcluirSerie();
                                    break;
                                case "5":
                                    control.VisualizarSerie();
                                    break;
                                case "C":
                                    Console.Clear();
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
                            opcaoUsuario = ObterOpcaoSeries();
                            Console.Clear();
                        }
                        break;
                    case "2": //Filme
                        opcaoUsuario = ObterOpcaoFilmes();
                        while(opcaoUsuario.ToUpper() != "X")
                        {
                            switch(opcaoUsuario)
                            {
                                case "1":
                                    control.ListarFilme();
                                    break;
                                case "2":
                                    control.InserirFilme();
                                    break;
                                case "3":
                                    control.AtualizarFilme();
                                    break;
                                case "4":
                                    control.ExcluirFilme();
                                    break;
                                case "5":
                                    control.VisualizarFilme();
                                    break;
                                case "C":
                                    Console.Clear();
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
                            opcaoUsuario = ObterOpcaoFilmes();
                            Console.Clear();
                        }
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();      
         }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries/Filmes a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            
            Console.WriteLine("1 - Séries");
            Console.WriteLine("2 - Filmes");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        private static string ObterOpcaoSeries()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        private static string ObterOpcaoFilmes()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Filmes a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            
            Console.WriteLine("1 - Listar Filmes");
            Console.WriteLine("2 - Inserir novo Filme");
            Console.WriteLine("3 - Atualizar Filme");
            Console.WriteLine("4 - Excluir Filme");
            Console.WriteLine("5 - Visualizar Filme");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}