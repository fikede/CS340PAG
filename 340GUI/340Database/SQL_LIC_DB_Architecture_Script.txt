/*
 * This is the script for SQL Database for 340 PAG System. 
 * NOTE:
 * https://docs.microsoft.com/en-us/sql/t-sql/tutorial-writing-transact-sql-statements
 * https://blogs.msdn.microsoft.com/sqlserverstorageengine/2015/11/03/drop-if-exists-new-thing-in-sql-server-2016/
 * https://docs.microsoft.com/en-us/sql/t-sql/statements/drop-table-transact-sql
 * Use this Links for all commands.
 */

CREATE DATABASE LICDatabase
GO

/*
 * After the DB exists, use the following commands.
 */

USE LICDatabase
GO


CREATE TABLE Department
(
name varchar(50)
CONSTRAINT PK_Department PRIMARY KEY(name)
)

CREATE TABLE Employee
(
ID varchar (20),
first_name varchar(100),
last_name varchar(100),
username varchar(20),
password_hashed binary(225),
usertype char,
department varchar(50),
CONSTRAINT PK_Employee PRIMARY KEY(ID),
CONSTRAINT FK_Employee_department FOREIGN KEY(department)
	REFERENCES Department(name),
CONSTRAINT UNIQUE_employee_username UNIQUE(username),
CONSTRAINT CHECK_employee_usertype CHECK(usertype = 'A' OR usertype = 'M')
)

CREATE TABLE PolicyHolder
(
ID varchar (20),
first_name varchar(100),
last_name varchar(100),
street varchar(30),
city varchar(20),
[state] char(2),
zip char(9),
CONSTRAINT PK_PolicyHolder PRIMARY KEY(ID),
)

CREATE TABLE Policy
(
[number] varchar(30),
holderID varchar(20),
emp_ID varchar(20),
holder_dateofbirth date,
fathers_age_at_death decimal(5,2), -- months/12
mothers_age_at_death decimal(5,2), -- months/12
cigs_per_day int,
smoking_history decimal(5,2), -- months/12
systolic_blood_pressure boolean,
average_grams_fat_per_day int,
heart_disease boolean,
cancer boolean,
hospitalized boolean,
dangerous_activities varchar(255),
start_date date,
end_date date,
payoff_amount decimal(8,2),
monthly_premium decimal(8,2),
beneficiary_first_name varchar(100),
beneficiary_last_name varchar(100),
CONSTRAINT PK_Policy PRIMARY KEY(policynumber),
CONSTRAINT FK_Policy_PolicyHolder FOREIGN KEY(holderID)
	REFERENCES PolicyHolder(ID),
CONSTRAINT FK_Policy_Employee FOREIGN KEY(emp_ID)
	REFERENCES Employee(ID),
)

CREATE TABLE Payment
(
policynumber varchar(30),
[date] datetime,
[type] char,
amount decimal (8,2),
CONSTRAINT PK_Payment PRIMARY KEY(policynumber, [date]),
CONSTRAINT FK_Payment_Policy FOREIGN KEY(policynumber)
	REFERENCES Policy([number]),
CONSTRAINT CHECK_description CHECK([type] = 'P' OR [type] = 'C')
)

CREATE TABLE Delinquent_Accounts_Parameters
(
emp_ID varchar (20),
date_generated datetime,
[state] char(2),
amount_overdue decimal(8,2),
CONSTRAINT PK_Delinquent_Accounts_Parameters PRIMARY KEY(emp_ID),
CONSTRAINT FK_Delinquent_Accounts_Parameters_Employee FOREIGN KEY(ID)
	REFERENCES Employee(ID)
)