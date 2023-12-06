using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp.Model
{
    public class UserAccountModel
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }

        public string DisplayEmail { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
