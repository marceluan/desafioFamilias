using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.SelecaoFamilias.Infra.Data.Entidades
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Renda { get; set; }
        public int Tipo { get; set; }
        public int Idade { get; set; }
        public int IdFamilia { get; set; }
    }
}
