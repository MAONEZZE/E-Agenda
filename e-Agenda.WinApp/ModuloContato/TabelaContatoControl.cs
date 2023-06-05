using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl()
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

            DataGridViewTextBoxColumn nome = new DataGridViewTextBoxColumn();
            nome.Name = "nome";
            nome.HeaderText = "Nome";

            DataGridViewTextBoxColumn telefone = new DataGridViewTextBoxColumn();
            telefone.Name = "telefone";
            telefone.HeaderText = "Telefone";

            DataGridViewTextBoxColumn empresa = new DataGridViewTextBoxColumn();
            empresa.Name = "empresa";
            empresa.HeaderText = "Empresa";

            grid.Columns.AddRange(id);
            grid.Columns.AddRange(nome);
            grid.Columns.AddRange(telefone);
            grid.Columns.AddRange(empresa);
        }

        public void AtualizarRegistros(List<Contato> listaContato)
        {
            grid.Rows.Clear();

            foreach (Contato cont in listaContato)
            {
                grid.Rows.Add(cont.id, cont.nome, cont.telefone, cont.empresa);
            }
        }

        public int ObterIdSelecionado()
        {
            return Convert.ToInt32(grid.SelectedRows[0].Cells[0].Value);
        }
    }
}
