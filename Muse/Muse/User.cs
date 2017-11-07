using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse
{
    class User
    {
        private int userID;
        private String userName;

        public User()
        {
            this.userID = -1;
        }

        public User(int userID, String userName)
        {
            this.userID = userID;
            this.userName = userName;
        }

        public int getID()
        {
            return userID;
        }

        public String getUserName()
        {
            return userName;
        }
    }
}
