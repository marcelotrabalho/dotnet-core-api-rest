using System.Data;

namespace Interface
{
    public interface IBancoDeDados
    {
     
        void Executar(string instrucaoSql);
        DataSet Listar(string instrucaoSelect);
    }
    
}