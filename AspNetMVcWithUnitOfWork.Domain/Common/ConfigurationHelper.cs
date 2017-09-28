using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AspNetMvcWithUnitOfWork.Domain.Common
{
    public class ConfigurationHelper
    {
        internal IDbConnection DbConnection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["DapperDbConnectingString"].ConnectionString);
            }
        }
    }
}
