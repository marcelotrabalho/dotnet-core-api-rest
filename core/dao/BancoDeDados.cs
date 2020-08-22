using System.Data;
using Interface;

namespace Dao
{
    ///Esta classe é responsável por conectar no banco de dados Sql e executar uma instrução no     
    ///Banco Sql Server
    ///No futuro se precisar conectar em outro banco, só criar outra classe de conexão neste banco
    public class BancoDeDados : Interface.IBancoDeDados
    {

        public BancoDeDados(IStringconexao dadosConexao)
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