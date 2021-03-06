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
            Console.WriteLine("Obrigado por utilizar nossos servi??os.");
            Console.ReadLine();      
         }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("|=====================================|");
            Console.WriteLine("| DIO S??ries & Filmes a seu dispor!!! |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|      Informe a op????o desejada:      |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("| 1 - S??ries                          |");
            Console.WriteLine("| 2 - Filmes                          |");
            Console.WriteLine("| C - Limpar Tela                     |");
            Console.WriteLine("| X - Sair                            |");
            Console.WriteLine("|=====================================|");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        private static string ObterOpcaoSeries()
        {
            Console.WriteLine();
            Console.WriteLine("|=====================================|");
            Console.WriteLine("|               S??ries                |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|      Informe a op????o desejada:      |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("| 1 - Listar s??ries                   |");
            Console.WriteLine("| 2 - Inserir nova s??rie              |");
            Console.WriteLine("| 3 - Atualizar s??rie                 |");
            Console.WriteLine("| 4 - Excluir s??rie                   |");
            Console.WriteLine("| 5 - Visualizar s??rie                |");
            Console.WriteLine("| C - Limpar Tela                     |");
            Console.WriteLine("| X - Sair                            |");
            Console.WriteLine("|=====================================|");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        private static string ObterOpcaoFilmes()
        {
            Console.WriteLine();
            Console.WriteLine("|=====================================|");
            Console.WriteLine("|               Filmes                |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|      Informe a op????o desejada:      |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("| 1 - Listar filmes                   |");
            Console.WriteLine("| 2 - Inserir novo filme              |");
            Console.WriteLine("| 3 - Atualizar filme                 |");
            Console.WriteLine("| 4 - Excluir filme                   |");
            Console.WriteLine("| 5 - Visualizar filme                |");
            Console.WriteLine("| C - Limpar Tela                     |");
            Console.WriteLine("| X - Sair                            |");
            Console.WriteLine("|=====================================|");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}