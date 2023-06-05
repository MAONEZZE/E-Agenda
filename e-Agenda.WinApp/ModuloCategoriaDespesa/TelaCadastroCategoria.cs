using e_Agenda.Dominio.ModuloCategoriaDespesa;

namespace e_Agenda.WinApp.ModuloCategoriaDespesa
{
    public partial class TelaCadastroCategoria : Form
    {
        private CategoriaDespesa categoria;

        public TelaCadastroCategoria()
        {
            InitializeComponent();

            this.ConfigurarTelas();
        }

        public CategoriaDespesa Categoria
        {
            set
            {
                txb_id.Text = value.id.ToString();
                txb_titulo.Text = value.titulo;
            }
            get
            {
                return categoria;
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm tlPrinc = TelaPrincipalForm.TelaPrincipal;
            
            string titulo = txb_titulo.Text;

            categoria = new CategoriaDespesa(titulo);

            string[] erros = categoria.Validar();

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
