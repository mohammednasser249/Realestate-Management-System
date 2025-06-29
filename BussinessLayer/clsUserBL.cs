using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsUserBL
    {
      public  enum enMode { AddNew = 0, UpdateNew = 1 }

        public enMode Mode;
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool IsActive {  get; set;  }


        public clsUserBL()
        {
            UserId = -1;
            UserName= string.Empty;
            UserPassword = string.Empty;
            IsActive = false;

            Mode = enMode.AddNew;
        }

        public clsUserBL(int  userId, string username , string userpassword,bool isactive)
        {
            UserId = userId;
            UserName = username;
            UserPassword = userpassword;
            IsActive = isactive;
            Mode = enMode.UpdateNew;
        }

        public static clsUserBL Find(int userId)
        {
            string username = string.Empty;
            string userpassword = string.Empty; 
            bool isactive = false;

            if(clsUserDL.GetUserByUserID(userId,ref username,ref userpassword,ref isactive))
            {
                return new clsUserBL(userId,username,userpassword,isactive);
            }
            return null;
                
        }

        public static clsUserBL Find(string userName,string password)
        {

            int userId = -1;
            bool isactive = false;
            if(clsUserDL.GetUserByUserNameAndPassword(userName,password,ref userId,ref isactive))
            {
                return new clsUserBL(userId,userName, password, isactive);
            }
            return null;

        }


    }
}
