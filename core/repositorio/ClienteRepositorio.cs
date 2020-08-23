using System.Collections.Generic;
using Interface;
using Modelos;
namespace Repositorio
{
    public class ClienteRepositorio : IRepositorio<Cliente>
    {
        private readonly Interface.IBancoDeDados bancoDeDados;

        public ClienteRepositorio(Interface.IBancoDeDados conexaoBancoDados)
        {
            bancoDeDados = conexaoBancoDados;
        }

        public void Add(Cliente objeto)
        {
            throw new System.NotImplementedException();
        }

        public List<Cliente> Listar(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Cliente> Listar()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Cliente objeto)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Cliente objeto)
        {
            throw new System.NotImplementedException();
        }
    }
}