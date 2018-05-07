-- This is the script for SQL Database for 340 PAG System. 
-- NOTE:
-- https://docs.microsoft.com/en-us/sql/t-sql/tutorial-writing-transact-sql-statements
-- https://blogs.msdn.microsoft.com/sqlserverstorageengine/2015/11/03/drop-if-exists-new-thing-in-sql-server-2016/
-- https://docs.microsoft.com/en-us/sql/t-sql/statements/drop-table-transact-sql
-- Use this Links for all commands.

--CREATE DATABASE LIC_PAG

USE LIC_PAG
GO

CREATE TABLE Department
(
name varchar(50)
CONSTRAINT PK_Department PRIMARY KEY(name)
)

CREATE TABLE Employee
(
ID varchar(20),
first_name varchar(100),
last_name varchar(100),
username varchar(20),
password_hashed varchar(255),
user_type char,
department varchar(50),
CONSTRAINT PK_Employee PRIMARY KEY(ID),
CONSTRAINT FK_Employee_department FOREIGN KEY(department)
	REFERENCES Department(name),
CONSTRAINT UNIQUE_employee_username UNIQUE(username),
CONSTRAINT CHECK_employee_user_type CHECK(user_type = 'A' OR user_type = 'M')
)

CREATE TABLE PolicyHolder
(
ID varchar(20),
first_name varchar(100),
last_name varchar(100),
street varchar(30),
city varchar(20),
[state] char(2),
zip char(9),
CONSTRAINT PK_PolicyHolder PRIMARY KEY(ID),
)

CREATE TABLE [Policy]
(
[number] varchar(30),
holder_ID varchar(20),
emp_ID varchar(20),
holder_DOB date,
fathers_age_at_death decimal(5,2), -- months/12
mothers_age_at_death decimal(5,2), -- months/12
cigs_per_day int,
smoking_history decimal(5,2), -- months/12
systolic_blood_pressure int,
average_grams_fat_per_day int,
heart_disease int, -- boolean value representation
cancer int, -- boolean value representation
hospitalized int, -- boolean value representation
dangerous_activities varchar(255),
start_date date,
end_date date,
payoff_amount decimal(10,2),
monthly_premium decimal(10,2),

CONSTRAINT PK_Policy PRIMARY KEY([number]),
CONSTRAINT FK_Policy_PolicyHolder FOREIGN KEY(holder_ID)
	REFERENCES PolicyHolder(ID),
CONSTRAINT FK_Policy_Employee FOREIGN KEY(emp_ID)
	REFERENCES Employee(ID),
CONSTRAINT CHECK_heart_disease CHECK(heart_disease = 0 OR heart_disease = 1),
CONSTRAINT CHECK_cancer CHECK(cancer = 0 OR cancer = 1),
CONSTRAINT CHECK_hospitalized CHECK(hospitalized = 0 OR hospitalized = 1)
)

CREATE TABLE Payment
(
policy_number varchar(30),
[date] datetime,
[type] char,
amount decimal(10,2),
CONSTRAINT PK_Payment PRIMARY KEY(policy_number, [date]),
CONSTRAINT FK_Payment_Policy FOREIGN KEY(policy_number)
	REFERENCES [Policy]([number]),
CONSTRAINT CHECK_description CHECK([type] = 'P' OR [type] = 'C')
)

CREATE TABLE Delinquent_Accounts_Parameters
(
emp_ID varchar(20),
date_generated datetime,
[state] char(2),
amount_overdue decimal(10,2),
CONSTRAINT PK_Delinquent_Accounts_Parameters PRIMARY KEY(emp_ID),
CONSTRAINT FK_Delinquent_Accounts_Parameters_Employee FOREIGN KEY(emp_ID)
	REFERENCES Employee(ID)
)

CREATE TABLE Beneficiary
(
policy_number varchar(30),
first_name varchar(100),
last_name varchar(100),
CONSTRAINT PK_Beneficiary PRIMARY KEY(policy_number, first_name, last_name),
CONSTRAINT FK_Beneficiary FOREIGN KEY(policy_number)
	REFERENCES Policy([number])
)

CREATE TABLE USInflation
(
month_name varchar(10),
month_number int,
[year] varchar(4),
[value] decimal(6,3),
CONSTRAINT PK_USInflation PRIMARY KEY([month_name], month_number, [year])
)