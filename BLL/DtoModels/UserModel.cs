using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DtoModels
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }//** ?Int Id
    }
}
