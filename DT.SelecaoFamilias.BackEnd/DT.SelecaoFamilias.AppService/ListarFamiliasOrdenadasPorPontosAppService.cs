using DT.SelecaoFamilias.AppService.Interfaces;
using DT.SelecaoFamilias.Domain.DTO;
using DT.SelecaoFamilias.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.SelecaoFamilias.AppService
{
    public class ListarFamiliasOrdenadasPorPontosAppService : IListarFamiliasOrdenadasPorPontosAppService
    {
        private readonly IFamiliaService familiaService;

        public ListarFamiliasOrdenadasPorPontosAppService(IFamiliaService familiaService)
        {
            this.familiaService = familiaService;
        }
        public List<FamiliaDto> ListarFamiliasOrdenadas()
        {
            List<FamiliaDto> listFamilia = familiaService.ListarFamilias();

            listFamilia = familiaService.CalcularPontosDeAcordoComARenda(listFamilia);

            listFamilia = familiaService.CalcularPontosDeAcordoComQuantidadeDependentes(listFamilia);

            return listFamilia.OrderByDescending(familia => familia.Pontos).ToList();
        }
    }
}
