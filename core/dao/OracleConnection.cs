using System.Data;
using Interface;
using System.ComponentModel.DataAnnotations;

namespace Dao
{
    ///Esta classe é responsável por conectar no banco de dados Sql e executar uma instrução no     
    ///Banco Sql Server
    ///No futuro se precisar conectar em outro banco, só criar outra classe de conexão neste banco
    public class OracleConnection : Interface.IBancoDeDados
    {

        public OracleConnection(string servidor, string banco, string usuario, string senha)
        {
            throw new System.NotImplementedException();   
        }
        public void Executar(string instrucaoSql)
        {
            throw new System.NotImplementedException();
        }

        public DataSet Listar(string instrucaoSelect)
        {
            throw new System.NotImplementedException();
        }
    }

}