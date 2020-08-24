using Modelos;
using System.Collections.Generic;
using Dao;
using Business;

namespace Business
{
    public class Cliente
    {
        private readonly Interface.IBancoDeDados banco = new SqliteCnnection("C:\\Users\\mxa\\OneDrive\\particular\\prova icatu\\projeto\\ProvaRestApi\\core\\dao\\clientes.sqlite");

        /// <sumary>
        /// Método para retornar um cliente especifico.
        /// Exemplo para documentar no swagger
        /// </sumary>
        public Modelos.Cliente Get(int id)
        {
            Repositorio.ClienteRepositorio cliente = new Repositorio.ClienteRepositorio(banco);

            return cliente.Listar(id);
        }
        public List<Modelos.Cliente> GetAll()
        {
            Repositorio.ClienteRepositorio clientes = new Repositorio.ClienteRepositorio(banco);

            return clientes.Listar();

        }
        public void Add(Modelos.Cliente objeto)
        {
            (new Repositorio.ClienteRepositorio(banco)).Add(objeto);
        }

        public void Update(Modelos.Cliente objeto)
        {
            (new Repositorio.ClienteRepositorio(banco)).Update(objeto);
        }

        public void Remove(Modelos.Cliente objeto)
        {
            
            (new Repositorio.ClienteRepositorio(banco)).Remove(objeto);
        }
    }
}