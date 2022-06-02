using DT.SelecaoFamilias.Infra.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.SelecaoFamilias.Infra.Data.Mocks
{
    public static class MockPessoas
    {
        private static readonly Pessoa PESSOA_1 = new Pessoa()
        {
            Id = 1,
            Idade = 30,
            IdFamilia = 1,
            Nome = "A",
            Renda = 500,
            Sobrenome = "SANTOS",
            Tipo = 1
        };

        private static readonly Pessoa PESSOA_2 = new Pessoa()
        {
            Id = 2,
            Idade = 40,
            IdFamilia = 1,
            Nome = "B",
            Renda = 500,
            Sobrenome = "SANTOS",
            Tipo = 1
        };

        private static readonly Pessoa PESSOA_3 = new Pessoa()
        {
            Id = 3,
            Idade = 18,
            IdFamilia = 1,
            Nome = "A",
            Renda = 0,
            Sobrenome = "SANTOS",
            Tipo = 2
        };

        private static readonly Pessoa PESSOA_4 = new Pessoa()
        {
            Id = 4,
            Idade = 30,
            IdFamilia = 2,
            Nome = "A",
            Renda = 300,
            Sobrenome = "RAMOS",
            Tipo = 1
        };

        private static readonly Pessoa PESSOA_5 = new Pessoa()
        {
            Id = 5,
            Idade = 40,
            IdFamilia = 2,
            Nome = "A",
            Renda = 350,
            Sobrenome = "RAMOS",
            Tipo = 1
        };

        private static readonly Pessoa PESSOA_6 = new Pessoa()
        {
            Id = 6,
            Idade = 16,
            IdFamilia = 2,
            Nome = "A",
            Renda = 0,
            Sobrenome = "RAMOS",
            Tipo = 2
        };

        private static readonly Pessoa PESSOA_7= new Pessoa()
        {
            Id = 7,
            Idade = 30,
            IdFamilia = 3,
            Nome = "A",
            Renda = 1000,
            Sobrenome = "ROCHA",
            Tipo = 1
        };

        private static readonly Pessoa PESSOA_8 = new Pessoa()
        {
            Id = 8,
            Idade = 40,
            IdFamilia = 3,
            Nome = "A",
            Renda = 1000,
            Sobrenome = "ROCHA",
            Tipo = 1
        };

        private static readonly Pessoa PESSOA_9 = new Pessoa()
        {
            Id = 9,
            Idade = 15,
            IdFamilia = 3,
            Nome = "A",
            Renda = 0,
            Sobrenome = "ROCHA",
            Tipo = 2
        };

        public static List<Pessoa> retornarMockPessoas()
        {
            List<Pessoa> mockListPessoas = new List<Pessoa>();
            mockListPessoas.Add(PESSOA_1);
            mockListPessoas.Add(PESSOA_2);
            mockListPessoas.Add(PESSOA_3);
            mockListPessoas.Add(PESSOA_4);
            mockListPessoas.Add(PESSOA_5);
            mockListPessoas.Add(PESSOA_6);
            mockListPessoas.Add(PESSOA_7);
            mockListPessoas.Add(PESSOA_8);
            mockListPessoas.Add(PESSOA_9);

            return mockListPessoas;
        }
    }
}
