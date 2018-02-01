using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NT.IBusiness
{
    public interface IAccount
    {
        Task<string> GetUsersInfo(string userName, string pwd);
    }
}
