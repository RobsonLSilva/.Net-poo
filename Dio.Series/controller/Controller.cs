using System;

namespace Dio.Series
{
    public class Controller
    {
        SerieRepositorio repositorioSerie = new SerieRepositorio();
        FilmeRepositorio repositorioFilme = new FilmeRepositorio();
        // Métodos para Series
        public object Serie(){

             foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} - {1}",i, Enum.GetName(typeof(Genero), i));
            }
            System.Console.WriteLine("Digite o gênero entre as opções a cima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Titulo da série: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano de Início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            object novoObjeto = new Serie(id: repositorioSerie.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            return novoObjeto;
        }
        public void AtualizarSerie()
        {
            Console.WriteLine("Digite o id da série");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorioSerie.Atualiza(indiceSerie, (Serie)Serie());
        }
        public void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");
            repositorioSerie.Insere((Serie)Serie());

        }
        public void ListarSeries()
        {
            Console.WriteLine("Lista séries");

            var lista = repositorioSerie.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach(var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }

        }
        public void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da série");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorioSerie.Excluir(indiceSerie);

        }
        public void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorioSerie.RetornaPorId(indiceSerie);
            Console.WriteLine();
            Console.WriteLine(serie);
        }
        // Métodos para Filmes
        public object Filme(){

             foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} - {1}",i, Enum.GetName(typeof(Genero), i));
            }
            System.Console.WriteLine("Digite o gênero entre as opções a cima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Titulo do filme: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Produtor do filme: ");
            string entradaProdutor = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano de Início do filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a descrição do filme: ");
            string entradaDescricao = Console.ReadLine();

            object novoObjeto = new Filme(id: repositorioFilme.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        produtor: entradaProdutor,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            return novoObjeto;
        }
        public void AtualizarFilme()
        {
            Console.WriteLine("Digite o id do filme");
            int indiceFilme = int.Parse(Console.ReadLine());
            repositorioFilme.Atualiza(indiceFilme, (Filme)Filme());
        }
        public void InserirFilme()
        {
            Console.WriteLine("Inserir novo filme");
            repositorioFilme.Insere((Filme)Filme());

        }
        public void ListarFilme()
        {
            Console.WriteLine("Lista filmes");

            var lista = repositorioFilme.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }

            foreach(var filme in lista)
            {
                var excluido = filme.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} - {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }

        }
        public void ExcluirFilme()
        {
            Console.WriteLine("Digite o id do filme");
            int indiceFilme = int.Parse(Console.ReadLine());

            repositorioFilme.Excluir(indiceFilme);

        }
        public void VisualizarFilme()
        {
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = repositorioFilme.RetornaPorId(indiceFilme);
            Console.WriteLine();
            Console.WriteLine(filme);
        }
    }
}