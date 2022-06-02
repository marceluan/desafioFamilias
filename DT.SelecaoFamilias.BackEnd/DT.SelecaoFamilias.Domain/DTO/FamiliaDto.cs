using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.SelecaoFamilias.Domain.DTO
{
    public class FamiliaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Pontos { get; set; }
        public List<PessoaDto> Pessoas { get; set; }
    }
}
