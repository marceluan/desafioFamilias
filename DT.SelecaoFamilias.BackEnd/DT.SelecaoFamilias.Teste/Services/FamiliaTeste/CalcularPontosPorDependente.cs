using DT.SelecaoFamilias.Domain.DTO;
using DT.SelecaoFamilias.Domain.Services;
using DT.SelecaoFamilias.Infra.Data.Interfaces;
using DT.SelecaoFamilias.Teste.Mocks;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.SelecaoFamilias.Teste.Services.FamiliaTeste
{
    public class CalcularPontosPorDependente
    {
        private Mock<IPessoaRepository> pessoaRepository;
        private readonly FamiliaService familiaService;
        public CalcularPontosPorDependente()
        {
            pessoaRepository = new Mock<IPessoaRepository>();
            familiaService = new FamiliaService(pessoaRepository.Object);
        }

        [Fact]
        public void CalcularPontosPorRenda_Service_SemDependentesValidos()
        {
            List<PessoaDto> mockFamiliaRendaMina = MockPessoasDto.retornarMockPessoas().Where(familia => familia.IdFamilia == 1).ToList();

            var retorno = familiaService.CalcularPontosPorDependente(mockFamiliaRendaMina);

            Assert.Equal(0, retorno);
        }

        [Fact]
        public void CalcularPontosPorRenda_Service_SemDependentes()
        {
            List<PessoaDto> mockFamiliaRendaMina = MockPessoasDto.retornarMockPessoas().Where(familia => familia.IdFamilia == 4).ToList();

            var retorno = familiaService.CalcularPontosPorDependente(mockFamiliaRendaMina);

            Assert.Equal(0, retorno);
        }

        [Fact]
        public void CalcularPontosPorRenda_Service_ComUmOuDoisDependentes()
        {
            List<PessoaDto> mockFamiliaRendaMina = MockPessoasDto.retornarMockPessoas().Where(familia => familia.IdFamilia == 2).ToList();

            var retorno = familiaService.CalcularPontosPorDependente(mockFamiliaRendaMina);

            Assert.Equal(2, retorno);
        }

        [Fact]
        public void CalcularPontosPorRenda_Service_ComTresOuMaisDependentes()
        {
            List<PessoaDto> mockFamiliaRendaMina = MockPessoasDto.retornarMockPessoas().Where(familia => familia.IdFamilia == 3).ToList();

            var retorno = familiaService.CalcularPontosPorDependente(mockFamiliaRendaMina);

            Assert.Equal(3, retorno);
        }
    }
}
