/*
 * This is a SQL Query to create a dummy employee in the LIC_PAG DB System for testing and debugging.
 * Created By: Morgan
 */


USE LIC_PAG
GO

INSERT INTO		Employee(ID, first_name, last_name, username, password_hashed, usertype)
VALUES			(00000000000000000000, 'John', 'Smith', 'test', 'test', 'm')

SELECT *
FROM Employee


/*
TO DELETE THIS TEST USER DO THE FOLLOWING.

USE LIC_PAG
GO

DELETE FROM Employee
WHERE username = 'test'

SELECT * 
FROM Employee

*/