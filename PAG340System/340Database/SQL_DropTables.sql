/*
-- To drop tables, use the following commands in the designated order.

USE LIC_PAG
GO

DROP TABLE USInflation
DROP TABLE Delinquent_Accounts_Parameters
DROP TABLE Beneficiary
DROP TABLE Payment
DROP TABLE PolicyHolder
DROP TABLE [Policy]
DROP TABLE Employee
DROP TABLE Department
*/

-----------------------------------------------------------------
-- To alter a table column use the following schema.
-----------------------------------------------------------------
/*
USE LIC_PAG
GO
ALTER TABLE [table_name]
ALTER COLUMN [column_name] [data_type]
*/

/*
-----------------------------------------------------------------
-- EXAMPLE
-----------------------------------------------------------------

USE LIC_PAG
GO

ALTER TABLE policy
ALTER COLUMN payoff_amount decimal(10,2) null

ALTER TABLE policy
ALTER COLUMN monthly_premium decimal(10,2) null

ALTER TABLE policy
ALTER COLUMN monthly_premium decimal(10,2) null

ALTER TABLE Payment
ALTER COLUMN amount decimal(10,2) null

ALTER TABLE Delinquent_Accounts_Parameters
ALTER COLUMN amount_overdue decimal(10,2) null
*/