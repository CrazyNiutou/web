using NT.IBusiness;
using NT.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using Dapper;

namespace NT.Business
{
    public class Account : IAccount
    {
        private MySqlOperator Operator;
        public Account(System.IServiceProvider provider)
        {
            this.Operator = provider.GetService<MySqlOperator>();
        }

        public async Task<string> GetUsersInfo(string userName, string pwd)
        { 
            using (IDbConnection connect = Operator.GetMySqlDbConnection())
            {

            }
            await Task.Delay(0);
            return null;
        }
    }
}
