/*
 * This is a SQL Query to create a dummy employee in the LIC_PAG DB System for testing and debugging.
 * Created By: Morgan
 */


USE LIC_PAG
GO

INSERT INTO Department(name)
VALUES		('Freelancer')

INSERT INTO		Employee(ID, first_name, last_name, username, password_hashed, usertype, department)
VALUES			(11111111111111111111, 'John', 'Smith', 'test', 'test', 'm', 'Freelancer')

SELECT *
FROM Employee


/*
TO DELETE THIS TEST USER and TEST DEPARTMENT DO THE FOLLOWING.

USE LIC_PAG
GO

DELETE FROM Employee
WHERE username = 'test'

DELETE FROM Department
WHERE name = 'Freelancer'

SELECT * 
FROM Department

SELECT * 
FROM Employee
*/