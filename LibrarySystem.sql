CREATE DATABASE LibrarySystem

USE LibrarySystem

/* To reset the Id of the following tables below */
DBCC CHECKIDENT ('Admins', RESEED, 0);
DBCC CHECKIDENT ('Staffs', RESEED, 0);
DBCC CHECKIDENT ('Members', RESEED, 0);
DBCC CHECKIDENT ('Books', RESEED, 0);

/* View */
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

