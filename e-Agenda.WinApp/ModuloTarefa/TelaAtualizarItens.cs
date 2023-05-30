using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaAtualizarItens : Form
    {
        public TelaAtualizarItens(Tarefa tarefa)
        {
            InitializeComponent();

            this.ConfigurarTelas();

            ConfigurarTelaItem(tarefa);
        }

        private void ConfigurarTelaItem(Tarefa tarefa)
        {
            txb_id.Text = tarefa.id.ToString();
            txb_titulo.Text = tarefa.titulo;

            int i = 0;
            foreach (ItemTarefa item in tarefa.listaItens)
            {
                listBox_itensTarefa.Items.Add(item);

                if(item.status == ItemTarefa.StatusPendenciaEnum.Concluido)
                {
                    listBox_itensTarefa.SetItemChecked(i, true);
                }
                i++;
            }


            //ou listBox_itens.Items.AddRange(tarefa.listaItens.ToArray());

        }

        public List<ItemTarefa> ObterItensMarcados()
        {
            return listBox_itensTarefa.CheckedItems.Cast<ItemTarefa>().ToList();
        }

        internal List<ItemTarefa> ObterItensPendentes()
        {
            return listBox_itensTarefa.Items.Cast<ItemTarefa>().Except(ObterItensMarcados()).ToList();
        }
    }
}
