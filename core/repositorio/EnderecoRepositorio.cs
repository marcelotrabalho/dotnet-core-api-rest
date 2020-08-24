using System.Collections.Generic;
using Interface;
using Modelos;
using System.Data;

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
            bancoDeDados.Conectar();
            bancoDeDados.Executar($"INSERTO INTO ENDERECO (NOME_DA_RUA,BAIRRO,CIDADE,ESTADO,ID_CLIENTE) VALUES ('{objeto.NomeDaRua}','{objeto.Bairro}','{objeto.Cidade}','{objeto.Estado}',{objeto.Cliente.Id}");
            bancoDeDados.FecharConexao();
        }

        public Endereco Listar(int id)
        {
            return Listar($"SELECT * FROM ENDERECO WHERE ID={id}")?[0];
        }
        public List<Endereco> ListarByCliente(int idCliente)
        {
            return Listar($"SELECT * FROM ENDERECO WHERE ID_CLIENTE={idCliente}");
        }
        private List<Endereco> Listar(string sql)
        {
            List<Modelos.Endereco> enderecos = new List<Endereco>();

            bancoDeDados.Conectar();
            DataSet ds =  bancoDeDados.Listar(sql);
            foreach (System.Data.DataRow item in ds.Tables[0].Rows)
            {
                int idDoCliente = item.Field<int>("ID_CLIENTE");
                Modelos.Cliente cliente = (new Repositorio.ClienteRepositorio(bancoDeDados)).Listar(idDoCliente);

                enderecos.Add(new Modelos.Endereco {
                    Id = item.Field<int>("Id"),
                    NomeDaRua = item.Field<string>("NOME_DA_RUA"),
                    Bairro = item.Field<string>("BAIRRO"),
                    Cidade = item.Field<string>("CIDADE"),
                    Estado = item.Field<string>("ESTADO"),
                    Cliente = cliente
                });
            }
            bancoDeDados.FecharConexao();

            return enderecos;
        }
        public List<Endereco> Listar()
        {
            return  Listar("SELECT * FROM ENDERECO");
        }

        public void Remove(Endereco objeto)
        {
            bancoDeDados.Conectar();
            bancoDeDados.Executar($"DELETE FROM ENDERECO WHERE ID={objeto.Id}");
            bancoDeDados.FecharConexao();
        }

        public void Update(Endereco objeto)
        {
            bancoDeDados.Conectar();
            bancoDeDados.Executar($"UPDATE ENDERECO SET BAIRRO='{objeto.Bairro}',CIDADE='{objeto.Cidade}',ESTADO='{objeto.Estado}',NOME_DA_RUA='{objeto.NomeDaRua}' WHERE ID={objeto.Id}");
            bancoDeDados.FecharConexao();
        }
    }

}