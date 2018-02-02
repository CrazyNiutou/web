﻿using NT.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NT.IBusiness
{
    public interface IAccount
    {
        Task<List<UserInfoSerialize>> GetUsersInfo(string userName, string pwd);
    }
}
