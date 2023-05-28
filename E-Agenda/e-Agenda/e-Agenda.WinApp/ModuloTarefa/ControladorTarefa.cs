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

        public override string ToolTipInserir => "Inserir nova Tarefa"; 

        public override string ToolTipEditar => "Editar Tarefa existente"; 

        public override string ToolTipExcluir => "Excluir Tarefa existente";    

        public override string ToolTipFiltrar => "Filtrar Tarefas"; 

        public override string ToolTipInserirItens => "Inserir item em uma Tarefa existente";

        public override string ToolTipVisualizarAbertos => "Visualizar tarefas em aberto";

        public override string ToolTipVisualizarConcluidos => "Visualizar tarefas concluidas";

        public override string ToolTipListar => "Listar itens da tarefas";

        public override void Editar()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Edição de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                TelaTarefaForm telaTarefa = new TelaTarefaForm();

                telaTarefa.Tarefa = tarefa;

                DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

                if (opcaoEscolhida == DialogResult.OK)
                {
                    repositorioTarefa.Editar(telaTarefa.Tarefa.id, telaTarefa.Tarefa);

                    CarregarTarefas();
                }
            }
        }

        public override void Excluir()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tarefa {tarefa.titulo}?", "Exclusão de tarefa",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcaoEscolhida == DialogResult.OK)
                {
                    repositorioTarefa.Excluir(tarefa);

                    CarregarTarefas();
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

                CarregarTarefas();
            }
        }

        public override void AddItem()
        {
            Tarefa tarefaSelec = listagemTarefa.ObterTarefaSelecionada();

            if (tarefaSelec == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Edição de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                TelaCadastroItem telaCadItem = new TelaCadastroItem(tarefaSelec);

                DialogResult opcaoEscolhida = telaCadItem.ShowDialog();

                if(opcaoEscolhida == DialogResult.OK)
                {
                    List<ItemTarefa> listaItens = telaCadItem.ObterItensCad();

                    tarefaSelec.AdicionarItens(listaItens.ElementAt<ItemTarefa>(listaItens.Count - 1));

                    repositorioTarefa.Editar(tarefaSelec.id, tarefaSelec);
                    CarregarTarefas();
                }
            }
        }

        public override void Filtrar() //Falta terminar aqui
        {
            TelaTarefaFiltro telaFiltroTarefa = new TelaTarefaFiltro();

            DialogResult opcaoEscolhida = telaFiltroTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                TipoOpcaoFiltragem opFiltragem = telaFiltroTarefa.OpcaoEscolhida();

                switch (opFiltragem)
                {
                    case TipoOpcaoFiltragem.Todas:
                        CarregarTarefas();
                        break;

                    case TipoOpcaoFiltragem.Pendentes:

                        break;

                    case TipoOpcaoFiltragem.Concluidas:

                        break;

                    case TipoOpcaoFiltragem.DataCriacao:

                        break;
                }
            }
        }

        public enum TipoOpcaoFiltragem
        {
            Todas, Pendentes, Concluidas, DataCriacao
        }

        public override UserControl ObterListagem()
        {
            if (listagemTarefa == null)
            {
                listagemTarefa = new ListagemTarefaControl();
            }

            CarregarTarefas();

            return listagemTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        private void CarregarTarefas()
        {
            List<Tarefa> listaTarefas = repositorioTarefa.SelecionarTodos();//esta pegando a lista de Tarefas e jogando para o tarefas

            listagemTarefa.AtualizarRegistros(listaTarefas);
        }
    }
}
