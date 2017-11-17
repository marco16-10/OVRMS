using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVRMS
{
    public sealed class User
    {
        private static readonly User instance = new User();

        private User() { }

        public static User Instance
        {
            get
            {
                return instance;
            }
        }

        public string UserFullName { get; set; }
        public int UserID { get; set; }
        public int IdUserRole { get; set; }

    }

}
