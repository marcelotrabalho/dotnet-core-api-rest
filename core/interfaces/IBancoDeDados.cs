using System.Data;

namespace Interface
{
    public interface IBancoDeDados
    {
     
        void Conectar();
        void Executar(string instrucaoSql);
        DataSet Listar(string instrucaoSelect);
        void FecharConexao();
    }
    
}