using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCategoriaDespesa
{
    public class CategoriaDespesa : EntidadeBase<CategoriaDespesa>
    {
        public string titulo;

        public CategoriaDespesa(string titulo)
        {
            this.titulo = titulo;
        }

        public override void AtualizarInformacoes(CategoriaDespesa registrosAtualizados)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
