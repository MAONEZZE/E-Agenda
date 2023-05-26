using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa>//Model, Entidade
    {
        public string titulo;
        public string prioridade;

        public Tarefa(string titulo, string prioridade)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
        }

        public override void AtualizarInformacoes(Tarefa registrosAtualizados)
        {
            this.titulo = registrosAtualizados.titulo;
            this.prioridade = registrosAtualizados.prioridade;
        }

        public override string ToString()
        {
            return "Id: " + id + ", " + titulo + ", Prioridade: " + prioridade;
        }

        public override string[] Validar()
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
            {
                listaErros.Add("O campo do titulo é obrigatorio!");
            }
            else if (string.IsNullOrEmpty(prioridade))
            {
                listaErros.Add("Os botões de prioridades são obrigatorios!");
            }

            return listaErros.ToArray();
        }
    }
}
