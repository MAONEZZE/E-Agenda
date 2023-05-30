using static e_Agenda.WinApp.ModuloTarefa.Tarefa;

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

                switch (value.prioridade)
                {
                    case PrioridadeTarefa.Alta:
                        rb_alta.Checked = true;
                        break;

                    case PrioridadeTarefa.Media:
                        rb_media.Checked = true;
                        break;

                    case PrioridadeTarefa.Baixa:
                        rb_baixa.Checked = true;
                        break;
                }
            }
            get
            {
                return tarefa;
            }
        }

        
        private void btn_gravar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm tlPrinc = TelaPrincipalForm.TelaPrincipal;
            string titulo = txb_titulo.Text;
            DateTime dataTarefa = txb_data.Value;
            PrioridadeTarefa prioridade = PrioridadeTarefa.Nenhum;

            if (rb_alta.Checked)
            {
                prioridade = PrioridadeTarefa.Alta;
            }
            else if (rb_media.Checked)
            {
                prioridade = PrioridadeTarefa.Media;
            }
            else if (rb_baixa.Checked)
            {
                prioridade = PrioridadeTarefa.Baixa;
            }

            tarefa = new Tarefa(titulo, prioridade, dataTarefa);

            string[] erros = tarefa.Validar();

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


    }
}
