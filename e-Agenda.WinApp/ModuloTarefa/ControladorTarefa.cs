using e_Agenda.Dominio.ModuloTarefa;
using e_Agenda.Infra.Arquivo.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        //Além da prioridade, uma tarefa deve conter: o título, a data de criação, data de
        //conclusão e o percentual concluído.

        private RepositorioArquivoTarefa repTarefa;
        private RepositorioArquivoItemTarefa repItemTaf;
        private TabelaTarefaControl tabelaTarefas;

        public ControladorTarefa(RepositorioArquivoTarefa repTarefa, RepositorioArquivoItemTarefa repItemTaf)
        {
            this.repTarefa = repTarefa;
            this.repItemTaf = repItemTaf;
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
            Tarefa tarefa = ObterTarefaSelecionada();

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
                    repTarefa.Editar(telaTarefa.Tarefa.id, telaTarefa.Tarefa);

                    CarregarTarefas();

                    repTarefa.Serializador();
                }
            }
        }

        private Tarefa ObterTarefaSelecionada()
        {
            int id = tabelaTarefas.ObterIdSelecionado();

            return repTarefa.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Tarefa tarefa = ObterTarefaSelecionada();

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
                    repTarefa.Excluir(tarefa);

                    CarregarTarefas();

                    repTarefa.Serializador();
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

                repTarefa.Inserir(tarefa);
                
                CarregarTarefas();

                repTarefa.Serializador();
            }
        }

        public override void AddItem()
        {
            Tarefa tarefaSelec = ObterTarefaSelecionada();

            if (tarefaSelec == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Adição de itens a Tarefa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                TelaCadastroItem telaCadItem = new TelaCadastroItem(tarefaSelec);

                DialogResult opcaoEscolhida = telaCadItem.ShowDialog();

                if(opcaoEscolhida == DialogResult.OK)
                {

                    //tarefaSelec.AdicionarItens(telaCadItem.Item);

                    List<ItemTarefa> listaItens = telaCadItem.ObterItensCad();
                    
                    foreach(ItemTarefa item in listaItens)
                    {
                        tarefaSelec.AdicionarItens(item);
                        
                    }

                    //tarefaSelec.AdicionarItens(listaItens.ElementAt<ItemTarefa>(listaItens.Count - 1));

                    repTarefa.Editar(tarefaSelec.id, tarefaSelec);
                    CarregarTarefas();
                    repTarefa.Serializador();
                }
            }
        }

        public override void ItensConcluidos()
        {
            Tarefa tarefaSelec = ObterTarefaSelecionada();

            if (tarefaSelec == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Conclusão de itens a Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                TelaAtualizarItens telaAtualizaItem = new TelaAtualizarItens(tarefaSelec);

                DialogResult opcaoEscolhida = telaAtualizaItem.ShowDialog();

                if (opcaoEscolhida == DialogResult.OK)
                {
                    List<ItemTarefa> listaItensConcluidos = telaAtualizaItem.ObterItensMarcados();
                    List<ItemTarefa> listaItensPendentes = telaAtualizaItem.ObterItensPendentes();

                    foreach (ItemTarefa item in listaItensConcluidos)
                    {
                        tarefaSelec.ConcluirItem(item);
                    }

                    foreach (ItemTarefa item in listaItensPendentes)
                    {
                        tarefaSelec.DesmarcarItem(item);
                    }

                    repTarefa.Editar(tarefaSelec.id, tarefaSelec);
                    CarregarTarefas();
                    repTarefa.Serializador();
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

                List<Tarefa> listaTarefaFiltrada;

                DateTime dataInicio = telaFiltroTarefa.ObterDataInicio;
                DateTime dataFim = telaFiltroTarefa.ObterDataFinal;

                switch (opFiltragem)
                {
                    case TipoOpcaoFiltragem.Todas:
                        listaTarefaFiltrada = repTarefa.SelecionarTodosPorPrioridade();
                        CarregarTarefa(listaTarefaFiltrada);
                        break;

                    case TipoOpcaoFiltragem.Pendentes:
                        listaTarefaFiltrada = repTarefa.SelecionarPendentes();
                        CarregarTarefa(listaTarefaFiltrada);
                        break;

                    case TipoOpcaoFiltragem.Concluidas:
                        listaTarefaFiltrada = repTarefa.SelecionarConcluidas();
                        CarregarTarefa(listaTarefaFiltrada);
                        break;

                    case TipoOpcaoFiltragem.DataCriacao:
                        listaTarefaFiltrada = repTarefa.SelecionarTarefaPorData(dataInicio, dataFim);
                        CarregarTarefa(listaTarefaFiltrada);
                        break;
                }
            }
        }

        private void CarregarTarefa(List<Tarefa> listaTarefaFiltrada)
        {
            tabelaTarefas.AtualizarRegistros(listaTarefaFiltrada);
        }

        public enum TipoOpcaoFiltragem
        {
            Todas, Pendentes, Concluidas, DataCriacao
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTarefas == null)
            {
                tabelaTarefas = new TabelaTarefaControl();
            }

            CarregarTarefas();

            return tabelaTarefas;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        private void CarregarTarefas()
        {
            List<Tarefa> listaTarefas = repTarefa.SelecionarTodos();//esta pegando a lista de Tarefas e jogando para o tarefas

            tabelaTarefas.AtualizarRegistros(listaTarefas);
        }
    }
}
