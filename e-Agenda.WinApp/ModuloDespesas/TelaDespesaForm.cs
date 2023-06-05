

using e_Agenda.Dominio.ModuloCategoriaDespesa;
using e_Agenda.Dominio.ModuloDespesas;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public partial class TelaDespesaForm : Form
    {
        private Despesa despesa;
        public TelaDespesaForm(List<CategoriaDespesa> listaCategoria)
        {
            InitializeComponent();

            this.ConfigurarTelas();
            CarregarCategorias(listaCategoria);
        }

        public Despesa DespesaP
        {
            set
            {
                txb_id.Text = value.id.ToString();
                txb_descricao.Text = value.descricao;
                txb_valor.Text = value.valor.ToString();

                switch (value.pagamento)
                {
                    case Despesa.FormaPagamentoEnum.CartaoCredito:
                        rdb_ctCredito.Checked = true;
                        break;

                    case Despesa.FormaPagamentoEnum.CartaoDebito:
                        rdb_ctDebito.Checked = true;
                        break;

                    case Despesa.FormaPagamentoEnum.Dinheiro:
                        rdb_dinheiro.Checked = true;
                        break;

                    case Despesa.FormaPagamentoEnum.Pix:
                        rdb_pix.Checked = true;
                        break;
                }
            }
            get
            {
                return despesa;
            }
        }

        private void CarregarCategorias(List<CategoriaDespesa> listaCategoria)
        {
            foreach (CategoriaDespesa cat in listaCategoria)
            {
                checkList_categoria.Items.Add(cat);
            }
        }
        

        private void btnGravar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm tlPrinc = TelaPrincipalForm.TelaPrincipal;

            try
            {
                string descricao = txb_descricao.Text;

                DateTime data = txb_data.Value;

                decimal valor = Convert.ToDecimal(txb_valor.Text);

                List<CategoriaDespesa> listaCategoria = ObterCategoriaSelecionada();

                Despesa.FormaPagamentoEnum pagamento = Despesa.FormaPagamentoEnum.Nenhum;

                if (rdb_ctCredito.Checked)
                {
                    pagamento = Despesa.FormaPagamentoEnum.CartaoCredito;
                }
                else if (rdb_ctDebito.Checked)
                {
                    pagamento = Despesa.FormaPagamentoEnum.CartaoDebito;
                }
                else if (rdb_dinheiro.Checked)
                {
                    pagamento = Despesa.FormaPagamentoEnum.Dinheiro;
                }
                else if (rdb_pix.Checked)
                {
                    pagamento = Despesa.FormaPagamentoEnum.Pix;
                }


                despesa = new Despesa(data, descricao, valor, pagamento, listaCategoria);

                string[] erros = despesa.Validar();

                if (erros.Length > 0)
                {
                    tlPrinc.AtualizarRodape(erros[0]);
                    DialogResult = DialogResult.None;
                }
                else
                {
                    tlPrinc.AtualizarRodape("");
                }
            }
            catch (FormatException ex) 
            {
                tlPrinc.AtualizarRodape("Digite um número válido para o campo Valor");
                DialogResult = DialogResult.None;
            }
        }

        private List<CategoriaDespesa> ObterCategoriaSelecionada()
        {
            return checkList_categoria.CheckedItems.Cast<CategoriaDespesa>().ToList();
        }
    }
}
