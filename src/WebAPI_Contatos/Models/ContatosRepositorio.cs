using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Contatos.Models
{
    public class ContatosRepositorio : IContatosRepositorio
    {
        static List<Contato> ListaContatos = new List<Contato>();
        public void Adicionar(Contato item)
        {
            ListaContatos.Add(item);
        }
        public void Atualizar(Contato item)
        {
            var itemAtualizar = ListaContatos.SingleOrDefault(r => r.Telefone == item.Telefone);

            if (itemAtualizar != null)
            {
                itemAtualizar.Nome = item.Nome;
                itemAtualizar.SobreNome = item.SobreNome;
                itemAtualizar.IsParente = item.IsParente;
                itemAtualizar.Empresa = item.Empresa;
                itemAtualizar.Email = item.Email;
                itemAtualizar.Telefone = item.Telefone;
                itemAtualizar.DataNascimento = item.DataNascimento;
            }
        }
        public Contato Encontrar(string Chave)
        {
            return ListaContatos.Where(e => e.Equals(Chave)).FirstOrDefault();
        }
        public IEnumerable<Contato> GetTodos()
        {
            return ListaContatos;
        }
        public void Remover (string id)
        {
            var itemRemover = ListaContatos.SingleOrDefault(r => r.Telefone == id);
            if (itemRemover != null)
            {
                ListaContatos.Remove(itemRemover);
            }
        }
    }
}
