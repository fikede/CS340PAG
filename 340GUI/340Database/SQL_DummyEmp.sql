/*
 * This is a SQL Query to create a dummy employee in the LIC_PAG DB System for testing and debugging.
 * Created By: Morgan
 */

USE LIC_PAG
GO

INSERT INTO		Employee(ID, first_name, last_name, username, password_hashed, usertype)
VALUES			(11111111111111111111, 'John', 'Wick', 'test', 'test', 'M')

-- NOTE: IF ID = 0's the result is just 0!!!

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