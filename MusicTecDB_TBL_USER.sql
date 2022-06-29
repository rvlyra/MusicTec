CREATE DATABASE MusicTecDB
GO
USE MusicTecDB

GO
CREATE TABLE tbl_User(
Id int primary key identity,
UserName varchar(255)
)

SELECT * FROM tbl_User

GO 
CREATE PROCEDURE SaveUser
(
@UserName varchar(255)
)

AS

BEGIN
INSERT INTO tbl_User VALUES (@UserName)
END

GO

CREATE PROCEDURE ListAll
AS
BEGIN
SELECT * FROM tbl_User
END

GO

CREATE PROCEDURE UpdateAll
(
@UserName varchar(255),
@Id int
)
AS
BEGIN
UPDATE tbl_User set UserName = @UserName where Id = @Id
END

GO


CREATE PROCEDURE DeleteAll
(
@Id int
)
AS
BEGIN
DELETE FROM tbl_User where Id = @Id
END

GO


CREATE PROCEDURE GetById
(
@Id int
)
AS
BEGIN
SELECT * FROM tbl_User where Id = @Id
END