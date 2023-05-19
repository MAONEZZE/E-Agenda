using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        //Além da prioridade, uma tarefa deve conter: o título, a data de criação, data de
        //conclusão e o percentual concluído.

        private RepositorioTarefa repositorioTarefa;
        private ListagemTarefaControl listagemTarefa;

        public ControladorTarefa(RepositorioTarefa repositorioContato)
        {
            this.repositorioTarefa = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar Tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa existente"; } }

        public override void Editar()
        {
            Tarefa tarefa = listagemTarefa.ObterContatoSelecionado();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Edição de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            else
            {
                TelaTarefaForm telaTarefa = new TelaTarefaForm();
                telaTarefa.Tarefa = tarefa;

                DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

                if (opcaoEscolhida == DialogResult.OK)
                {
                    repositorioTarefa.Editar(telaTarefa.Tarefa);

                    CarregarContatos();
                }
            }
        }

        private void CarregarContatos()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();//esta pegando a lista de Contatos e jogando para o contatos

            listagemTarefa.AtualizarRegistros(tarefas);
        }

        public override void Excluir()
        {
            Tarefa tarefa = listagemTarefa.ObterContatoSelecionado();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            else
            {
                DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tarefa {tarefa.titulo}?", "Exclusão de tarefa",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcaoEscolhida == DialogResult.OK)
                {
                    repositorioTarefa.Excluir(tarefa);

                    CarregarContatos();
                }
            }
        }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.Tarefa;
                repositorioTarefa.Inserir(tarefa);

                CarregarContatos();
            }
        }

        public override UserControl ObterListagem()
        {
            if (listagemTarefa == null)
                listagemTarefa = new ListagemTarefaControl();

            CarregarContatos();

            return listagemTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }
    }
}
