using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private RepositorioBase<Tarefa> repBase;
        private Tarefa tarefa;
        public TelaTarefaForm()
        {
            InitializeComponent();

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
            string prioridade;

            if (rb_alta.Checked)
            {
                prioridade = "Alta";
            }
            else if (rb_media.Checked)
            {
                prioridade = "Média";
            }
            else
            {
                prioridade = "Baixa";
            }

            tarefa = new Tarefa(titulo, prioridade);

            if (txb_id.Text != "0")
            {
                tarefa.id = Convert.ToInt32(txb_id.Text);
            }

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
