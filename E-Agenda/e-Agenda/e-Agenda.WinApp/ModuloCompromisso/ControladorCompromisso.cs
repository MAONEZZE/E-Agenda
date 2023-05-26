using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private ListagemCompromissoControl listagemCompromisso;
        private RepositorioContato repContato;
        private RepositorioCompromisso repCompromisso;

        public ControladorCompromisso(RepositorioContato repContato, RepositorioCompromisso repCompromisso)
        {
            this.repContato = repContato;
            this.repCompromisso = repCompromisso;
        }

        public override string ToolTipInserir => "Inserir novo Compromisso";

        public override string ToolTipEditar => "Editar Compromisso existente";

        public override string ToolTipExcluir => "Excluir Compromisso existente";

        public override string ToolTipFiltrar => "Filtrar Compromissos";

        public override string ToolTipInserirItens => "Inserir item em uma Tarefa existente";

        public override string ToolTipVisualizarAbertos => "Visualizar tarefas em aberto";

        public override string ToolTipVisualizarConcluidos => "Visualizar tarefas concluidas";

        public override string ToolTipListar => "Listar itens da tarefas";

        public override void Inserir()
        {
            List<Contato> listaContatos = repContato.SelecionarTodos();
            TelaCompromissoForm telaComp = new TelaCompromissoForm(listaContatos);

            DialogResult opcao = telaComp.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                Compromisso comp = telaComp.Compromisso;

                repCompromisso.Inserir(comp);

                MessageBox.Show("Compromisso Gravado com sucesso!");

                CarregarCompromisso();
            }
        }

        public override void Editar()
        {
            Compromisso compSelecionado = listagemCompromisso.ObterCompromissoSelecionado();

            if (compSelecionado == null)
            {
                MessageBox.Show($"Selecione um Compromisso primeiro!", //texto que fica no meio do painel
                    "Edição de Comprmisso", //texto que fica la em cima do painel
                    MessageBoxButtons.OK, //botão do painel
                    MessageBoxIcon.Exclamation);//icone que sera mostrado nesse painel
            }
            else
            {
                List<Contato> listaContatos = repContato.SelecionarTodos();
                TelaCompromissoForm telaComp = new TelaCompromissoForm(listaContatos);

                //telaComp.CarregadorContatos();

                telaComp.Compromisso = compSelecionado;
                
                DialogResult opcao = telaComp.ShowDialog();

                if (opcao == DialogResult.OK)
                {
                    Compromisso comp = telaComp.Compromisso;

                    repCompromisso.Editar(comp.id, comp);

                    CarregarCompromisso();
                }
            }
        }

        public override void Excluir()
        {
            Compromisso compSelecionado = listagemCompromisso.ObterCompromissoSelecionado();

            if (compSelecionado == null)
            {
                MessageBox.Show($"Selecione um Compromisso primeiro!", //texto que fica no meio do painel
                    "Edição de Comprmisso", //texto que fica la em cima do painel
                    MessageBoxButtons.OK, //botão do painel
                    MessageBoxIcon.Exclamation);//icone que sera mostrado nesse painel
            }
            else
            {
                DialogResult opcao = MessageBox.Show($"Deseja excluir o compromisso {compSelecionado.assunto}", //texto que fica no meio do painel
                    "Exclusão de Comprmisso", //texto que fica la em cima do painel
                    MessageBoxButtons.OKCancel, //botão do painel
                    MessageBoxIcon.Question);//icone que sera mostrado nesse painel

                if (opcao == DialogResult.OK)
                {

                    repCompromisso.Excluir(compSelecionado);

                    CarregarCompromisso();
                }
            }
        }

        public override void Filtrar()
        {
            TelaFiltroCompromisso telaFiltroComp = new TelaFiltroCompromisso();

            DialogResult opcao = telaFiltroComp.ShowDialog();

            if(opcao == DialogResult.OK)
            {
                List<Compromisso> compTemporais;

                StatusCompEnum status = telaFiltroComp.ObterStatus();

                DateTime dataInicio = telaFiltroComp.ObterDataInicio;
                DateTime dataFim = telaFiltroComp.ObterDataFinal;

                if(status == StatusCompEnum.Todos)
                {
                    CarregarCompromisso();
                }
                else if(status == StatusCompEnum.Passados)
                {
                    compTemporais = repCompromisso.SelecionarCompPassados(DateTime.Now);

                    CarregarCompromisso(compTemporais);
                }
                else if(status == StatusCompEnum.Futuros)
                {
                    compTemporais = repCompromisso.SelecionarCompFuturos(dataInicio, dataFim);

                    CarregarCompromisso(compTemporais);
                }
            }

        }

        private void CarregarCompromisso(List<Compromisso> compTemporais)
        {
            listagemCompromisso.AtualizarRegistros(compTemporais);
        }

        public enum StatusCompEnum
        {
            Todos, Passados, Futuros
        }

        public void CarregarCompromisso()
        {
            List<Compromisso> comp = repCompromisso.SelecionarTodos();//esta pegando a lista de Compromisso e jogando para o contatos

            listagemCompromisso.AtualizarRegistros(comp);
        }

        public override UserControl ObterListagem()
        {
            if (listagemCompromisso == null)
                listagemCompromisso = new ListagemCompromissoControl();

            CarregarCompromisso();

            return listagemCompromisso;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromisso";
        }
    }
}
