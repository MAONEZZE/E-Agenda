using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGrid();

            grid.ConfigGridSoLeitura();
        }

        private void ConfigurarColunas()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "ID";
            id.HeaderText = "ID";

            DataGridViewTextBoxColumn assunto = new DataGridViewTextBoxColumn();
            assunto.Name = "Assunto";
            assunto.HeaderText = "Assunto";

            DataGridViewTextBoxColumn horaInicio = new DataGridViewTextBoxColumn();
            horaInicio.Name = "Horário Inicio";
            horaInicio.HeaderText = "Horário Inicio";

            DataGridViewTextBoxColumn data = new DataGridViewTextBoxColumn();
            data.Name = "Data";
            data.HeaderText = "Data";

            DataGridViewTextBoxColumn tipoComp = new DataGridViewTextBoxColumn();
            tipoComp.Name = "Tipo de Compromisso";
            tipoComp.HeaderText = "Tipo de Compromisso";

            grid.Columns.AddRange(id);
            grid.Columns.AddRange(assunto);
            grid.Columns.AddRange(data);
            grid.Columns.AddRange(horaInicio);
            grid.Columns.AddRange(tipoComp);
        }

        public void AtualizarRegistros(List<Compromisso> listaCompromisso)
        {
            grid.Rows.Clear();

            foreach (Compromisso taf in listaCompromisso)
            {
                grid.Rows.Add(taf.id, taf.assunto, taf.data, taf.horaInicio, taf.tipoComp);
            }
        }

        public int ObterIdSelecionado()
        {
            return Convert.ToInt32(grid.SelectedRows[0].Cells[0].Value);
        }
    }
}
