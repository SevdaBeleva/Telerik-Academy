-- task 1: Write a stored procedure that selects the full names of all persons.
CREATE PROC usp_GetFullName
AS
SELECT FirstName + ' ' + LastName AS FullName
FROM Persons
GO

EXEC usp_GetFullName
GO

--task 2: Create a stored procedure that accepts a number as a parameter and 
--returns all persons who have more money in their accounts than the supplied number.
CREATE PROC usp_GetPeopleWithBalanceMoreThan(@ammount money)
AS
SELECT p.LastName, a.Balance 
FROM Persons p
JOIN Accounts a
on p.PersonId = a.PersonId
WHERE Balance > @ammount
GO

EXEC usp_GetPeopleWithBalanceMoreThan 123.5677
GO

--task 3: Create a function that accepts as parameters – sum, yearly interest rate and number of months. 
--It should calculate and return the new sum.
-- Write a SELECT to test whether the function works as expected.
CREATE FUNCTION unf_CalculateInterestRate(@sum money, @interest float, @months int)
RETURNS money
AS
BEGIN
	DECLARE @newSum money
	SET @newSum = @sum + (@months/12.0)*((@interest*@sum)/100)
	RETURN @newSum
END
GO

SELECT dbo.unf_CalculateInterestRate(230.00, 5.3, 24)AS [Sum with interest rate]
GO

--task 4: Create a stored procedure that uses the function from the previous example
-- to give an interest to a person's account for one month. 
--It should take the AccountId and the interest rate as parameters.
CREATE PROC usp_AddInterests(@AccountID int, @interestRate float)
AS
BEGIN
DECLARE @sum money
SET @sum = (SELECT Balance
FROM Accounts
WHERE AccountId = CAST(@AccountID AS int))

DECLARE @updatedSum money
SET @updatedSum = dbo.unf_CalculateInterestRate(@sum, @interestRate, 1)

UPDATE Accounts
SET Balance = CAST(@updatedSum AS money)
WHERE AccountId = CAST(@AccountID AS int)

END
GO

EXEC usp_AddInterests 1, 5.5
GO


