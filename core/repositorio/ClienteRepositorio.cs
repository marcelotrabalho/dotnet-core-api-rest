using System.Collections.Generic;
using Interface;
using Modelos;
using System.Data;

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
            var comandoSql = $"INSERT INTO CLIENTE (CPF,DT_NASCIMENTO,NOME) values ('{objeto.Cpf}','{objeto.DataNascimento.ToString("yyyy-mm-dd")}','{objeto.Nome}')";
            bancoDeDados.Conectar();
            bancoDeDados.Executar(comandoSql);
            bancoDeDados.FecharConexao();
        }

        private List<Cliente> Listar(string sql)
        {
            List<Modelos.Cliente> clientes = new List<Cliente>();

            bancoDeDados.Conectar();
            DataSet ds =  bancoDeDados.Listar(sql);
            foreach (System.Data.DataRow item in ds.Tables[0].Rows)
            {
                int idDoCliente = item.Field<int>("ID");
                List<Modelos.Endereco> enderecos = (new Repositorio.EnderecoRepositorio(bancoDeDados)).ListarByCliente(idDoCliente);

                clientes.Add(new Modelos.Cliente {
                    Cpf = item.Field<string>("CPF"),
                    DataNascimento = item.Field<System.DateTime>("DT_NASCIMENTO"),
                    Nome = item.Field<string>("NOME"),
                    Enderecos = enderecos
                });
            }
            bancoDeDados.FecharConexao();

            return clientes;
        }
        public Cliente Listar(int id)
        {
            return Listar($"SELECT * FROM CLIENTE WHERE ID = {id}")?[0];
        }

        public List<Cliente> Listar()
        {
            return Listar("SELECT * FROM CLIENTE");
        }

        public void Remove(Cliente objeto)
        {
            bancoDeDados.Conectar();
            bancoDeDados.Executar($"DELETE FROM CLIENTE WHERE ID={objeto.Id}");
            bancoDeDados.FecharConexao();
        }

        public void Update(Cliente objeto)
        {
            bancoDeDados.Conectar();
            bancoDeDados.Executar($"UPDATE CLIENTE SET CPF='{objeto.Cpf}',NOME='{objeto.Nome}' WHERE ID={objeto.Id}");
            bancoDeDados.FecharConexao();
        }
    }
}