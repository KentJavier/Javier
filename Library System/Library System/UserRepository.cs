using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_System.AppData;

namespace Library_System
{
    public enum ErrorCode 
    {
        Error,
        Success
    }
    public class UserRepository
    {
        public ErrorCode Register(String fname, String lname, String username, String password, String email, String contactNum) 
        {
            try
            {
                using (var db = new db_LibSysEntities())
                {

                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error "+ex.Message);
                return ErrorCode.Error;
            }

        }
    }
}
