using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Infra.Arquivo.ModuloCompromisso;
using e_Agenda.Infra.Arquivo.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private TabelaCompromissoControl tabelaCompromisso;
        private RepositorioArquivoContato repContato;
        private RepositorioArquivoCompromisso repCompromisso;

        public ControladorCompromisso(RepositorioArquivoContato repContato, RepositorioArquivoCompromisso repCompromisso)
        {
            this.repContato = repContato;
            this.repCompromisso = repCompromisso;
        }

        public override string ToolTipInserir => "Inserir novo Compromisso";

        public override string ToolTipEditar => "Editar Compromisso existente";

        public override string ToolTipExcluir => "Excluir Compromisso existente";

        public override string ToolTipFiltrar => "Filtrar Compromissos";

        public override string ToolTipInserirItens => "Inserir item";

        public override string ToolTipVisualizarAbertos => "Visualizar em abertos";

        public override string ToolTipVisualizarConcluidos => "Visualizar concluidos";

        public override string ToolTipListar => "Listar itens";

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

                repCompromisso.Serializador();
            }
        }

        public override void Editar()
        {
            Compromisso compSelecionado = ObterCompromissoSelecionado();

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

                    repCompromisso.Serializador();
                }
            }
        }

        private Compromisso ObterCompromissoSelecionado()
        {
            int id = tabelaCompromisso.ObterIdSelecionado();

            return repCompromisso.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Compromisso compSelecionado = ObterCompromissoSelecionado();

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

                    repCompromisso.Serializador();
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

                switch (status)
                {
                    case StatusCompEnum.Todos:
                        CarregarCompromisso();
                        break;

                    case StatusCompEnum.Passados:
                        compTemporais = repCompromisso.SelecionarCompPassados(DateTime.Now);
                        CarregarCompromisso(compTemporais);
                        break;

                    case StatusCompEnum.Futuros:
                        compTemporais = repCompromisso.SelecionarCompFuturos(dataInicio, dataFim);
                        CarregarCompromisso(compTemporais);
                        break;
                }
            }

        }

        private void CarregarCompromisso(List<Compromisso> compTemporais)
        {
            tabelaCompromisso.AtualizarRegistros(compTemporais);
        }

        public enum StatusCompEnum
        {
            Todos, Passados, Futuros
        }

        public void CarregarCompromisso()
        {
            List<Compromisso> comp = repCompromisso.SelecionarTodos();//esta pegando a lista de Compromisso e jogando para o contatos

            tabelaCompromisso.AtualizarRegistros(comp);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCompromisso == null)
            {
                tabelaCompromisso = new TabelaCompromissoControl();
            }

            CarregarCompromisso();

            return tabelaCompromisso;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromisso";
        }
    }
}
