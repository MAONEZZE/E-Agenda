using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class ListagemTarefaControl : UserControl
    {
        public ListagemTarefaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            listBox_tarefas.Items.Clear();

            foreach (Tarefa item in tarefas)
            {
                listBox_tarefas.Items.Add(item);
            }
        }

        public Tarefa ObterTarefaSelecionada()
        {
            return (Tarefa)listBox_tarefas.SelectedItem;
        }
    }
}

