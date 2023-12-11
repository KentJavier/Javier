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

    public enum UserRole
    {
        Admin = 1,
        Staff = 2,
        Member = 3
    }   

    public class UserRepository
    {
        public ErrorCode Register(string FirstName, string LastName, string Email, string Username, string Password, DateTime RegistrationDate, int RoleId)
        {
            try
            {
                Console.WriteLine($"User Details: FirstName={FirstName}, LastName={LastName}, Email={Email}, Username={Username}, Password={Password}, RegistrationDate={RegistrationDate}, RoleId={RoleId}");

                using (var db = new LibrarySystemEntities())
                {
                    switch (RoleId)
                    {
                        case (int)UserRole.Admin: // Admin
                            var newAdmin = new Admins();
                            newAdmin.AdminFirstName = FirstName;
                            newAdmin.AdminLastName = LastName;
                            newAdmin.AdminEmail = Email;
                            newAdmin.AdminUsername = Username;
                            newAdmin.AdminPassword = Password;
                            newAdmin.AdminRegistrationDate = RegistrationDate;
                            newAdmin.RoleId = RoleId;

                            db.Admins.Add(newAdmin);
                            break;

                        case (int)UserRole.Staff: // Staff
                            var newStaff = new Staffs();
                            newStaff.StaffFirstName = FirstName;
                            newStaff.StaffLastName = LastName;
                            newStaff.StaffEmail = Email;
                            newStaff.StaffUsername = Username;
                            newStaff.StaffPassword = Password;
                            newStaff.StaffRegistrationDate = RegistrationDate;
                            newStaff.RoleId = RoleId;

                            db.Staffs.Add(newStaff);
                            break;

                        case (int)UserRole.Member: // Member
                            var newMember = new Members();
                            newMember.MemberFirstName = FirstName;
                            newMember.MemberLastName = LastName;
                            newMember.MemberEmail = Email;
                            newMember.MemberUsername = Username;
                            newMember.MemberPassword = Password;
                            newMember.MemberRegistrationDate = RegistrationDate;
                            newMember.RoleId = RoleId;

                            db.Members.Add(newMember);
                            break;

                        default:
                            return ErrorCode.Error;
                    }

                    db.SaveChanges();
                    Console.WriteLine("User successfully registered.");
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                return ErrorCode.Error;
            }
        }
    }
}
