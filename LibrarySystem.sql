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

-- To view Books Table
CREATE VIEW vwBooks
AS
SELECT
    BookId,
    BookTitle,
    AuthorName,
    BookGenre,
    BookCopies
FROM
    Books;

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
(
    @AdminID int
)
AS
BEGIN 
    DELETE FROM Admins
    WHERE AdminID = @AdminID;
END;

-- To update current values inside the Admins table
CREATE PROCEDURE spUpdateAdmin
(
    @AdminID int,
    @AdminFirstName varchar(50),
    @AdminLastName varchar(50),
    @AdminEmail varchar(50),
    @AdminUsername varchar(50),
    @AdminPassword varchar(50),
    @AdminRegistrationDate datetime
)
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

-- Insert values in the Staffs table
CREATE PROCEDURE spInsertStaff
(
	@StaffFirstName varchar(50),
	@StaffLastName varchar(50),
	@StaffEmail varchar(50),
	@StaffUsername varchar(50),
	@StaffPassword varchar(50),
	@StaffRegistrationDate datetime,
	@RoleId int
)
AS
BEGIN
	INSERT INTO Staffs(StaffFirstName, StaffLastName, StaffEmail, StaffUsername, StaffPassword, StaffRegistrationDate, RoleId)
	VALUES (@StaffFirstName, @StaffLastName, @StaffEmail, @StaffUsername, @StaffPassword, @StaffRegistrationDate, @RoleId);
END

-- To delete values in the Staffs table
CREATE PROCEDURE spDeleteStaff
(
	@StaffID int
)
AS
BEGIN
	DELETE FROM Staffs
    WHERE StaffID = @StaffID;
END

-- To update current values inside the Staffs table
CREATE PROCEDURE spUpdateStaff
(
    @StaffID int,
    @StaffFirstName varchar(50),
	@StaffLastName varchar(50),
	@StaffEmail varchar(50),
	@StaffUsername varchar(50),
	@StaffPassword varchar(50),
	@StaffRegistrationDate datetime
)
AS
BEGIN
    UPDATE Staffs
    SET
		StaffFirstName = @StaffFirstName,
		StaffLastName = @StaffLastName,
        StaffEmail = @StaffEmail,
        StaffUsername = @StaffUsername,
        StaffPassword = @StaffPassword,
        StaffRegistrationDate = @StaffRegistrationDate
    WHERE StaffID = @StaffID;
END;

-- To insert values into the Members table
CREATE PROCEDURE spInsertMember
(
	@MemberFirstName varchar(50),
	@MemberLastName varchar(50),
	@MemberEmail varchar(50),
	@MemberUsername varchar(50),
	@MemberPassword varchar(50),
	@MemberRegistrationDate datetime,
	@RoleId int
)
AS
BEGIN
	INSERT INTO Members(MemberFirstName, MemberLastName, MemberEmail, MemberUsername, MemberPassword, MemberRegistrationDate, RoleId)
	VALUES (@MemberFirstName, @MemberLastName, @MemberEmail, @MemberUsername, @MemberPassword, @MemberRegistrationDate, @RoleId);
END

-- To delete values in the Members table
CREATE PROCEDURE spDeleteMember
(
	@MemberID int
)
AS
BEGIN
	DELETE FROM Members
    WHERE MemberID = @MemberID;
END

-- To update current values inside the Members table
CREATE PROCEDURE spUpdateMember
(
    @MemberID int,
    @MemberFirstName varchar(50),
	@MemberLastName varchar(50),
	@MemberEmail varchar(50),
	@MemberUsername varchar(50),
	@MemberPassword varchar(50),
	@MemberRegistrationDate datetime
)
AS
BEGIN
    UPDATE Members
    SET
		MemberFirstName = @MemberFirstName,
		MemberLastName = @MemberLastName,
        MemberEmail = @MemberEmail,
        MemberUsername = @MemberUsername,
        MemberPassword = @MemberPassword,
        MemberRegistrationDate = @MemberRegistrationDate
    WHERE MemberID = @MemberID;
END;

-- To insert values in Books table
CREATE PROCEDURE spInsertBook
(
    @BookTitle varchar(50),
    @AuthorName varchar(50),
    @BookGenre varchar(50),
    @BookCopies int
)
AS
BEGIN
    INSERT INTO Books (BookTitle, AuthorName, BookGenre, BookCopies)
    VALUES (@BookTitle, @AuthorName, @BookGenre, @BookCopies);
END;

-- To delete values
CREATE PROCEDURE spDeleteBook
(
    @BookId int
)
AS
BEGIN
    DELETE FROM Books
    WHERE BookId = @BookId;
END;

-- To update values
CREATE PROCEDURE spUpdateBook
(
    @BookId int,
    @BookTitle varchar(50),
    @AuthorName varchar(50),
    @BookGenre varchar(50),
    @BookCopies int
)
AS
BEGIN
    UPDATE Books
    SET
        BookTitle = @BookTitle,
        AuthorName = @AuthorName,
        BookGenre = @BookGenre,
        BookCopies = @BookCopies
    WHERE
        BookId = @BookId;
END;