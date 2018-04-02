-- This is the format and commands to create the LIC_PAG SQL stored Procedures.
-- NOTE: This has not been executed yet.
-- There are some procedures that must be completed
-- NOTE: If the table names are underlined and SQL states that the object is undefined.
--			Go to: Edit -> IntelliSense -> Refresh Local Cache
USE LIC_PAG
GO


-- COMPLETED AND NEEDS TESTING

-- Procedure to search and validate the employees login
CREATE PROCEDURE loginEmployee @employeeID AS varchar(20), @password AS varchar(255)
AS
BEGIN

SELECT * 
FROM Employee
WHERE ID = @employeeID AND password_hashed = @password
END
GO

-- Procedure to search for a policy by the policy number.
-- if this is an agent then we use their agent ID as well.
CREATE PROCEDURE searchPolicybyPolicyNumber @policyNumber AS varchar(30), @agentID AS varchar(20)
AS
BEGIN

IF (@agentID = '') OR (@agentID = NULL)
SELECT *
FROM
([Policy] INNER JOIN PolicyHolder)
ON [Policy].holderID = PolicyHolder.ID

ELSE
SELECT *
FROM
([Policy] INNER JOIN PolicyHolder)
ON [Policy].holderID = PolicyHolder.ID
WHERE [Policy].agentID = @agentID AND [Policy].[number] = @policyNumber

END
GO


-- Procedure to get the payments of a given policy by the policy number.
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


-- Procedure to search for a policy by the holders name and the agents ID.
CREATE PROCEDURE searchPolicybyholderNameandAgentID @holderFName AS varchar(100), @holderLName AS varchar(100), @agentID AS varchar(20)
AS
BEGIN

SELECT *
FROM(
[Policy]INNER JOIN(
SELECT ID 
FROM Employee
WHERE Employee.ID = @agentID
ON [Policy]. agentID = Employee.ID
)
INNER JOIN PolicyHolder
ON
[Policy].holderID = PolicyHolder.ID
WHERE [Policy].[number] = @policyNumber
)

END
GO

-- INCOMPLETE PROCEDURES


-- Procedure to search for a policy by the holders name and the agents name.
CREATE PROCEDURE searchPolicybyholderNameandAgentName @holderFName AS varchar(100), @holderLName AS varchar(100), @agentFName AS varchar(100), @agentLName AS varchar(100)
AS
BEGIN
--
END
GO


-- Procedure to generate the parameters of a delinquent account.
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