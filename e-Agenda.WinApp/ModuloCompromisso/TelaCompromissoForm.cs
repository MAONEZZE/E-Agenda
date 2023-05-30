using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        private List<Contato> listaContato;

        public TelaCompromissoForm(List<Contato> listaContato)
        {
            InitializeComponent();

            this.listaContato = listaContato;

            CarregadorContatos();

            this.ConfigurarTelas();

            txb_online.Enabled = false;
            txb_presencial.Enabled = false;

            cbox_contato.DisplayMember = "nome";
        }

        public Compromisso Compromisso
        {
            set
            {
                txb_id.Text = Convert.ToString(value.id);
                txb_assunto.Text = value.assunto;
                txb_data.Value = value.data;
                txb_horaInicio.Value = DateTime.Now.Date.Add(value.horaInicio);
                txb_horaFinal.Value = DateTime.Now.Date.Add(value.horaFinal);
                cbox_contato.SelectedItem = value.contato;

                if (value.tipoComp == TipoCompromissoEnum.Presencial)
                {
                    rdb_presencial.Checked = true;
                    txb_presencial.Text = value.localP;
                }
                else
                {
                    rdb_online.Checked = true;
                    txb_online.Text = value.localOn;
                }

            }
            get
            {
                return compromisso; //aqui é usado no inserir
            }
        }

        public void CarregadorContatos()
        {
            foreach (Contato cto in this.listaContato)
            {

                cbox_contato.Items.Add(cto);
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm tlPrinc = TelaPrincipalForm.TelaPrincipal;
            string local = null;
            string assunto = txb_assunto.Text;

            DateTime data = txb_data.Value;
            TimeSpan horaInicio = txb_horaInicio.Value.TimeOfDay;
            TimeSpan horaFinal = txb_horaFinal.Value.TimeOfDay;

            TipoCompromissoEnum tipo =
                rdb_online.Checked ? TipoCompromissoEnum.Remoto : TipoCompromissoEnum.Presencial;
            //se rdb_online for marcado, retorna o tipo remoto, caso contrário retorna presencial

            Contato contato = (Contato)cbox_contato.SelectedItem;

            if (rdb_online.Checked)
            {
                local = txb_online.Text;
            }
            else if(rdb_online.Checked)
            {
                local = txb_presencial.Text;
            }

            compromisso = new Compromisso(assunto, data, horaInicio, horaFinal, contato, local, tipo);
            //aqui cria o objeto compromisso que pode ser acessado pela propriedade Compromisso lá em cima

            string[] erros = compromisso.Validar();

            if (erros.Length > 0)
            {
                tlPrinc.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;//tem que setar o dialogresult para none para não fechar a janela
            }
            else
            {
                tlPrinc.AtualizarRodape("");
            }
        }

        private void rdb_presencial_CheckedChanged(object sender, EventArgs e)
        {
            txb_online.Text = "";
            txb_online.Enabled = false;
            txb_presencial.Enabled = true;
        }

        private void rdb_online_CheckedChanged(object sender, EventArgs e)
        {
            txb_presencial.Text = "";
            txb_presencial.Enabled = false;
            txb_online.Enabled = true;
        }
    }
}
