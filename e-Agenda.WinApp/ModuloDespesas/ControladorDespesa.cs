using e_Agenda.WinApp.ModuloCategoriaDespesa;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class ControladorDespesa : ControladorBase
    {
        private TabelaDespesaControl tabelaDespesa;
        private RepositorioDespesa repDespesa;
        private RepositorioCategoria repCategoria;

        public ControladorDespesa(RepositorioDespesa repDespesa, RepositorioCategoria repCategoria)
        {
            this.repDespesa = repDespesa;
            this.repCategoria = repCategoria;
        }

        public override string ToolTipInserir => "Inserir uma nova Despesa";

        public override string ToolTipEditar => "Editar uma Despesa existente";

        public override string ToolTipExcluir => "Excluir uma Despesa existente";

        public override void Editar()
        {
            Despesa despesaSelec = ObterDespesaSelecionado();

            if (despesaSelec == null)
            {
                MessageBox.Show($"Selecione uma Despesa primeiro!", //texto que fica no meio do painel
                    "Edição de Comprmisso", //texto que fica la em cima do painel
                    MessageBoxButtons.OK, //botão do painel
                    MessageBoxIcon.Exclamation);//icone que sera mostrado nesse painel
            }
            else
            {
                List<Despesa> listaDespesa = repDespesa.SelecionarTodos();
                TelaDespesaForm telaDespesa = new TelaDespesaForm(repCategoria);

                telaDespesa.DespesaP = despesaSelec;

                DialogResult opcao = telaDespesa.ShowDialog();

                if (opcao == DialogResult.OK)
                {
                    Despesa despesa = telaDespesa.DespesaP;

                    repDespesa.Editar(despesa.id, despesa);

                    CarregarCompromisso();
                }
            }
        }

        public override void Excluir()
        {
            Despesa despesaSelec = ObterDespesaSelecionado();

            if (despesaSelec == null)
            {
                MessageBox.Show($"Selecione uma Despesa primeiro!", //texto que fica no meio do painel
                    "Edição de Comprmisso", //texto que fica la em cima do painel
                    MessageBoxButtons.OK, //botão do painel
                    MessageBoxIcon.Exclamation);//icone que sera mostrado nesse painel
            }
            else
            {
                DialogResult opcao = MessageBox.Show($"Deseja excluir a Despesa {despesaSelec.descricao}", //texto que fica no meio do painel
                    "Exclusão de Despesa", //texto que fica la em cima do painel
                    MessageBoxButtons.OKCancel, //botão do painel
                    MessageBoxIcon.Question);//icone que sera mostrado nesse painel

                if (opcao == DialogResult.OK)
                {
                    repDespesa.Excluir(despesaSelec);

                    CarregarCompromisso();
                }
            }
        }

        private Despesa ObterDespesaSelecionado()
        {
            int id = tabelaDespesa.ObterIdSelecionado();

            return repDespesa.SelecionarPorId(id);
        }

        public override void Inserir()
        {
            TelaDespesaForm telaDespesa = new TelaDespesaForm(this.repCategoria);

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesa = telaDespesa.DespesaP;

                repDespesa.Inserir(despesa);

                MessageBox.Show("Compromisso Gravado com sucesso!");

                CarregarCompromisso();
            }
        }

        private void CarregarCompromisso()
        {
            List<Despesa> listadespesa = repDespesa.SelecionarTodos();//esta pegando a lista de Compromisso e jogando para o contatos

            tabelaDespesa.AtualizarRegistros(listadespesa);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaDespesa == null)
            {
                tabelaDespesa = new TabelaDespesaControl();
            }

            CarregarCompromisso();

            return tabelaDespesa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Despesas";
        }
    }
}
