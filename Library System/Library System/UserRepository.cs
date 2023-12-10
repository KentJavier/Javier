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
        public ErrorCode Register(string FirstName, string LastName, string Email, string Username, string Password, DateTime RegistrationDate, int RoleId)
        {
            try
            {
                using (var db = new LibrarySystemEntities())
                {
                    switch (RoleId)
                    {
                        case 1: // Admin
                            var newAdmin = new Admins();
                            newAdmin.AdminFirstName = FirstName;
                            newAdmin.AdminLastName = LastName;
                            newAdmin.AdminEmail = Email;
                            newAdmin.AdminUsername = Username;
                            newAdmin.AdminPassword = Password;
                            newAdmin.AdminRegistrationDate = RegistrationDate;

                            db.Admins.Add(newAdmin);
                            break;

                        case 2: // Member
                            var newMember = new Members();
                            newMember.MemberFirstName = FirstName;
                            newMember.MemberLastName = LastName;
                            newMember.MemberEmail = Email;
                            newMember.MemberUsername = Username;
                            newMember.MemberPassword = Password;
                            newMember.MemberRegistrationDate = RegistrationDate;

                            db.Members.Add(newMember);
                            break;

                        case 3: // Staff
                            var newStaff = new Staffs();
                            newStaff.StaffFirstName = FirstName;
                            newStaff.StaffLastName = LastName;
                            newStaff.StaffEmail = Email;
                            newStaff.StaffUsername = Username;
                            newStaff.StaffPassword = Password;
                            newStaff.StaffRegistrationDate = RegistrationDate;

                            db.Staffs.Add(newStaff);
                            break;

                        default:
                            return ErrorCode.Error;
                    }

                    db.SaveChanges();
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return ErrorCode.Error;
            }
        }
    }
}
