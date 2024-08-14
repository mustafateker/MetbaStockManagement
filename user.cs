using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetbStockKontrol
{
    internal class user
    {
        private string UserId;
        private string Name;
        private string Surname;
        private string UserName;
        private string Password;
        private string Email;
        private string PhoneNumber;
        private bool UserStatus;


        public bool UserStatus1 { get => UserStatus; set => UserStatus = value; }
        public string UserId1 { get => UserId; set => UserId = value; }
        public string UserName1 { get => UserName; set => UserName = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
    }
}
