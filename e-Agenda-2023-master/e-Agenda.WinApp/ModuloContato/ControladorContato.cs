﻿using e_Agenda.WinApp.Compartilhado;
using System.Reflection;

namespace e_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private ListagemContatoControl listagemContato;

        public ControladorContato(RepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo Contato";  } }

        public override string ToolTipEditar { get { return "Editar Contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Contato existente"; } }

        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)//clicou em gravar
            {
                Contato contato = telaContato.Contato;//vai "puxar" o que foi escrito no dialog e armazenar em contato

                repositorioContato.Inserir(contato);//vai mandar pro repositorio

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

                return;
            }
            else
            {
                TelaContatoForm telaContato = new TelaContatoForm();
                telaContato.Contato = contato;

                DialogResult opcaoEscolhida = telaContato.ShowDialog();

                if (opcaoEscolhida == DialogResult.OK)
                {
                    repositorioContato.Editar(telaContato.Contato);

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
                DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {contato.nome}?", "Exclusão de Contatos",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcaoEscolhida == DialogResult.OK)
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