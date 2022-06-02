using DT.SelecaoFamilias.Domain.Services;
using DT.SelecaoFamilias.Infra.Data.Interfaces;
using DT.SelecaoFamilias.Infra.Data.Mocks;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.SelecaoFamilias.Teste.Services.FamiliaTeste
{
    
    public class ListarFamilias 
    {
        private Mock<IPessoaRepository> pessoaRepository;
        private readonly FamiliaService familiaService;
        public ListarFamilias()
        {
            Setups();

            familiaService = new FamiliaService(pessoaRepository.Object);
        }
        
        private void Setups()
        {
            pessoaRepository = new Mock<IPessoaRepository>();

            pessoaRepository.Setup(s => s.ListarPessoas()).Returns(MockPessoas.retornarMockPessoas());
        }

        [Fact]
        public void ListarPessoas_Service_RetornoValido_Sucesso()
        {
            var resposta = familiaService.ListarFamilias();

            Assert.NotNull(resposta);
            Assert.NotEmpty(resposta);
            Assert.Equal(3, resposta.Count());

            pessoaRepository.Verify(v => v.ListarPessoas(), Times.Once);

            pessoaRepository.VerifyNoOtherCalls();
        }
    }
}
