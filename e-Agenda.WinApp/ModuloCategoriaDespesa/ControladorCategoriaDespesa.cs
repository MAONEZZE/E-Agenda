using e_Agenda.Dominio.ModuloCategoriaDespesa;
using e_Agenda.Infra.Arquivo.ModuloCategoriaDespesa;

namespace e_Agenda.WinApp.ModuloCategoriaDespesa
{
    public class ControladorCategoriaDespesa : ControladorBase
    {
        private TelaCadastroCategoria telaCategoria;
        private TabelaCategoriaControl tabelaCategoria;
        private RepositorioArquivoCategoria repCategoria;

        public ControladorCategoriaDespesa(RepositorioArquivoCategoria repCategoria)
        {
            this.repCategoria = repCategoria;
        }
        public override string ToolTipInserir => "Inserir Categoria de Despesa";

        public override string ToolTipEditar => "Editar uma Categoria de Despesa existente";

        public override string ToolTipExcluir => "Excluir uma Categoria de Despesa";

        public override void Editar()
        {
            CategoriaDespesa catSelecionado = ObterCategoriaSelecionada();

            if (catSelecionado == null)
            {
                MessageBox.Show($"Selecione um Compromisso primeiro!", //texto que fica no meio do painel
                    "Edição de Comprmisso", //texto que fica la em cima do painel
                    MessageBoxButtons.OK, //botão do painel
                    MessageBoxIcon.Exclamation);//icone que sera mostrado nesse painel
            }
            else
            {
                telaCategoria = new TelaCadastroCategoria();
                telaCategoria.Categoria = catSelecionado;

                DialogResult opcao = telaCategoria.ShowDialog();

                if (opcao == DialogResult.OK)
                {
                    repCategoria.Editar(telaCategoria.Categoria.id, telaCategoria.Categoria);

                    CarregarCategoria();

                    repCategoria.Serializador();
                }
            }
        }

        public override void Excluir()
        {
            CategoriaDespesa catSelecionado = ObterCategoriaSelecionada();

            if (catSelecionado == null)
            {
                MessageBox.Show($"Selecione uma Categoria primeiro!", //texto que fica no meio do painel
                    "Edição de Categoria", //texto que fica la em cima do painel
                    MessageBoxButtons.OK, //botão do painel
                    MessageBoxIcon.Exclamation);//icone que sera mostrado nesse painel
            }
            else
            {
                DialogResult opcao = MessageBox.Show($"Deseja excluir o Categoria {catSelecionado.titulo}", //texto que fica no meio do painel
                    "Exclusão de Categoria", //texto que fica la em cima do painel
                    MessageBoxButtons.OKCancel, //botão do painel
                    MessageBoxIcon.Question);//icone que sera mostrado nesse painel

                if (opcao == DialogResult.OK)
                {

                    repCategoria.Excluir(catSelecionado);

                    CarregarCategoria();

                    repCategoria.Serializador();
                }
            }
        }

        private CategoriaDespesa ObterCategoriaSelecionada()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            return repCategoria.SelecionarPorId(id);
        }

        public override void Inserir()
        {
            TelaCadastroCategoria telaCategoria = new TelaCadastroCategoria();

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                CategoriaDespesa categoria = telaCategoria.Categoria;

                repCategoria.Inserir(categoria);

                MessageBox.Show("Categoria gravada com Sucesso!");

                CarregarCategoria();

                repCategoria.Serializador();
            }
        }

        private void CarregarCategoria()
        {
            List<CategoriaDespesa> listaCategoria = repCategoria.SelecionarTodos();//esta pegando a lista de Compromisso e jogando para o contatos

            tabelaCategoria.AtualizarRegistros(listaCategoria);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaCategoria == null)
            {
                tabelaCategoria = new TabelaCategoriaControl();
            }

            CarregarCategoria();

            return tabelaCategoria;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Categoria";
        }
    }
}
