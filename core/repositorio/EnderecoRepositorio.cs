using System.Collections.Generic;
using Interface;
using Modelos;

namespace Repositorio
{
    public class EnderecoRepositorio : IRepositorio<Endereco>
    {
        private readonly IBancoDeDados bancoDeDados;
        public EnderecoRepositorio(IBancoDeDados conexaoBancoDados)
        {
            bancoDeDados = conexaoBancoDados;
        }
        public void Add(Endereco objeto)
        {
            throw new System.NotImplementedException();
        }

        public List<Endereco> Listar(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Endereco> Listar()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Endereco objeto)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Endereco objeto)
        {
            throw new System.NotImplementedException();
        }
    }

}