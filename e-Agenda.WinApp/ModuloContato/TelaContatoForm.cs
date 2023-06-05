using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form //View
    {
        private Contato contato;

        public TelaContatoForm()
        {
            InitializeComponent();

            this.ConfigurarTelas();
        }

        public Contato Contato
        {
            set
            {
                txb_id.Text = value.id.ToString();
                txb_nome.Text = value.nome;
                txb_telefone.Text = value.telefone;
                txb_email.Text = value.email;
                txb_cargo.Text = value.cargo;
                txb_empresa.Text = value.empresa;
            }
            get
            {
                return contato;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm tlPrinc = TelaPrincipalForm.TelaPrincipal;
            string nome = txb_nome.Text;
            string telefone = txb_telefone.Text;
            string email = txb_email.Text;
            string cargo = txb_cargo.Text;
            string empresa = txb_empresa.Text;
            contato = new Contato(nome, telefone, email, cargo, empresa);

            if (txb_id.Text != "0")
            {
                contato.id = Convert.ToInt32(txb_id.Text);
            }

            string[] erros = contato.Validar();

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
