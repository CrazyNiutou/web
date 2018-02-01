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
            using (var conn = Operator.GetMySqlDbConnection())
            {
                var sql = string.Format(@"select A.*,B.RolesGroupName,C.RolesId,D.RolesName from users A
                    inner join rolesgroup B on B.RolesGroupId=A.RolesGroupId
                    inner join rolesgroupdtl C on C.RolesGroupId=B.RolesGroupId
                    inner join roles D on D.RolesId=C.RolesId
                    where A.UserName='{0}' AND A.`PassWord`='{1}' ", userName, pwd);
                var userInfo = conn.Query<UsersDbEntity>(sql);
            }
            await Task.Delay(0);
            return null;
        }
    }
}
