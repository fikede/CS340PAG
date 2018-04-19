-----------------------------------------------------------------------------------------------------
-- This is the format and commands to create the LIC_PAG SQL stored Procedures.
-- NOTE: This has not been executed yet.
-- There are some procedures that must be completed
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
CREATE PROCEDURE addEmployee @employeeID AS varchar(20), @firstName AS varchar(100), @lastName AS varchar(100), @username AS varchar(20), @password AS varchar(255), @usertype AS char, @department AS varchar (50)
AS
BEGIN
INSERT INTO	Employee(ID, first_name, last_name, username, password_hashed, user_type, department)
VALUES		(@employeeID, @firstName, @lastName, @username, @password, @usertype, @department)
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
VALUES (@policyNumber, @holderID, @empID, @holderDOB, @fatherDeath, @motherDeath, @cigsPerDay, @smokeHistory, @sysBP, @aGramsFat, @heartDisease, @cancer, @hospitalized, @dangerousActivities, @startDate, @endDate, @payoffAmount, @monthlyPremium)
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
-- Searching Procedures
-----------------------------------------------------------------------------------------------------

CREATE PROCEDURE getDepartments
AS
BEGIN
SELECT * FROM Department
END
GO

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
CREATE PROCEDURE loginEmployee @employeeID AS varchar(20), @password AS varchar(255)
AS
BEGIN

SELECT * 
FROM Employee
WHERE ID = @employeeID AND password_hashed = @password
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

-- Procedure to search for a policy by the policy number.
-- if this is an agent then we use their agent ID as well.
CREATE PROCEDURE searchPolicybyPolicyNumber @policyNumber AS varchar(30), @agentID AS varchar(20)
AS
BEGIN

IF (@agentID = '') OR (@agentID = NULL) -- manager
SELECT [number], holder_ID, emp_ID, holder_DOB, fathers_age_at_death, mothers_age_at_death, cigs_per_day, smoking_history, systolic_blood_pressure, average_grams_fat_per_day, heart_disease, cancer, hospitalized, dangerous_activities, [start_date], end_date, payoff_amount, monthly_premium, first_name, last_name, street, city, [state], zip
FROM
([Policy] INNER JOIN PolicyHolder
ON [Policy].holder_ID = PolicyHolder.ID)
WHERE [Policy].[number] = @policyNumber;

ELSE -- agent
SELECT [number], holder_ID, emp_ID, holder_DOB, fathers_age_at_death, mothers_age_at_death, cigs_per_day, smoking_history, systolic_blood_pressure, average_grams_fat_per_day, heart_disease, cancer, hospitalized, dangerous_activities, [start_date], end_date, payoff_amount, monthly_premium, first_name, last_name, street, city, [state], zip
FROM
([Policy] INNER JOIN PolicyHolder
ON [Policy].holder_ID = PolicyHolder.ID)
WHERE [Policy].emp_ID = @agentID AND [Policy].[number] = @policyNumber;

END
GO

-----------------------------------------------------------------------------------------------------

-- Procedure to search for a policy by the holders name and the agents ID (if needed).
CREATE PROCEDURE searchPolicybyHolderName @holderFName AS varchar(100), @holderLName AS varchar(100), @agentID AS varchar(20)
AS
BEGIN

-- manager
IF (@agentID = '') OR (@agentID = NULL)
SELECT [number], holder_ID, emp_ID, holder_DOB, fathers_age_at_death, mothers_age_at_death, cigs_per_day, smoking_history, systolic_blood_pressure, average_grams_fat_per_day, heart_disease, cancer, hospitalized, dangerous_activities, [start_date], end_date, payoff_amount, monthly_premium, first_name, last_name, street, city, [state], zip
FROM(
[Policy]INNER JOIN PolicyHolder
ON [Policy].holder_ID = PolicyHolder.ID)
WHERE PolicyHolder.first_name = @holderFName AND PolicyHolder.last_name = @holderLName;

-- agent
ELSE 
SELECT [number], holder_ID, emp_ID, holder_DOB, fathers_age_at_death, mothers_age_at_death, cigs_per_day, smoking_history, systolic_blood_pressure, average_grams_fat_per_day, heart_disease, cancer, hospitalized, dangerous_activities, [start_date], end_date, payoff_amount, monthly_premium, first_name, last_name, street, city, [state], zip
FROM(
[Policy]INNER JOIN PolicyHolder
ON
[Policy].holder_ID = PolicyHolder.ID)
WHERE [Policy].emp_ID = @agentID AND PolicyHolder.first_name = @holderFName AND PolicyHolder.last_name = @holderLName;

END
GO

-----------------------------------------------------------------------------------------------------

-- Procedure to search for a policy by the holders name and the agents name.
CREATE PROCEDURE searchPolicybyHolderNameandAgentName @holderFName AS varchar(100), @holderLName AS varchar(100), @agentFName AS varchar(100), @agentLName AS varchar(100)
AS
BEGIN
SELECT [number], holder_ID, emp_ID, holder_DOB, fathers_age_at_death, mothers_age_at_death, cigs_per_day, smoking_history, systolic_blood_pressure, average_grams_fat_per_day, heart_disease, cancer, hospitalized, dangerous_activities, [start_date], end_date, payoff_amount, monthly_premium, PolicyHolder.first_name, PolicyHolder.last_name, street, city, [state], zip
FROM(
[Policy]INNER JOIN PolicyHolder
ON [Policy].holder_ID = PolicyHolder.ID
INNER JOIN Employee
ON Employee.ID = [Policy].emp_ID
)
WHERE PolicyHolder.first_name = @holderFName AND PolicyHolder.last_name = @holderLName AND Employee.first_name = @agentFName AND Employee.last_name = @agentLName
END
GO

-----------------------------------------------------------------------------------------------------
-- Procedure to retrieve all policies ended in the LIC DB
CREATE PROCEDURE getEndedPolicies
AS
BEGIN
SELECT [number], holder_ID, emp_ID, holder_DOB, fathers_age_at_death, mothers_age_at_death, cigs_per_day, smoking_history, systolic_blood_pressure, average_grams_fat_per_day, heart_disease, cancer, hospitalized, dangerous_activities, [start_date], end_date, payoff_amount, monthly_premium, first_name, last_name, street, city, [state], zip
FROM(
[Policy]INNER JOIN PolicyHolder
ON [Policy].holder_ID = PolicyHolder.ID)
WHERE Policy.end_date IS NOT NULL
END
GO


-----------------------------------------------------------------------------------------------------

/*
-----------------------------------------------------------------------------------------------------
-- NOTE: NO OTHER PROCEDURES HAVE BEEN CREATED IN THE DB.
-----------------------------------------------------------------------------------------------------

-----------------------------------------------------------------------------------------------------
-- INCOMPLETE PROCEDURES
-----------------------------------------------------------------------------------------------------


-----------------------------------------------------------------------------------------------------

-- Procedure to generate the parameters of a delinquent account.
CREATE PROCEDURE generateDelinquentAccountReport @state AS char(2), @amountOverdue AS decimal(10,2), @agentFName AS varchar(100), @agentLName AS varchar(100)
AS
BEGIN

--NOTE: WE MAY NEED TO JOIN SOME TABLES

SELECT *
FROM Delinquent_Accounts_Parameters
WHERE amount_overdue >= @amountOverdue
-- NOT DONE
END
GO



-----------------------------------------------------------------------------------------------------

CREATE PROCEDURE endPolicyWithoutClaim @policyNumber AS varchar(30)
AS
BEGIN
--
END
GO

-----------------------------------------------------------------------------------------------------

CREATE PROCEDURE endPolicyWithClaim
AS
BEGIN

--NEED TO DO THE FOLLOWING:
	1) Make a claim
	2) Modify Policy Table

END
GO
*/