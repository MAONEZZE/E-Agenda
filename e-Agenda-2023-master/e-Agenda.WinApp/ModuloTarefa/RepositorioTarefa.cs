namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        public static int contador;

        public void Inserir(Tarefa tarefa)
        {
            contador++;
            tarefa.id = contador;
            tarefas.Add(tarefa);
        }

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }

        public void Editar(Tarefa tarefa)
        {
            Tarefa tarefaSelecionada = SelecionarPorId(tarefa.id);

            tarefaSelecionada.prioridade = tarefa.prioridade;
            tarefaSelecionada.titulo = tarefa.titulo;
        }

        private Tarefa SelecionarPorId(int id)
        {
            return tarefas.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }
    }
}
