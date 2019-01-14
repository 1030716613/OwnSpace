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
    }
}
