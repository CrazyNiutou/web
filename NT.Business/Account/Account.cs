using NT.IBusiness;
using NT.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using Dapper;
using System.Collections.Generic;

namespace NT.Business
{
    public class Account : IAccount
    {
        private MySqlOperator Operator;
        public Account(System.IServiceProvider provider)
        {
            this.Operator = provider.GetService<MySqlOperator>();
        }

        public async Task<List<UserInfoSerialize>> GetUsersInfo(string userName, string pwd)
        {
            var sql = string.Format(@"select A.*,C.RolesGroupName,C.RolesGroupId from users A
                inner join rolesgroupdtl B on B.UserId=A.UserId
                INNER JOIN rolesgroup C on C.RolesGroupId=B.RolesGroupId
                    where A.UserNumber='{0}' AND A.`PassWord`='{1}' ", userName, pwd);
            List<UserInfoSerialize> returnEntity = null;
            using (var conn = Operator.GetMySqlDbConnection())
            {
                returnEntity = conn.Query<UserInfoSerialize>(sql).AsList<UserInfoSerialize>();
            }
            await Task.Delay(0);
            return returnEntity;
        }
    }
}
