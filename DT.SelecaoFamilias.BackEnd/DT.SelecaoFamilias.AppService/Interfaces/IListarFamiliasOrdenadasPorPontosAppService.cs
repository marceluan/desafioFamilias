using DT.SelecaoFamilias.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.SelecaoFamilias.AppService.Interfaces
{
    public interface IListarFamiliasOrdenadasPorPontosAppService
    {
        public List<FamiliaDto> ListarFamiliasOrdenadas();
    }
}
