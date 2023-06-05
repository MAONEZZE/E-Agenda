using e_Agenda.Dominio.ModuloCategoriaDespesa;

namespace e_Agenda.WinApp.ModuloCategoriaDespesa
{
    public partial class TabelaCategoriaControl : UserControl
    {
        
        public TabelaCategoriaControl()
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

            DataGridViewTextBoxColumn titulo = new DataGridViewTextBoxColumn();
            titulo.Name = "Título";
            titulo.HeaderText = "Título";

            grid.Columns.AddRange(id);
            grid.Columns.AddRange(titulo);
        }


        public void AtualizarRegistros(List<CategoriaDespesa> listaCategoria)
        {
            grid.Rows.Clear();

            foreach (CategoriaDespesa cat in listaCategoria)
            {
                grid.Rows.Add(cat.id, cat.titulo);
            }
        }

        public int ObterIdSelecionado()
        {
            return Convert.ToInt32(grid.SelectedRows[0].Cells[0].Value);
        }
    }
}
