using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesas;

namespace e_Agenda.WinApp.ModuloCategoriaDespesa
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

            DataGridViewTextBoxColumn titulo = new DataGridViewTextBoxColumn();
            titulo.Name = "Título";
            titulo.HeaderText = "Título";

            DataGridViewTextBoxColumn prioridade = new DataGridViewTextBoxColumn();
            prioridade.Name = "Prioridade";
            prioridade.HeaderText = "Prioridade";

            DataGridViewTextBoxColumn data = new DataGridViewTextBoxColumn();
            data.Name = "Data de Criação";
            data.HeaderText = "Data de Criação";

            DataGridViewTextBoxColumn percConcluido = new DataGridViewTextBoxColumn();
            percConcluido.Name = "Percentual Concluido";
            percConcluido.HeaderText = "Percentual Concluido";

            DataGridViewTextBoxColumn quantItens = new DataGridViewTextBoxColumn();
            quantItens.Name = "Quantidade de Itens";
            quantItens.HeaderText = "Quantidade de Itens";

            grid.Columns.AddRange(id);
            grid.Columns.AddRange(titulo);
            grid.Columns.AddRange(prioridade);
            grid.Columns.AddRange(quantItens);
            grid.Columns.AddRange(data);
            grid.Columns.AddRange(percConcluido);
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
