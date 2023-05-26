using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;
using e_Agenda.WinApp.ModuloCompromisso;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioContato repContato = new RepositorioContato(new List<Contato>());
        private RepositorioTarefa repTarefa = new RepositorioTarefa(new List<Tarefa>());
        private RepositorioCompromisso repCompromisso = new RepositorioCompromisso(new List<Compromisso>());
        private static TelaPrincipalForm telaPrincipal;

        public TelaPrincipalForm()
        {
            InitializeComponent();
            telaPrincipal = this;
        }
        public static TelaPrincipalForm TelaPrincipal
        {
            get
            {
                if (telaPrincipal == null)
                {
                    telaPrincipal = new TelaPrincipalForm();
                }

                return telaPrincipal;

            }
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repContato);

            btn_listarItens.Enabled = false;
            btn_filtrarTarefas.Enabled = false;

            btn_filtrarTarefas.Enabled = false;
            btn_listarItens.Enabled = false;
            btn_concluidos.Enabled = false;
            btn_abertos.Enabled = false;
            btn_addItem.Enabled = false;

            ConfigurarTelaPrincipal(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repTarefa);

            btn_listarItens.Enabled = true;
            btn_filtrarTarefas.Enabled = true;

            btn_filtrarTarefas.Enabled = true;
            btn_listarItens.Enabled = true;
            btn_concluidos.Enabled = true;
            btn_abertos.Enabled = true;
            btn_addItem.Enabled = true;

            ConfigurarTelaPrincipal(controlador);
        }
        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repContato, repCompromisso);

            btn_listarItens.Enabled = true;
            btn_filtrarTarefas.Enabled = true;

            btn_filtrarTarefas.Enabled = true;
            btn_listarItens.Enabled = true;
            btn_concluidos.Enabled = true;
            btn_abertos.Enabled = true;
            btn_addItem.Enabled = true;

            ConfigurarTelaPrincipal(controlador);//reescrever o metodo equals para comparar objetos
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }


        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);

        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btn_inserir.ToolTipText = controlador.ToolTipInserir;
            btn_editar.ToolTipText = controlador.ToolTipEditar;
            btn_excluir.ToolTipText = controlador.ToolTipExcluir;

            btn_filtrarTarefas.ToolTipText = controlador.ToolTipFiltrar;
            btn_listarItens.ToolTipText = controlador.ToolTipListar;
            btn_concluidos.ToolTipText = controlador.ToolTipVisualizarConcluidos;
            btn_abertos.ToolTipText = controlador.ToolTipVisualizarAbertos;
            btn_addItem.ToolTipText = controlador.ToolTipInserirItens;
        }

        public void AtualizarRodape(string msg)
        {
            lbl_statusRodape.Text = msg;
        }

        public string VerificadorLblStatus() => lbl_statusRodape.Text;
        private void btnInserir_Click(object sender, EventArgs e)
        {

            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btn_filtrarTarefas_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }
    }
}