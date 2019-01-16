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
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        //构造函数
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserInfo> GetUserList()
        {
            List<UserInfo> users = _userRepository.GetUserList();

            return users;
        }

        public int AddUser(UserInfo user)
        {
            int result = _userRepository.AddUser(user);

            return result;
        }

        public int DeleteUser(int id)
        {
            int result = _userRepository.DeleteUser(id);
            return result;
        }

        public int UpdateUser(UserInfo user)
        {
            int result = _userRepository.UpdateUser(user);
            return result;
        }

        public int BatchDeleteUsers(List<int> ids)
        {
            int result = _userRepository.BatchDeleteUsers(ids);
            return result;
        }
    }
}
