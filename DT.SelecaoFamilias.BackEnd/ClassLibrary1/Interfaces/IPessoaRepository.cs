using DT.SelecaoFamilias.Infra.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.SelecaoFamilias.Infra.Data.Interfaces
{
    public interface IPessoaRepository
    {
        public List<Pessoa> ListarPessoas();
    }
}
