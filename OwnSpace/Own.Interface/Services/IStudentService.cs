using Own.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.Interface.Services
{
    public interface IStudentService
    {
        int GetStudentAge(int id);

        string GetStudentName(int id);

        DateTime GetBirthDay(string name);

        Student GetStudentInfo(int id);

        List<UserInfo> GetUserList();

        int AddUser(UserInfo user);
    }
  
}
