using System;
using System.Collections.Generic;
using System.Text;

namespace NT.Models
{
    public class UserInfoSerialize : UsersDbEntity
    {
        public string RolesGroupName { get; set; }
        public string RolesGroupId { get; set; }
    }
}
