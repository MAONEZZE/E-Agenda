using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloDespesas;
using e_Agenda.WinApp.ModuloCategoriaDespesa;
using e_Agenda.Infra.Arquivo.ModuloContato;
using e_Agenda.Infra.Arquivo.ModuloCompromisso;
using e_Agenda.Infra.Arquivo.ModuloTarefa;
using e_Agenda.Infra.Arquivo.ModuloDespesa;
using e_Agenda.Infra.Arquivo.ModuloCategoriaDespesa;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioArquivoContato repContato = new RepositorioArquivoContato();
        private RepositorioArquivoCompromisso repCompromisso = new RepositorioArquivoCompromisso();
        private RepositorioArquivoTarefa repTarefa = new RepositorioArquivoTarefa();
        private RepositorioArquivoItemTarefa repItemTaf = new RepositorioArquivoItemTarefa();
        private RepositorioArquivoDespesa repDespesa = new RepositorioArquivoDespesa();
        private RepositorioArquivoCategoria repCategoria = new RepositorioArquivoCategoria();
        private static TelaPrincipalForm telaPrincipal;

        public TelaPrincipalForm()
        {
            InitializeComponent();
            telaPrincipal = this;
            Desabilitador();
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
        private void Desabilitador()
        {
            btn_inserir.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;

            btn_filtrar.Enabled = false;
            btn_listarItens.Enabled = false;
            btn_concluidos.Enabled = false;
            btn_abertos.Enabled = false;
            btn_addItem.Enabled = false;
        }

        private void Habilitador()
        {
            btn_inserir.Enabled = true;
            btn_editar.Enabled = true;
            btn_excluir.Enabled = true;

            if (controlador is ControladorCompromisso)
            {
                btn_filtrar.Enabled = true;
            }
            else if (controlador is ControladorTarefa)
            {
                btn_filtrar.Enabled = true;
                btn_concluidos.Enabled = true;
                btn_abertos.Enabled = true;
                btn_addItem.Enabled = true;
            }

        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repContato);

            Desabilitador();
            Habilitador();

            ConfigurarTelaPrincipal(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repTarefa, repItemTaf);

            Desabilitador();
            Habilitador();

            ConfigurarTelaPrincipal(controlador);
        }
        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repContato, repCompromisso);

            Desabilitador();
            Habilitador();

            ConfigurarTelaPrincipal(controlador);//reescrever o metodo equals para comparar objetos
        }

        private void despesasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDespesa(repDespesa, repCategoria);

            Desabilitador();
            Habilitador();

            ConfigurarTelaPrincipal(controlador);
        }

        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCategoriaDespesa(repCategoria);

            Desabilitador();
            Habilitador();

            ConfigurarTelaPrincipal(controlador);
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

            pnl_principal.Controls.Clear();//precisa disso para limpar o painel principal e poder
                                           //colocar outro painel por cima, sem que haja conflito

            pnl_principal.Controls.Add(listagem);

        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btn_inserir.ToolTipText = controlador.ToolTipInserir;
            btn_editar.ToolTipText = controlador.ToolTipEditar;
            btn_excluir.ToolTipText = controlador.ToolTipExcluir;

            btn_filtrar.ToolTipText = controlador.ToolTipFiltrar;
            btn_listarItens.ToolTipText = controlador.ToolTipListar;
            btn_concluidos.ToolTipText = controlador.ToolTipVisualizarConcluidos;
            btn_abertos.ToolTipText = controlador.ToolTipVisualizarAbertos;
            btn_addItem.ToolTipText = controlador.ToolTipInserirItens;
        }

        public void AtualizarRodape(string msg)
        {
            lbl_statusRodape.Text = msg;
        }

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

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            controlador.AddItem();
        }

        private void btn_concluidos_Click(object sender, EventArgs e)
        {
            controlador.ItensConcluidos();
        }


    }
}