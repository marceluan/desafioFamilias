using DT.SelecaoFamilias.AppService.Interfaces;
using DT.SelecaoFamilias.WebApi.Utils;
using Microsoft.AspNetCore.Mvc;

namespace DT.SelecaoFamilias.WebApi.Controllers
{
    [ApiController]
    [Route("familia")]
    public class FamiliaController : Controller
    {
        private readonly IListarFamiliasOrdenadasPorPontosAppService listarFamiliasOrdenadasPorPontosAppService;
        public FamiliaController(IListarFamiliasOrdenadasPorPontosAppService listarFamiliasOrdenadasPorPontosAppService)
        {
            this.listarFamiliasOrdenadasPorPontosAppService = listarFamiliasOrdenadasPorPontosAppService;
        }

        [HttpGet("listarFamilias")]
        public IActionResult ObterListaFamlias()
        {
            var resposta = listarFamiliasOrdenadasPorPontosAppService.ListarFamiliasOrdenadas();

            if (resposta == null)
            {
                return NoContent();
            }

            return Ok(FamiliaUtil.ConverterFamiliaParaModel(resposta));
        }
    }
}
