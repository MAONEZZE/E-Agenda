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
    public partial class TelaFiltroCompromisso : Form
    {
        public TelaFiltroCompromisso()
        {
            InitializeComponent();
        }

        public ControladorCompromisso.StatusCompEnum ObterStatus()
        {
            if (rb_compPassados.Checked)
            {
                return ControladorCompromisso.StatusCompEnum.Passados;
            }
            else if (rb_todosComp.Checked)
            {
                return ControladorCompromisso.StatusCompEnum.Todos;
            }
            else
            {
                return ControladorCompromisso.StatusCompEnum.Futuros;
            }
        }

        public DateTime ObterDataInicio
        {
            get 
            {
                return txb_dataInicio.Value;
            }
        }

        public DateTime ObterDataFinal
        {
            get
            {
                return txb_dataFim.Value;
            }
        }
    }
}
