using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Contatos.Models
{
    public interface IContatosRepositorio
    {
        void Adicionar(Contato item);
        IEnumerable<Contato> GetTodos();
        Contato Encontrar(string chave);
        void Remover(string id);
        void Atualizar(Contato item);
    }
}
