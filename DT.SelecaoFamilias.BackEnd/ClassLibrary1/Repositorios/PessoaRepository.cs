using DT.SelecaoFamilias.Infra.Data.Entidades;
using DT.SelecaoFamilias.Infra.Data.Interfaces;
using DT.SelecaoFamilias.Infra.Data.Mocks;

namespace DT.SelecaoFamilias.Infra.Data.Repositorios
{
    public class PessoaRepository : IPessoaRepository
    {
        public List<Pessoa> ListarPessoas()
        {
            return MockPessoas.retornarMockPessoas();
        }
    }
}
