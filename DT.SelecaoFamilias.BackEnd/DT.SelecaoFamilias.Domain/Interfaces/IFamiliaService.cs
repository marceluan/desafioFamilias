using DT.SelecaoFamilias.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.SelecaoFamilias.Domain.Interfaces
{
    public interface IFamiliaService
    {
        public List<FamiliaDto> ListarFamilias();
        public List<FamiliaDto> CalcularPontosDeAcordoComARenda(List<FamiliaDto> listFamilia);
        public List<FamiliaDto> CalcularPontosDeAcordoComQuantidadeDependentes(List<FamiliaDto> listFamilia);
    }
}
