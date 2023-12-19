using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Demo_Manish.DataLayer

{
    public class DapperOrm :IDapperOrm
    {
        private readonly IConfiguration _configuration;
        public DapperOrm(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IEnumerable<T> Returnlist<T, U>(string procedurName, U param)
        {
            using (IDbConnection sqlCon = new SqlConnection(_configuration.GetConnectionString("conn")))
            {
                return sqlCon.Query<T>(procedurName, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
