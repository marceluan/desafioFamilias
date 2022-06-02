using DT.SelecaoFamilias.Domain.DTO;
using DT.SelecaoFamilias.Domain.Services;
using DT.SelecaoFamilias.Infra.Data.Entidades;
using DT.SelecaoFamilias.Infra.Data.Interfaces;
using DT.SelecaoFamilias.Teste.Mocks;
using Moq;

namespace DT.SelecaoFamilias.Teste.Services.FamiliaTeste
{
    public class CalcularPontosPorRenda
    {
        private Mock<IPessoaRepository> pessoaRepository;
        private readonly FamiliaService familiaService;
        public CalcularPontosPorRenda()
        {
            pessoaRepository = new Mock<IPessoaRepository>();  
            familiaService = new FamiliaService(pessoaRepository.Object);
        }

        [Fact]
        public void CalcularPontosPorRenda_Service_MenorQueRendaMinima()
        {
            List<PessoaDto> mockFamiliaRendaMina = MockPessoasDto.retornarMockPessoas().Where(familia => familia.IdFamilia == 2).ToList();

            var retorno = familiaService.CalcularPontosPorRenda(mockFamiliaRendaMina);

            Assert.Equal(5, retorno);
        }

        [Fact]
        public void CalcularPontosPorRenda_Service_MaiorQueRendaMinimaEMenorOuIgualRendaMaxima()
        {
            List<PessoaDto> mockFamiliaRendaMina = MockPessoasDto.retornarMockPessoas().Where(familia => familia.IdFamilia == 1).ToList();

            var retorno = familiaService.CalcularPontosPorRenda(mockFamiliaRendaMina);

            Assert.Equal(3, retorno);
        }

        [Fact]
        public void CalcularPontosPorRenda_Service_MaiorQueRendaMaxima()
        {
            List<PessoaDto> mockFamiliaRendaMina = MockPessoasDto.retornarMockPessoas().Where(familia => familia.IdFamilia == 3).ToList();

            var retorno = familiaService.CalcularPontosPorRenda(mockFamiliaRendaMina);

            Assert.Equal(0, retorno);
        }
    }
}
