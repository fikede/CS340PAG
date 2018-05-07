-----------------------------------------------------------------------------------------------------
-- This is the format and commands to create the LIC_PAG SQL stored Procedures.
-- NOTE: If the table names are underlined and SQL states that the object is undefined.
--			Go to: Edit -> IntelliSense -> Refresh Local Cache
-----------------------------------------------------------------------------------------------------

USE LIC_PAG
GO

-----------------------------------------------------------------------------------------------------
-- COMPLETED
-----------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------
-- INSERTION PROCEDURES
-----------------------------------------------------------------------------------------------------

-- Add a department to DB
CREATE PROCEDURE addDepartment @departmentName AS varchar(50)
AS
BEGIN
INSERT INTO	Department(name)
VALUES		(@departmentName)
END
GO

-----------------------------------------------------------------------------------------------------

-- Add a beneficiary to DB
CREATE PROCEDURE addBeneficary @policyNumber AS varchar(30), @firstName AS varchar(100), @lastName AS varchar(100)
AS
BEGIN
INSERT INTO	Beneficiary(policy_number, first_name, last_name)
VALUES		(@policyNumber, @firstName, @lastName)
END
GO

-----------------------------------------------------------------------------------------------------

-- Add an employee to DB
CREATE PROCEDURE addEmployee @employeeID AS varchar(20), @firstName AS varchar(100), @lastName AS varchar(100), @username AS varchar(20), @passwordHashed AS varchar(255), @usertype AS char, @department AS varchar(50)
AS
BEGIN
INSERT INTO	Employee(ID, first_name, last_name, username, password_hashed, user_type, department)
VALUES		(@employeeID, @firstName, @lastName, @username, @passwordHashed, @usertype, @department)
END
GO

-----------------------------------------------------------------------------------------------------

-- Add a policyholder to DB
CREATE PROCEDURE addPolicyHolder @ID AS varchar(30), @firstName AS varchar(100), @lastName AS varchar(100), @street AS varchar(30), @city AS varchar(20), @state AS char(2), @zip AS char(9)
AS
BEGIN
INSERT INTO	PolicyHolder(ID, first_name, last_name, street, city, [state], zip)
VALUES		(@ID, @firstName, @lastName,@street, @city, @state, @zip)
END
GO

-----------------------------------------------------------------------------------------------------

-- Add a policy to DB
CREATE PROCEDURE addPolicy @policyNumber AS varchar(30), @holderID AS varchar(20), @empID AS varchar(20), @holderDOB  AS date, @fatherDeath AS decimal(5,2) = NULL, @motherDeath AS decimal(5,2) = NULL, @cigsPerDay AS int, @smokeHistory AS decimal(5,2) = NULL, @sysBP AS decimal(5,2), @aGramsFat AS int, @heartDisease AS int, @cancer AS int, @hospitalized AS int, @dangerousActivities AS varchar(255), @startDate AS date, @endDate AS date = NULL, @payoffAmount AS decimal(10,2), @monthlyPremium AS decimal(10,2)
AS
BEGIN
INSERT INTO Policy([number], holder_ID, emp_ID, holder_DOB, fathers_age_at_death, mothers_age_at_death, cigs_per_day, smoking_history, systolic_blood_pressure, average_grams_fat_per_day, heart_disease, cancer, hospitalized, dangerous_activities, start_date, end_date, payoff_amount, monthly_premium)
VALUES 		(@policyNumber, @holderID, @empID, @holderDOB, @fatherDeath, @motherDeath, @cigsPerDay, @smokeHistory, @sysBP, @aGramsFat, @heartDisease, @cancer, @hospitalized, @dangerousActivities, @startDate, @endDate, @payoffAmount, @monthlyPremium)
END
GO

-----------------------------------------------------------------------------------------------------

-- Add a payment to DB
CREATE PROCEDURE addPayment @policyNumber AS varchar(30), @paymentDate AS DATETIME, @paymentType AS char, @amount AS decimal(10,2)
AS
BEGIN
INSERT INTO Payment(policy_number, [date], [type], amount)
VALUES		(@policyNumber, @paymentDate, @paymentType, @amount)
END
GO

-----------------------------------------------------------------------------------------------------

-- Add US Dollar Inflation Data
CREATE PROCEDURE addDollarInflation @monthName AS varchar(10), @monthNumber AS int, @year AS varchar(4),@amount AS decimal(6,3)
AS
BEGIN
INSERT INTO USInflation(month_name, month_number, [year], [value])
VALUES 		(@monthName, @monthNumber, @year, @amount)
END
GO

-----------------------------------------------------------------------------------------------------

--Add a Delinquent Account Report
CREATE PROCEDURE createDelinquentAccountReport @ID AS varchar(20), @date AS datetime, @state AS char(2), @amountOverdue AS decimal(10,2)
AS
BEGIN
INSERT INTO Delinquent_Accounts_Parameters(emp_ID, date_generated, [state], amount_overdue)
VALUES (@ID, @date, @state, @amountOverdue)
END
GO

-----------------------------------------------------------------------------------------------------
-- Searching Procedures
-----------------------------------------------------------------------------------------------------

-- Procedure to generate the departments 
CREATE PROCEDURE getDepartments
AS
BEGIN
SELECT * FROM Department
END
GO

-----------------------------------------------------------------------------------------------------

--Procedure for retrieving all policy numbers
CREATE PROCEDURE returnPolicyNumber
AS
BEGIN
SELECT number from Policy
ORDER BY number DESC

END
GO

----------------------------------------------------------------------------------------------------

--Procedure for retrieving all policy holder IDs
CREATE PROCEDURE returnPolicyHolderID
AS
BEGIN
SELECT ID 
FROM PolicyHolder
ORDER BY ID DESC

END
GO

-----------------------------------------------------------------------------------------------------

-- Procedure for retrieving all employee IDs
CREATE PROCEDURE returnEmployeeID
AS
BEGIN
SELECT ID 
FROM Employee
ORDER BY ID DESC

END
GO

-----------------------------------------------------------------------------------------------------

-- Procedure to search and validate the employees login
CREATE PROCEDURE loginEmployee @employeeID AS varchar(20), @passwordHashed AS varchar(255)
AS
BEGIN
SELECT * 
FROM Employee
WHERE ID = @employeeID AND password_hashed = @passwordHashed
END
GO

-----------------------------------------------------------------------------------------------------

-- Procedure to get the payments of a given policy by the policy number.
CREATE PROCEDURE getPayments @policyNumber AS varchar(30)
AS
BEGIN
SELECT [date], [type], amount
FROM Payment
WHERE policy_number = @policyNumber
END
GO

-----------------------------------------------------------------------------------------------------

-- MASTER SEARCH PROCEDURE THAT TAKES IN ALL PARAMETERS.
-- THIS PROCEDURE IS NOW COMPATIBILE WITH DELINQUENT ACCOUNT PARAMETER SEARCHING.
CREATE PROCEDURE searchPolicy @policyNumber AS varchar(30) = '', @agentID AS varchar(20) = '', @agentFName AS varchar(100) = '', @agentLName AS varchar(100) = '', @holderFName AS varchar(100) = '', @holderLName AS varchar(100) = '', @searchState AS char(2) = '__'
AS
BEGIN
SELECT [number], holder_ID, emp_ID, Employee.first_name AS agent_first_name, Employee.last_name AS agent_last_name, holder_DOB, fathers_age_at_death, mothers_age_at_death, cigs_per_day, smoking_history, systolic_blood_pressure, average_grams_fat_per_day, heart_disease, cancer, hospitalized, dangerous_activities, [start_date], end_date, payoff_amount, monthly_premium, PolicyHolder.first_name AS holder_first_name, PolicyHolder.last_name AS holder_last_name, street, city, [state], zip
FROM
(
[Policy] INNER JOIN PolicyHolder
ON [Policy].holder_ID = PolicyHolder.ID
INNER JOIN Employee
ON [Policy].emp_ID = Employee.ID
)
WHERE (Policy.[number] LIKE '%'+@policyNumber+'%' AND Policy.emp_ID LIKE '%'+@agentID+'%' AND PolicyHolder.first_name LIKE '%'+@holderFName+'%' AND PolicyHolder.last_name LIKE '%'+@holderLName+'%' AND Employee.first_name LIKE '%'+@agentFName+'%' AND Employee.last_name LIKE '%'+@agentLName+'%' AND PolicyHolder.[state] LIKE @searchState);
END
GO

-----------------------------------------------------------------------------------------------------

-- Procedure to retrieve all policy numbers that have claims paid.
CREATE PROCEDURE getClaims
AS
BEGIN
SELECT policy_number, [date]
FROM Payment
WHERE [type] = 'C' OR [type] = 'c'
END
GO

-----------------------------------------------------------------------------------------------------

-- Procedure to get Claimed polices
CREATE PROCEDURE getClaimedPolicies
AS
BEGIN
SELECT [number], holder_ID, emp_ID, holder_DOB, fathers_age_at_death, mothers_age_at_death, cigs_per_day, smoking_history, systolic_blood_pressure, average_grams_fat_per_day, heart_disease, cancer, hospitalized, dangerous_activities, [start_date], end_date, payoff_amount, monthly_premium, first_name as holder_first_name, last_name as holder_last_name, street, city, [state], zip
FROM(
[Policy]INNER JOIN PolicyHolder
ON [Policy].holder_ID = PolicyHolder.ID
INNER JOIN Payment
ON Payment.policy_number = [Policy].number)
WHERE Policy.end_date IS NOT NULL AND Payment.[type] = 'C'
END
GO

-----------------------------------------------------------------------------------------------------

-- Procedure to retrieve all beneficiaries of a specified policy.
CREATE PROCEDURE getBeneficiaries @policyNumber AS varchar(30)
AS
BEGIN
SELECT first_name, last_name
FROM Beneficiary
WHERE policy_number = @policyNumber
END
GO

-----------------------------------------------------------------------------------------------------

-- Procedure to get the value of the US dollar.
CREATE PROCEDURE getDollarValue @inputMonth AS int, @inputYear AS varchar(4)
AS
BEGIN
SELECT [value]
FROM USInflation
WHERE month_number = @inputMonth AND [year] = @inputYear
END
GO

-----------------------------------------------------------------------------------------------------
-- Confirmation Search
-----------------------------------------------------------------------------------------------------

-- Procedure Checks if the Policy Exists already
CREATE PROCEDURE doesPolicyExist @policyNumber as varchar(30)
AS
BEGIN
SELECT * FROM Policy
WHERE number = @policyNumber
END
GO

-----------------------------------------------------------------------------------------------------
-- Update Information
-----------------------------------------------------------------------------------------------------

-- Ending a policy by claim. 
CREATE PROCEDURE endPolicy @policyNumber AS varchar(30), @cancelDate AS datetime
AS
BEGIN
UPDATE Policy
SET end_date = @cancelDate
WHERE [number] = @policyNumber
END
GO

-----------------------------------------------------------------------------------------------------

-- Change Policyholder's name, address
CREATE PROCEDURE updatePolicyHolder @ID AS varchar(20), @firstName AS varchar(100), @lastName AS varchar(100), @street AS varchar(30), @city AS varchar(20), @state AS char(2), @zip AS char(9)
AS
BEGIN
UPDATE PolicyHolder
SET first_name = @firstName, last_name = @lastName, street = @street, city = @city, state = @state, zip = @zip
WHERE ID = @ID
END
GO

-----------------------------------------------------------------------------------------------------

-- Change Beneficiary's Name
-- Note that there may be multiple beneficiaries:
-- So we need to have the old name and the new name to update.
CREATE PROCEDURE updateBeneficiary @policyNumber AS varchar(30), @oldFirstName AS varchar(100), @oldLastName AS varchar(100), @newFirstName AS varchar(100), @newLastName AS varchar(100)
AS
BEGIN
UPDATE Beneficiary
SET first_name = @newFirstName, last_name = @newLastName
WHERE policy_number = @policyNumber AND first_name = @oldFirstName AND last_name = @oldLastName
END
GO

-----------------------------------------------------------------------------------------------------
-- INCOMPLETE PROCEDURES
-----------------------------------------------------------------------------------------------------
/*
-- COMPLETED
-- NEEDS REVIEW AND APPROVAL.

-- Procedure to generate the parameters of a delinquent account.
CREATE PROCEDURE createDelinquentAccountReport @ID AS varchar(20), @date AS datetime, @state AS char(2), @amountOverdue AS decimal(10,2)
AS
BEGIN
INSERT INTO Delinquent_Accounts_Parameters(emp_ID, date_generated, [state], amount_overdue)
VALUES (@ID, @date, @state, @amountOverdue)
END
GO

-----------------------------------------------------------------------------------------------------

-- NEEDS REVIEW

-- Procedure to get search for a delinquent account report.
CREATE PROCEDURE getDelinquentAccountReport @ID AS varchar(20) = '', @date AS datetime = NULL, @state AS char(2) = '', @amountOverdue AS decimal(10,2) = NULL
AS
BEGIN
SELECT 
FROM Delinquent_Accounts_Parameters
INNER JOIN 
WHERE emp_ID = @ID AND date_generated AND [state] LIKE '%'+@state+'%' AND 
END
GO

-----------------------------------------------------------------------------------------------------
*/
