using DT.SelecaoFamilias.Domain.DTO;
using DT.SelecaoFamilias.WebApi.Models;

namespace DT.SelecaoFamilias.WebApi.Utils
{
    public static class FamiliaUtil
    {
        public static List<FamiliaModel> ConverterFamiliaParaModel( List<FamiliaDto> listFamilia)
        {
            List<FamiliaModel> listFamiliaModel = new List<FamiliaModel>();

            foreach (var familia in listFamilia)
            {
                listFamiliaModel.Add(new FamiliaModel()
                {
                    Nome = familia.Nome,
                    Pontos = familia.Pontos
                });
            }

            return listFamiliaModel;
        }
    }
}
