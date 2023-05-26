using e_Agenda.WinApp.Compartilhado;
using System.Reflection;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace e_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private TelaPrincipalForm tlPrincipal;
        private TelaContatoForm telaContato;
        private RepositorioContato repositorioContato;
        private ListagemContatoControl listagemContato;

        public ControladorContato(RepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir => "Inserir novo Contato";

        public override string ToolTipEditar => "Editar Contato existente";

        public override string ToolTipExcluir => "Excluir Contato existente";

        public override void Inserir()
        {
            telaContato = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)//clicou em gravar
            {
                Contato contato = telaContato.Contato;

                repositorioContato.Inserir(contato);//vai mandar pro repositorio

                MessageBox.Show("Contato Gravado com sucesso!");

                CarregarContatos();
            }
        }

        public override void Editar()
        {
            Contato contato = listagemContato.ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Edição de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                TelaContatoForm telaContato = new TelaContatoForm();
                telaContato.Contato = contato;

                DialogResult opcao = telaContato.ShowDialog();

                if (opcao == DialogResult.OK)
                {
                    repositorioContato.Editar(telaContato.Contato.id, telaContato.Contato);

                    CarregarContatos();
                }
            }
        }

        public override void Excluir()
        {            
            Contato contato = listagemContato.ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            else
            {
                DialogResult opcao = MessageBox.Show($"Deseja excluir o contato {contato.nome}?", "Exclusão de Contatos",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcao == DialogResult.OK)
                {
                    repositorioContato.Excluir(contato);

                    CarregarContatos();
                }
            }
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();//esta pegando a lista de Contatos e jogando para o contatos

            listagemContato.AtualizarRegistros(contatos);//vai passar a lista para o listBox por meio desse metodo 
        }

        public override UserControl ObterListagem()
        {
            if (listagemContato == null)
                listagemContato = new ListagemContatoControl();

            CarregarContatos();

            return listagemContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";            
        }

        
    }
}
