using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCategoriaDespesa
{
    public class RepositorioCategoria : RepositorioBase<CategoriaDespesa>
    {
        public RepositorioCategoria(List<CategoriaDespesa> listaCategorias)
        {
            this.listaRegistros = listaCategorias;
        }
    }
}
