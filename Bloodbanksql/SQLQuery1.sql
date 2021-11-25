create proc usp_InsertIntoStudents (@studentId nvarchar(30),
@name nvarchar(30),
@Mobile numeric(10),
@DateofBirth Date,
@Class nvarchar(30)
)
AS

begin TRY

IF @StudentId is not null and @name is not null
begin
Insert into Student(studentId,name,Mobile,DateofBirth,Class) values(@studentId,@name,@Mobile,@DateofBirth,@Class)
END

else
begin
return -1
end

END TRY

begin catch
return 999
end catch




**********************************************************************************************

create proc usp_InsertIntoAdmin (@AdminId nvarchar(30),@AdminPassword nvarchar(30))
AS

begin TRY

IF @AdminId is not null and @AdminPassword is not null
begin
Insert into Admin(AdminId,AdminPassword) values(@AdminId,@AdminPassword)
END

else
begin
return -1
end

END TRY

begin catch
return 999
end catch


*****************************************************************************************

create proc usp_InsertIntoBooks (@BookId nvarchar(30),
@Bookname nvarchar(30),
@author nvarchar(50),
@type int
)
AS

begin TRY

IF @BookId is not null and @Bookname is not null
begin
Insert into Books(BookId,BookName,Author,typeofbook) values(@BookId,@Bookname,@author,@type)
END

else
begin
return -1
end

END TRY

begin catch
return 999
end catch


*************************************************************************************************

create proc usp_InsertIntoBookType (@typeofbook int,
@typename nvarchar(50)
)
AS

begin TRY

IF @typeofbook is not null and @typename is not null
begin
Insert into BookType(typeofbook,typename) values(@typeofbook,@typename)
END

else
begin
return -1
end

END TRY

begin catch
return 999
end catch


************************************************************************************


create proc usp_InsertIntoIssue (@bookid nvarchar(50),
@Studentid nvarchar(30),
@issuedate Date,
@returndate date
)
AS

begin TRY

IF @StudentId is not null and @bookid is not null
begin
if @studentid not in (select studentid from Student) and @bookid not in (select bookid from books)
begin 
Insert into issue(bookid,studentid,issuedate,returndate) values(@bookid,@studentId,@issuedate,@returndate)
END
else
begin 
return -2
end
end

else
begin
return -1
end

END TRY

begin catch
return 999
end catch



