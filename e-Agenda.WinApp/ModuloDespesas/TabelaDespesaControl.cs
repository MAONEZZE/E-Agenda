using e_Agenda.Dominio.ModuloDespesas;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public partial class TabelaDespesaControl : UserControl
    {
        public TabelaDespesaControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGrid();

            grid.ConfigGridSoLeitura();
        }

        private void ConfigurarColunas()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "ID";
            id.HeaderText = "ID";

            DataGridViewTextBoxColumn descricao = new DataGridViewTextBoxColumn();
            descricao.Name = "Descricao";
            descricao.HeaderText = "Descricao";

            DataGridViewTextBoxColumn valor = new DataGridViewTextBoxColumn();
            valor.Name = "Valor";
            valor.HeaderText = "Valor";

            DataGridViewTextBoxColumn data = new DataGridViewTextBoxColumn();
            data.Name = "Data de Criação";
            data.HeaderText = "Data de Criação";

            DataGridViewTextBoxColumn pagamento = new DataGridViewTextBoxColumn();
            pagamento.Name = "Pagamento";
            pagamento.HeaderText = "Pagamento";

            grid.Columns.AddRange(id);
            grid.Columns.AddRange(descricao);
            grid.Columns.AddRange(data);
            grid.Columns.AddRange(valor);
            grid.Columns.AddRange(pagamento);
        }

        public void AtualizarRegistros(List<Despesa> listaDespesa)
        {
            grid.Rows.Clear();

            foreach (Despesa desp in listaDespesa)
            {
                grid.Rows.Add(desp.id, desp.descricao, desp.data, desp.valor, desp.pagamento);
            }
        }

        public int ObterIdSelecionado()
        {
            return Convert.ToInt32(grid.SelectedRows[0].Cells[0].Value);
        }
    }
}
