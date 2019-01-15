using Own.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.Interface.Repositories
{
    public interface IStudentRepository
    {
        string GetStudentName(int id);

        int GetStudentAge(int id);

        DateTime GetBirthDay(string name);

        Student GetStudentInfo(int id);

        List<UserInfo> GetUserList();

        int AddUser(UserInfo user);

        int DeleteUser(int id);

        int UpdateUser(UserInfo user);

        int BatchDeleteUsers(List<int> ids);
    }
}
