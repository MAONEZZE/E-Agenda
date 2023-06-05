namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromisso : Form
    {
        public TelaFiltroCompromisso()
        {
            InitializeComponent();

            this.ConfigurarTelas();

            txb_dataFim.Enabled = false;
            txb_dataInicio.Enabled = false;
        }

        public ControladorCompromisso.StatusCompEnum ObterStatus()
        {
            if (rb_compPassados.Checked)
            {
                return ControladorCompromisso.StatusCompEnum.Passados;
            }
            else if (rb_todosComp.Checked)
            {
                return ControladorCompromisso.StatusCompEnum.Todos;
            }
            else
            {
                return ControladorCompromisso.StatusCompEnum.Futuros;
            }
        }

        private void rb_todosComp_CheckedChanged(object sender, EventArgs e)
        {
            txb_dataFim.Enabled = false;
            txb_dataInicio.Enabled = false;
        }

        private void rb_compPassados_CheckedChanged(object sender, EventArgs e)
        {
            txb_dataFim.Enabled = false;
            txb_dataInicio.Enabled = false;
        }

        private void rb_compFuturos_CheckedChanged(object sender, EventArgs e)
        {
            txb_dataFim.Enabled = true;
            txb_dataInicio.Enabled = true;
        }

        public DateTime ObterDataInicio
        {
            get
            {
                return txb_dataInicio.Value;
            }
        }

        public DateTime ObterDataFinal
        {
            get
            {
                return txb_dataFim.Value;
            }
        }
    }
}
