using e_Agenda.Dominio.ModuloCategoriaDespesa;
using e_Agenda.Dominio.ModuloDespesas;
using e_Agenda.Infra.Arquivo.ModuloCategoriaDespesa;
using e_Agenda.Infra.Arquivo.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class ControladorDespesa : ControladorBase
    {
        private TabelaDespesaControl tabelaDespesa;
        private RepositorioArquivoDespesa repDespesa;
        private RepositorioArquivoCategoria repCategoria;

        public ControladorDespesa(RepositorioArquivoDespesa repDespesa, RepositorioArquivoCategoria repCategoria)
        {
            this.repDespesa = repDespesa;
            this.repCategoria = repCategoria;
        }

        public override string ToolTipInserir => "Inserir uma nova Despesa";

        public override string ToolTipEditar => "Editar uma Despesa existente";

        public override string ToolTipExcluir => "Excluir uma Despesa existente";

        public override void Editar()
        {
            Despesa despesaSelec = ObterDespesaSelecionado();

            if (despesaSelec == null)
            {
                MessageBox.Show($"Selecione uma Despesa primeiro!", //texto que fica no meio do painel
                    "Edição de Comprmisso", //texto que fica la em cima do painel
                    MessageBoxButtons.OK, //botão do painel
                    MessageBoxIcon.Exclamation);//icone que sera mostrado nesse painel
            }
            else
            {
                List<CategoriaDespesa> listaCategoria = repCategoria.SelecionarTodos();
                TelaDespesaForm telaDespesa = new TelaDespesaForm(listaCategoria);

                telaDespesa.DespesaP = despesaSelec;

                DialogResult opcao = telaDespesa.ShowDialog();

                if (opcao == DialogResult.OK)
                {
                    Despesa despesa = telaDespesa.DespesaP;

                    repDespesa.Editar(despesa.id, despesa);

                    CarregarDespesa();

                    repDespesa.Serializador();
                }
            }
        }

        public override void Excluir()
        {
            Despesa despesaSelec = ObterDespesaSelecionado();

            if (despesaSelec == null)
            {
                MessageBox.Show($"Selecione uma Despesa primeiro!", //texto que fica no meio do painel
                    "Edição de Comprmisso", //texto que fica la em cima do painel
                    MessageBoxButtons.OK, //botão do painel
                    MessageBoxIcon.Exclamation);//icone que sera mostrado nesse painel
            }
            else
            {
                DialogResult opcao = MessageBox.Show($"Deseja excluir a Despesa {despesaSelec.descricao}", //texto que fica no meio do painel
                    "Exclusão de Despesa", //texto que fica la em cima do painel
                    MessageBoxButtons.OKCancel, //botão do painel
                    MessageBoxIcon.Question);//icone que sera mostrado nesse painel

                if (opcao == DialogResult.OK)
                {
                    repDespesa.Excluir(despesaSelec);

                    CarregarDespesa();

                    repDespesa.Serializador();
                }
            }
        }

        private Despesa ObterDespesaSelecionado()
        {
            int id = tabelaDespesa.ObterIdSelecionado();

            return repDespesa.SelecionarPorId(id);
        }

        public override void Inserir()
        {
            List<CategoriaDespesa> listaCategoria = repCategoria.SelecionarTodos();
            TelaDespesaForm telaDespesa = new TelaDespesaForm(listaCategoria);

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesa = telaDespesa.DespesaP;

                repDespesa.Inserir(despesa);

                MessageBox.Show("Despesa gravado com Sucesso!");

                CarregarDespesa();

                repDespesa.Serializador();
            }
        }

        private void CarregarDespesa()
        {
            List<Despesa> listaDespesa = repDespesa.SelecionarTodos();//esta pegando a lista de Compromisso e jogando para o contatos

            tabelaDespesa.AtualizarRegistros(listaDespesa);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaDespesa == null)
            {
                tabelaDespesa = new TabelaDespesaControl();
            }

            CarregarDespesa();

            return tabelaDespesa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Despesas";
        }
    }
}
