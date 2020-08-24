using Modelos;
using System.Collections.Generic;
using Dao;
using Business;

namespace Business
{
    
    public class Endereco
    {
        private readonly Interface.IBancoDeDados banco = new SqliteCnnection("C:\\Users\\mxa\\OneDrive\\particular\\prova icatu\\projeto\\ProvaRestApi\\core\\dao\\clientes.sqlite");
        
        public Modelos.Endereco Get(int id)
        {
            Repositorio.EnderecoRepositorio endereco = new Repositorio.EnderecoRepositorio(banco);

            return endereco.Listar(id);
        }
        public List<Modelos.Endereco> GetAll()
        {
            Repositorio.EnderecoRepositorio endereco = new Repositorio.EnderecoRepositorio(banco);

            return endereco.Listar();

        }
        public void Add(Modelos.Endereco objeto)
        {
            (new Repositorio.EnderecoRepositorio(banco)).Add(objeto);
        }

        public void Update(Modelos.Endereco objeto)
        {
            (new Repositorio.EnderecoRepositorio(banco)).Update(objeto);
        }

        public void Remove(Modelos.Endereco objeto)
        {
            
            (new Repositorio.EnderecoRepositorio(banco)).Remove(objeto);
        }
        
    }
}