namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;
        public TelaTarefaForm()
        {
            InitializeComponent();

            this.ConfigurarTelas();
        }

        public Tarefa Tarefa
        {
            set
            {
                txb_titulo.Text = value.titulo;
                txb_id.Text = value.id.ToString();

                if (value.prioridade.Equals("Alta"))
                {
                    rb_alta.Checked = true;
                }
                else if (value.prioridade.Equals("Média"))
                {
                    rb_media.Checked = true;
                }
                else if (value.prioridade.Equals("Baixa"))
                {
                    rb_baixa.Checked = true;
                }

            }
            get
            {
                return tarefa;
            }
        }

        
        private void btn_gravar_Click(object sender, EventArgs e)
        {
            string titulo = txb_titulo.Text;
            DateTime dataTarefa = txb_data.Value;
            string prioridade = null;

            if (rb_alta.Checked)
            {
                prioridade = "Alta";
            }
            else if (rb_media.Checked)
            {
                prioridade = "Média";
            }
            else if (rb_baixa.Checked)
            {
                prioridade = "Baixa";
            }

            tarefa = new Tarefa(titulo, prioridade, dataTarefa);

            string[] erros = tarefa.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm tlPrinc = TelaPrincipalForm.TelaPrincipal;
                tlPrinc.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }


    }
}
