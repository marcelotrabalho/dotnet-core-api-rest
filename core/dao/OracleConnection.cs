using System.Data;
using Interface;
using System.ComponentModel.DataAnnotations;

namespace Dao
{
    ///Esta classe é responsável por conectar no banco de dados oracle e executar uma instrução no     
    ///Banco oracle
    public class OracleConnection : Interface.IBancoDeDados
    {

        public OracleConnection(string servidor, string banco, string usuario, string senha)
        {
            throw new System.NotImplementedException();   
        }

        public void Conectar()
        {
            throw new System.NotImplementedException();
        }

        public void Executar(string instrucaoSql)
        {
            throw new System.NotImplementedException();
        }

        public void FecharConexao()
        {
            throw new System.NotImplementedException();
        }

        public DataSet Listar(string instrucaoSelect)
        {
            throw new System.NotImplementedException();
        }
    }

}