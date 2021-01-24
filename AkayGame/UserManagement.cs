using System;
using System.Collections.Generic;
using System.Text;

namespace AkayGame
{
    class UserManagement : IProjectInterface
    {
        private string userName;
        public UserManagement(Users user)
        {
            userName = user.UserName;
        }
        public void Add()
        {
            Console.WriteLine(userName+" isimli kullanıcı eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine(userName + " isimli kullanıcı hesabı silindi.");
        }

        public void Update()
        {
            Console.WriteLine(userName + " isimli kullanıcı hesabı güncellendi.");
        }
    }
}
