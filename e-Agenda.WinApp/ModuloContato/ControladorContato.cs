﻿using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private TelaContatoForm telaContato;
        private RepositorioContato repContato;
        private TabelaContatoControl tabelaContato;

        public ControladorContato(RepositorioContato repositorioContato)
        {
            this.repContato = repositorioContato;
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

                repContato.Inserir(contato);//vai mandar pro repositorio

                MessageBox.Show("Contato Gravado com sucesso!");

                CarregarContatos();
            }
        }

        public override void Editar()
        {
            Contato contato = ObterContatoSelecionado();

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
                    repContato.Editar(telaContato.Contato.id, telaContato.Contato);

                    CarregarContatos();
                }
            }
        }

        private Contato ObterContatoSelecionado()
        {
            int id = tabelaContato.ObterIdSelecionado();

            return repContato.SelecionarPorId(id);
        }

        public override void Excluir()
        {            
            Contato contato = ObterContatoSelecionado();

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
                    repContato.Excluir(contato);

                    CarregarContatos();
                }
            }
        }

        private void CarregarContatos()
        {
            
            List<Contato> contatos = repContato.SelecionarTodos();//esta pegando a lista de Contatos e jogando para o contatos

            tabelaContato.AtualizarRegistros(contatos);//vai passar a lista para o listBox por meio desse metodo 
        }

        public override UserControl ObterListagem()
        {
            if (tabelaContato == null)
                tabelaContato = new TabelaContatoControl();

            CarregarContatos();

            return tabelaContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";            
        }

        
    }
}
