using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Contatos.Models
{
    public class Contato
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public bool IsParente { get; set; }
        public string Empresa { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
