﻿using Own.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.Interface.Services
{
    public interface IUserService
    {
        List<UserInfo> GetUserList();

        int AddUser(UserInfo user);

        int DeleteUser(int user);

        int UpdateUser(UserInfo user);

        int BatchDeleteUsers(List<int> ids);
    }
}
