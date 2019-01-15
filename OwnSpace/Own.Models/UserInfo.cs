using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Own.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserSex { get; set; }
        public int UserStatus { get; set; }
        public int UserGrade { get; set; }
        public DateTime UserEndTime { get; set; }
        public string UserDesc { get; set; }
    }
}