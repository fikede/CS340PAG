-- This is the format and commands to create the LIC_PAG SQL stored Procedures.
-- NOTE: This has not been executed yet.
-- There are some procedures that must be completed
-- NOTE: If the table names are underlined and SQL states that the object is undefined.
--			Go to: Edit -> IntelliSense -> Refresh Local Cache
USE LIC_PAG
GO

-- COMPLETED PROCEDURES

CREATE PROCEDURE loginEmployee @employeeID AS varchar(20), @password AS varchar(255)
AS
BEGIN

SELECT * 
FROM Employee
WHERE ID = @employeeID AND password_hashed = @password
END
GO

CREATE PROCEDURE getPayments @policyNumber AS varchar(30)
AS
BEGIN
SELECT * 
FROM Payment
EXCEPT SELECT policynumber
FROM Payment
WHERE policynumber = @policyNumber
END
GO

-- INCOMPLETE PROCEDURES

CREATE PROCEDURE searchPolicy @holderFName AS varchar(100), @holderLName AS varchar(100), @agentFName AS varchar(100),@agentLName AS varchar(100), @policyNumber AS varchar(30)
AS
BEGIN

--NOTE: WE MAY NEED TO JOIN SOME TABLES!

SELECT ID
FROM PolicyHolder
WHERE PolicyHolder.first_name = @holderFName AND PolicyHolder.last_name = @holderLName 

SELECT ID
FROM Employee
WHERE first_name = @agentFName AND last_name = @agentLName

SELECT *
FROM [Policy]
WHERE [Policy].[number] = @policyNumber
END
GO
 
CREATE PROCEDURE generateDelinquentAccountReport @state AS char(2), @amountOverdue AS decimal(8,2), @agentFName AS varchar(100), @agentLName AS varchar(100)
AS
BEGIN

--NOTE: WE MAY NEED TO JOIN SOME TABLES

SELECT *
FROM Delinquent_Accounts_Parameters
WHERE amount_overdue >= @amountOverdue
-- NOT DONE
END
GO