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
        None,
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

        public bool Authentication(string username, string password, out UserRole role)
        {
            try
            {
                using (var db = new LibrarySystemEntities())
                {
                    var admin = db.Admins.FirstOrDefault(a => a.AdminUsername == username && a.AdminPassword == password);
                    if (admin != null)
                    {
                        role = UserRole.Admin;
                        return true;
                    }

                    var staff = db.Staffs.FirstOrDefault(s => s.StaffUsername == username && s.StaffPassword == password);
                    if (staff != null)
                    {
                        role = UserRole.Staff;
                        return true;
                    }

                    var member = db.Members.FirstOrDefault(m => m.MemberUsername == username && m.MemberPassword == password);
                    if (member != null)
                    {
                        role = UserRole.Member;
                        return true;
                    }

                    role = UserRole.None;
                    return false;
                }
            }
            catch (Exception)
            {
                role = UserRole.None;
                return false;
            }
        }
    }
}
