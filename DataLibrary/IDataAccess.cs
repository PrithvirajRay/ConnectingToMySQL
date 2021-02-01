using ImTools;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IDataAccess
    {
        List<T> LoadData<T, U> (string sql, U parameters, string connectionString);
        
        Task SaveData<T>(string sql, T parameters, string connectionString);
      
    }
}