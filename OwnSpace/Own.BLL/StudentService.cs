using Own.DAL;
using Own.Interface.Repositories;
using Own.Interface.Services;
using Own.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.BLL
{
    /// <summary>
    /// 业务逻辑层
    /// </summary>
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<UserInfo> GetUserList()
        {
            List<UserInfo> users = _studentRepository.GetUserList();

            return users;
        }

        public int AddUser(UserInfo user)
        {
            int result = _studentRepository.AddUser(user);

            return result;
        }

        public int DeleteUser(int id)
        {
            int result = _studentRepository.DeleteUser(id);
            return result;
        }

        public int UpdateUser(UserInfo user)
        {
            int result = _studentRepository.UpdateUser(user);
            return result;
        }

        public int BatchDeleteUsers(List<int> ids)
        {
            int result = _studentRepository.BatchDeleteUsers(ids);
            return result;
        }
    }
}
