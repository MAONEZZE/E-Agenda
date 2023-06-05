using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl()
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

        public void AtualizarRegistros(List<Tarefa> listaTarefa)
        {
            grid.Rows.Clear();

            foreach (Tarefa taf in listaTarefa)
            {
                grid.Rows.Add(taf.id, taf.titulo, taf.prioridade, taf.QuantItens, taf.data, taf.percConcluido);
            }
        }

        public int ObterIdSelecionado()
        {
            return Convert.ToInt32(grid.SelectedRows[0].Cells[0].Value);
        }
    }
}
