namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private string prioridade;
        private Tarefa tarefa;
        public TelaTarefaForm()
        {
            InitializeComponent();

            int contadorId = RepositorioTarefa.contador;
            txb_id.Text = (contadorId + 1).ToString();

        }

        public Tarefa Tarefa
        {
            set
            {
                txb_titulo.Text = value.ToString(); //achar logica para fazer o prioridade
            }
            get
            {
                return tarefa;
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            string titulo = txb_titulo.Text;

            tarefa = new Tarefa(titulo, this.prioridade);
        }

        private void rb_alta_CheckedChanged(object sender, EventArgs e)
        {
            this.prioridade = "Alta";
        }

        private void rb_media_CheckedChanged(object sender, EventArgs e)
        {
            this.prioridade = "Media";
        }

        private void rb_baixa_CheckedChanged(object sender, EventArgs e)
        {
            this.prioridade = "Baixa";
        }
    }
}
