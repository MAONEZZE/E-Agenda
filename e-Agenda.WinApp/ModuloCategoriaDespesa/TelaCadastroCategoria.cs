using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
