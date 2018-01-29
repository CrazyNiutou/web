using NT.IBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace NT.Business
{
    public class Account : IAccount
    {
        

        public async Task<string> Test()
        {
            await Task.Delay(0);
            return null;
        }
    }
}
