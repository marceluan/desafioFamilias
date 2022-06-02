using DT.SelecaoFamilias.Domain.DTO;
using DT.SelecaoFamilias.Domain.Interfaces;
using DT.SelecaoFamilias.Infra.Data.Entidades;
using DT.SelecaoFamilias.Shared;
using DT.SelecaoFamilias.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DT.SelecaoFamilias.Shared.Enum;

namespace DT.SelecaoFamilias.Domain.Services
{
    public class FamiliaService : IFamiliaService
    {
        private readonly IPessoaRepository pessoaRepositorio;

        public FamiliaService(IPessoaRepository pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }

        public List<FamiliaDto> ListarFamilias()
        {
            return MapearListaEntidadePessoaParaListaFamiliaDto(pessoaRepositorio.ListarPessoas());
        }

        public List<FamiliaDto> CalcularPontosDeAcordoComARenda(List<FamiliaDto> listFamilia)
        {
            listFamilia.ForEach(familia => familia.Pontos += CalcularPontosPorRenda(familia.Pessoas));

            return listFamilia;
        }

        public List<FamiliaDto> CalcularPontosDeAcordoComQuantidadeDependentes(List<FamiliaDto> listFamilia)
        {
            listFamilia.ForEach(familia => familia.Pontos += CalcularPontosPorDependente(familia.Pessoas));

            return listFamilia;
        }

        #region Metodos Privados 
        public int CalcularPontosPorRenda(List<PessoaDto> listPessoas)
        {
            int rendaTotal = 0;
            int rendaMinima = 900;
            int rendaMaxima = 1500;

            foreach (var pessoa in listPessoas)
            {
                rendaTotal += pessoa.Renda;
            }

            if (rendaTotal <= rendaMinima)
            {
                return 5;
            }
            else if (rendaTotal > rendaMinima && rendaTotal < rendaMaxima)
            {
                return 3;
            }
            return 0;
        }

        public int CalcularPontosPorDependente(List<PessoaDto> listPessoas)
        {
            int idadeMaxima = 18;
            int quantidadeMaximaDependentes = 3;
            int quantidadeDependentesMenoresDeIdade = listPessoas.Where(pessoa => pessoa.Idade < idadeMaxima && pessoa.Tipo == Tipo.DEPENDENTE).Count();

            if (quantidadeDependentesMenoresDeIdade >= quantidadeMaximaDependentes)
            {
                return 3;
            }
            else if (quantidadeDependentesMenoresDeIdade < quantidadeMaximaDependentes && quantidadeDependentesMenoresDeIdade > 0)
            {
                return 2;
            }

            return 0;
        }
        #endregion  

        #region Métodos Privados Mapeamento
        private List<FamiliaDto> MapearListaEntidadePessoaParaListaFamiliaDto(List<Pessoa> listPessoas)
        {
            List<FamiliaDto> listFamilia = new List<FamiliaDto>();
            List<Pessoa> agrupamentoPessoas = listPessoas.GroupBy(pessoa => pessoa.IdFamilia).Select(grp => grp.First()).ToList();

            foreach (Pessoa pessoa in agrupamentoPessoas)
            {
                FamiliaDto familia = new FamiliaDto();
                familia.Id = pessoa.IdFamilia;
                familia.Nome = pessoa.Sobrenome;
                familia.Pessoas = MapearEntidadePessoaParaListaPessoaDto(listPessoas.Where(pessoa => pessoa.IdFamilia == familia.Id).ToList());

                listFamilia.Add(familia);
            }

            return listFamilia;
        }

        private List<PessoaDto> MapearEntidadePessoaParaListaPessoaDto(List<Pessoa> listPessoas)
        {
            List<PessoaDto> listPessoaDto = new List<PessoaDto>();
            foreach (var pessoa in listPessoas)
            {
                PessoaDto pessoaDto = new PessoaDto();
                pessoaDto.Id = pessoa.Id;
                pessoaDto.Idade = pessoa.Idade;
                pessoaDto.Renda = pessoa.Renda;
                pessoaDto.IdFamilia = pessoa.IdFamilia;
                pessoaDto.Nome = pessoa.Nome;
                pessoaDto.Sobrenome = pessoa.Sobrenome;
                pessoaDto.Tipo = pessoa.Tipo;

                listPessoaDto.Add(pessoaDto);
            }

            return listPessoaDto;
        }
        #endregion
    }
}
