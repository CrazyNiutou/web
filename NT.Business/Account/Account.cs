using Dapper;
using Microsoft.Extensions.DependencyInjection;
using NT.IBusiness;
using NT.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NT.Business
{
    public class Account : IAccount
    {
        private MySqlOperator Operator;

        public Account(System.IServiceProvider provider)
        {
            this.Operator = provider.GetService<MySqlOperator>();
        }

        public async Task<UsersDbEntity> GetUsersInfo(string userName, string pwd)
        {
            var sql = $@"SELECT
	                            *
                            FROM
	                            users AS A
                            WHERE
	                            A.UserName = '{userName}'
                            AND A.`PassWord` = '{pwd}' ";
            UsersDbEntity returnEntity = null;
            using (var conn = Operator.GetMySqlDbConnection())
            {
                returnEntity = conn.QueryFirst<UsersDbEntity>(sql);
            }
            await Task.Delay(0);
            return returnEntity;
        }
    }
}