using System.Data;
using System.Data.SQLite;

namespace Dao
{
    public class SqliteCnnection : Interface.IBancoDeDados
    {
        public readonly string caminhoDoBanco;
        public SQLiteConnection conexao =null;

        public SqliteCnnection(string caminhoENomeArquivo)
        {
            caminhoDoBanco = caminhoENomeArquivo;
        }
        public void Conectar()
        {
            if (conexao == null || conexao.State == ConnectionState.Closed)
            {
                conexao = new SQLiteConnection($"Data Source ='{caminhoDoBanco}'");
                conexao.Open();    
            }
            
        }

        public void Executar(string instrucaoSql)
        {
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = instrucaoSql;
                cmd.ExecuteNonQuery();
            }
            
        }

        public void FecharConexao()
        {
            if (conexao.State == ConnectionState.Open )
            {
                conexao.Close();
            }
            
        }

        public DataSet Listar(string instrucaoSelect)
        {
            DataSet ds = new DataSet();
            using (var dataAdapter = new SQLiteDataAdapter(instrucaoSelect,conexao))
            {
                dataAdapter.Fill(ds);
            }
            return ds;
        }
    }
}