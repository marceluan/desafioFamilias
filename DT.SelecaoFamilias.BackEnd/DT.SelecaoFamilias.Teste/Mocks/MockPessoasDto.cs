using DT.SelecaoFamilias.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.SelecaoFamilias.Teste.Mocks
{
    public class MockPessoasDto
    {
        private static readonly PessoaDto PESSOA_1 = new PessoaDto()
        {
            Id = 1,
            Idade = 30,
            IdFamilia = 1,
            Nome = "A",
            Renda = 500,
            Sobrenome = "SANTOS",
            Tipo = 1
        };

        private static readonly PessoaDto PESSOA_2 = new PessoaDto()
        {
            Id = 2,
            Idade = 40,
            IdFamilia = 1,
            Nome = "B",
            Renda = 500,
            Sobrenome = "SANTOS",
            Tipo = 1
        };

        private static readonly PessoaDto PESSOA_3 = new PessoaDto()
        {
            Id = 3,
            Idade = 18,
            IdFamilia = 1,
            Nome = "A",
            Renda = 0,
            Sobrenome = "SANTOS",
            Tipo = 2
        };

        private static readonly PessoaDto PESSOA_4 = new PessoaDto()
        {
            Id = 4,
            Idade = 30,
            IdFamilia = 2,
            Nome = "A",
            Renda = 300,
            Sobrenome = "RAMOS",
            Tipo = 1
        };

        private static readonly PessoaDto PESSOA_5 = new PessoaDto()
        {
            Id = 5,
            Idade = 40,
            IdFamilia = 2,
            Nome = "A",
            Renda = 350,
            Sobrenome = "RAMOS",
            Tipo = 1
        };

        private static readonly PessoaDto PESSOA_6 = new PessoaDto()
        {
            Id = 6,
            Idade = 16,
            IdFamilia = 2,
            Nome = "A",
            Renda = 0,
            Sobrenome = "RAMOS",
            Tipo = 2
        };

        private static readonly PessoaDto PESSOA_7 = new PessoaDto()
        {
            Id = 7,
            Idade = 30,
            IdFamilia = 3,
            Nome = "A",
            Renda = 1000,
            Sobrenome = "ROCHA",
            Tipo = 1
        };

        private static readonly PessoaDto PESSOA_8 = new PessoaDto()
        {
            Id = 8,
            Idade = 40,
            IdFamilia = 3,
            Nome = "A",
            Renda = 1000,
            Sobrenome = "ROCHA",
            Tipo = 1
        };

        private static readonly PessoaDto PESSOA_9 = new PessoaDto()
        {
            Id = 9,
            Idade = 15,
            IdFamilia = 3,
            Nome = "A",
            Renda = 0,
            Sobrenome = "ROCHA",
            Tipo = 2
        };

        private static readonly PessoaDto DEPENDENTE1_FAMILIA_3 = new PessoaDto()
        {
            Id = 9,
            Idade = 15,
            IdFamilia = 3,
            Nome = "A",
            Renda = 0,
            Sobrenome = "ROCHA",
            Tipo = 2
        };

        private static readonly PessoaDto DEPENDENTE2_FAMILIA_3 = new PessoaDto()
        {
            Id = 9,
            Idade = 15,
            IdFamilia = 3,
            Nome = "A",
            Renda = 0,
            Sobrenome = "ROCHA",
            Tipo = 2
        };

        private static readonly PessoaDto PESSOA_10 = new PessoaDto()
        {
            Id = 7,
            Idade = 30,
            IdFamilia = 4,
            Nome = "A",
            Renda = 1000,
            Sobrenome = "DRUMOND",
            Tipo = 1
        };

        private static readonly PessoaDto PESSOA_11 = new PessoaDto()
        {
            Id = 8,
            Idade = 40,
            IdFamilia = 4,
            Nome = "A",
            Renda = 1000,
            Sobrenome = "DRUMOND",
            Tipo = 1
        };


        public static List<PessoaDto> retornarMockPessoas()
        {
            List<PessoaDto> mockListPessoas = new List<PessoaDto>();
            mockListPessoas.Add(PESSOA_1);
            mockListPessoas.Add(PESSOA_2);
            mockListPessoas.Add(PESSOA_3);
            mockListPessoas.Add(PESSOA_4);
            mockListPessoas.Add(PESSOA_5);
            mockListPessoas.Add(PESSOA_6);
            mockListPessoas.Add(PESSOA_7);
            mockListPessoas.Add(PESSOA_8);
            mockListPessoas.Add(PESSOA_9);
            mockListPessoas.Add(PESSOA_10);
            mockListPessoas.Add(PESSOA_11);
            mockListPessoas.Add(DEPENDENTE1_FAMILIA_3);
            mockListPessoas.Add(DEPENDENTE2_FAMILIA_3);


            return mockListPessoas;
        }
    }
}
