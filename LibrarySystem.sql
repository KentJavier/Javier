CREATE DATABASE LibrarySystem

USE LibrarySystem
/* To reset the Id of the following tables below */
DBCC CHECKIDENT ('Admins', RESEED, 0);
DBCC CHECKIDENT ('Staffs', RESEED, 0);
DBCC CHECKIDENT ('Members', RESEED, 0);
DBCC CHECKIDENT ('Books', RESEED, 0);

/* View */
-- To view Admins table
CREATE VIEW vwAdmins
AS
SELECT
	AdminId,
	AdminFirstName,
	AdminLastName,
	AdminEmail,
	AdminUsername,
	AdminPassword,
	AdminRegistrationDate
FROM
	Admins

-- To view Staffs table
CREATE VIEW vwStaffs
AS
SELECT
	StaffId,
	StaffFirstName,
	StaffLastName,
	StaffEmail,
	StaffUsername,
	StaffPassword,
	StaffRegistrationDate
FROM
	Staffs

--To view Members table
CREATE VIEW vwMembers
AS
SELECT
	MemberId,
	MemberFirstName,
	MemberLastName,
	MemberEmail,
	MemberUsername,
	MemberPassword,
	MemberRegistrationDate
FROM
	Members	

/* Store Procedure */

-- Insert values into Admins table
CREATE PROCEDURE spInsertAdmin
(
	@AdminFirstName varchar(50),
	@AdminLastName varchar(50),
	@AdminEmail varchar(50),
	@AdminUsername varchar(50),
	@AdminPassword varchar(50),
	@AdminRegistrationDate datetime,
	@RoleId int
)
AS
BEGIN
	INSERT INTO Admins(AdminFirstName, AdminLastName, AdminEmail, AdminUsername, AdminPassword, AdminRegistrationDate, RoleId)
	VALUES (@AdminFirstName, @AdminLastName, @AdminEmail, @AdminUsername, @AdminPassword, @AdminRegistrationDate, @RoleId);
END

-- To delete values into Admins table
CREATE PROCEDURE spDeleteAdmin
    @AdminID int
AS
BEGIN 
    DELETE FROM Admins
    WHERE AdminID = @AdminID;
END;

-- To update current values inside the Admins table
CREATE PROCEDURE spUpdateAdmin
    @AdminID int,
    @AdminFirstName varchar(50),
    @AdminLastName varchar(50),
    @AdminEmail varchar(50),
    @AdminUsername varchar(50),
    @AdminPassword varchar(50),
    @AdminRegistrationDate datetime
AS
BEGIN
    UPDATE Admins
    SET
        AdminFirstName = @AdminFirstName,
        AdminLastName = @AdminLastName,
        AdminEmail = @AdminEmail,
        AdminUsername = @AdminUsername,
        AdminPassword = @AdminPassword,
        AdminRegistrationDate = @AdminRegistrationDate
    WHERE AdminID = @AdminID;
END;