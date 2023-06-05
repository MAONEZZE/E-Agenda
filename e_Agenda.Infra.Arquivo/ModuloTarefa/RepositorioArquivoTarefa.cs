using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.Infra.Arquivo.ModuloTarefa
{
    public class RepositorioArquivoTarefa : RepositorioArquivoBase<Tarefa>
    {
        public RepositorioArquivoTarefa()
        {
            listaRegistros = Desserializador();
        }

        public List<Tarefa> SelecionarTarefaPorData(DateTime dataInicio, DateTime dataFim)
        {
            List<Tarefa> listaTarefa = new List<Tarefa>();

            foreach (Tarefa taf in listaRegistros)
            {
                if (taf.data >= dataInicio && taf.data <= dataFim)
                {
                    listaTarefa.Add(taf);
                }
            }

            return listaTarefa;
        }

        public List<Tarefa> SelecionarConcluidas()
        {
            List<Tarefa> listaTarefa = new List<Tarefa>();

            foreach (Tarefa taf in listaRegistros)
            {
                if (taf.percConcluido == 100)
                {
                    listaTarefa.Add(taf);
                }
            }

            return listaTarefa.OrderBy(x => x.prioridade).ToList(); ;
        }

        public List<Tarefa> SelecionarPendentes()
        {
            List<Tarefa> listaTarefa = new List<Tarefa>();

            foreach (Tarefa taf in listaRegistros)
            {
                if (taf.percConcluido != 100)
                {
                    listaTarefa.Add(taf);
                }
            }

            return listaTarefa.OrderBy(x => x.prioridade).ToList(); ;
        }

        public List<Tarefa> SelecionarTodosPorPrioridade()
        {
            return listaRegistros.OrderBy(x => x.prioridade).ToList();
        }
    }
}
