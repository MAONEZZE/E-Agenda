using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaCadastroItem : Form
    {
        public TelaCadastroItem(Tarefa tarefa)
        {
            InitializeComponent();

            this.ConfigurarTelas();

            ConfigurarTelaItem(tarefa);
        }

        private void ConfigurarTelaItem(Tarefa tarefa)
        {
            txb_id.Text = tarefa.id.ToString();
            txb_titulo.Text = tarefa.titulo;

            
            foreach (ItemTarefa item in tarefa.listaItens)
            {
                listBox_itens.Items.Add(item);
            }
            

            //ou listBox_itens.Items.AddRange(tarefa.listaItens.ToArray());

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            string descricao = txb_descricao.Text;

            ItemTarefa itemTarefa = new ItemTarefa(descricao, ItemTarefa.StatusPendenciaEnum.Pendente);

            listBox_itens.Items.Add(itemTarefa);

            txb_descricao.Text = "";
        }

        public List<ItemTarefa> ObterItensCad()
        {
            return listBox_itens.Items.Cast<ItemTarefa>().ToList(); //nos outros cadastros vc seleciona o
                                                                    //item q vc quer. Aqui ele vai passar por todos
                                                                    //os itens e convertendo 1 por 1
        }
    }
}
