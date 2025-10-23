create database st
use st

drop table student1
create table student1(id int primary key,names varchar(50),mark1 int ,mark2 int ,mark3 int,DOB date)

insert into student1 values(1,'Kunal',85,86,88,'2002-10-07'),(2,'Abhi',88,89,96,'2003-12-09'),(3,'Shi',88,59,69,'2002-11-06'),(4,'adi',89,98,69,'2003-01-07')
insert into student1 values(5,'jindal',33,58,69,'2003-11-09')
insert into student1 values(6,'jind',32,59,96,'2025-10-01')
select *from student1 where mark1>35 and mark2>35 and mark3>35 

select *from student1 where DOB between '2002-01-01' and '2002-12-30'

select *from student1 where mark1<35 or mark2<35 or mark3<35 
select *from student1 where names='kunal'
select *from student1 where names='kunal' or names='jindal'
select *from student1 where names in ('kunal','jindal')
select *from student1 where month(DOB) between 10 and 12;
select *from student1 where day(DOB) between 1 and 12;

select *from student1 where year(DOB)=2002;

SELECT *
FROM student1
WHERE DATEDIFF(day, DOB, GETDATE()) < 10;

select dateadd(month,-2,'2025-10-09') as two

select day(getdate()) as dates  

select DATEPART(day,getdate()) as days

select isdate('2002-02-28') as dates

select upper(names) from student1

select lower(names) from student1

select len(names) from student1

select CONCAT(names,'-','1') from student1

select trim('   hello   ')

select CHARINDEX('kunal','jindalkunal')

select replace('kunal is bad boy','bad','good')

select left(names,2) from student1
select right(names,3) from student1


select ltrim('   hello   ')

select rtrim('   hello   ')

select SUBSTRING(names,2,3) from student1

SELECT value
FROM STRING_SPLIT('apple,orange,banana', ',');

select *from student1 where names like '%ind%'

select *from student1 where names like 'k___l'


select format(getdate(),'yyyy-MM-dd') 

SELECT CONCAT(names, ' has scored ', mark1 + mark2 + mark3) as performance
FROM student1  ;

select right(replicate(1,10) + 1234,85)

SELECT CONVERT(INT, REPLICATE(1, 10)) + 1234;

select replace(names,substring(names,2,4),'na') from student1
select avg(mark1) as mark1avg from student1

SELECT REPLACE(STR(1234, 7), ' ', '0');

select top 2*from student1

--This will find rows that are not all digits but won't catch null or empty--
select *from student1
where mark1 like '%[^0-9]%'


select min(mark1) from student1
select max(mark1) from student1
select avg(mark1) from student1
select sqrt(max(mark1)) from student1

select square(min(mark1)) from student1
select abs(-3) 
select power(2,10)
select least(

alter table student1
add  greatest_no int

select *from student1

update student1 set greatest_no = greatest(mark1,mark2,mark3) from student1 where greatest_no is null

SELECT REPLACE(CONVERT(varchar(10), GETDATE(), 101), '/', '');

create table student2(id int primary key,names varchar(50) ,mark1 int,mark2 int,mark3 int,DOB date);

select *from student2

insert into student2
select id,names,mark1,mark2,mark3,DOB from student1

select id,names into student3 from student2 

select *from student3

alter table student1
add  total int


select *from student1

update student1 set total = mark1 +mark2 + mark3 from student1 where total is null

alter table student1
add average int 

update student1 set average = (mark1 +mark2 + mark3)/3 from student1 where average is null

alter table student1
add  grades varchar(10)

UPDATE student1
SET grades = (
    CASE
        WHEN average > 90 THEN 'A'
        WHEN average BETWEEN 70 AND 89 THEN 'B'
        ELSE 'Pass'
    END
);

select *from student1 order by average desc

select grades,count(*) from student1 group by grades having grades='Pass';

select avg(average) as groupbyavg from student1 group by grades;

select max(total) as max_total from student1 group by grades
select min(total) as min_total from student1 group by grades

select avg(average) as groupbyavg from student1 group by grades having avg(average)>70;

select grades,count(*) from student1 group by grades,greatest_no


drop table Employees
-- Create the table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Salary DECIMAL(10, 2) NOT NULL,
    DepartmentID INT unique,
    dates DATE DEFAULT GETDATE(),
    CONSTRAINT CHK_Salary_Positive CHECK (Salary > 0)
);

-- Insert rows with explicit dates
INSERT INTO Employees VALUES(1,'kunal','jindal','jindal06@gmail.com',85200,101,'2025-10-11');
INSERT INTO Employees VALUES(2,'Adit','jindal','aditi06@gmail.com',88000,102,'2025-01-04');
INSERT INTO Employees VALUES(3,'rohit','jain','jainrohit01@gmail.com',85100,103,'2024-10-25');

-- To use the default date, omit the column from the INSERT statement
INSERT INTO Employees (EmployeeID, FirstName, LastName, Email, Salary, DepartmentID) 
VALUES(4,'amit','jain','amitrohit01@gmail.com',851000,104);

-- Select all data from the table
SELECT * FROM Employees;



select *from sys.objects

select *from sys.indexes

select *from sys.check_constraints

select *from sys.default_constraints

select *from sys.foreign_keys

select *from sys.key_constraints

drop table department

create table department(id int primary key ,department_name varchar(50),DepartmentID int foreign key references Employees(DepartmentID))

insert into department values (11,'Data Engineer',101),(12,'SDE',102),(13,'Marketing',103),(14,'hr',104)

select *from sys.foreign_keys

select *from department

alter table Employees
drop constraint CHK_Salary_Positive