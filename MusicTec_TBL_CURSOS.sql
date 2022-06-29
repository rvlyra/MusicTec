USE MusicTecDB

GO
CREATE TABLE tbl_Course(
CourseId int primary key identity,
C_Title varchar(25) NOT NULL,  
C_Price money NULL,  
C_Description varchar(max) NULL)  
)

SELECT * FROM tbl_Course





Refer:

https://docs.microsoft.com/pt-br/sql/t-sql/lesson-1-creating-database-objects?view=sql-server-ver16