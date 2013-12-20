-- Task1
SELECT FirstName +  ' ' + LastName AS FullName, Salary
FROM Employees
WHERE Salary = (SELECT MIN(Salary) FROM Employees)

-- Task2
SELECT FirstName +  ' ' + LastName AS FullName, Salary
FROM Employees
WHERE Salary <= (SELECT MIN(Salary) FROM Employees)*1.1

-- Task3
SELECT FirstName +  ' ' + LastName AS FullName, Salary, d.Name
FROM Employees e JOIN Departments d
ON d.DepartmentID = e.DepartmentID 
WHERE Salary = 
        (SELECT MIN(Salary) FROM Employees
        WHERE DepartmentID = e.DepartmentID)
        order by d.Name

-- Task4
SELECT AVG(Salary) [Avarage Salary]
FROM Employees
WHERE DepartmentID = 1

-- Task5
SELECT AVG(Salary) [Avarage Salary]
FROM Employees e JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- Task6
SELECT COUNT(*) [Count Employees]
FROM Employees e JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- Task7
SELECT COUNT(*) [Count Employees]
FROM Employees e 
WHERE ManagerID IS NOT NULL

-- Task8
SELECT COUNT(*) [Count Employees]
FROM Employees e 
WHERE ManagerID IS NULL

-- Task9
SELECT d.Name [Department], AVG(Salary) [Avarage Salary]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

-- Task10
SELECT d.Name [Department], t.Name [Town], Count(*) [Count Employees]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t
ON a.TownID = t.TownID
GROUP BY d.Name, d.DepartmentID, t.Name, t.TownID

-- Task11
SELECT e.FirstName + ' ' +  e.LastName ManagerName, COUNT(*) [Count Employees]
        FROM Employees e
        JOIN Employees em
        ON em.ManagerID = e.EmployeeID
        GROUP BY e.FirstName, e.LastName
        HAVING COUNT(*) = 5

-- Task12
SELECT e.FirstName + ' ' +  e.LastName  AS FullName,  
           CASE WHEN m.FirstName +  ' ' +  m.LastName <> ' ' THEN m.FirstName +  ' ' + m.LastName ELSE 'no manager' END AS ManagerFullName
FROM Employees e
LEFT JOIN Employees m
on e.ManagerID = m.EmployeeID

-- Task13
SELECT e.FirstName +  ' ' + e.LastName ManagerName
        FROM Employees e
        WHERE LEN(e.LastName) = 5


-- Task15
CREATE TABLE Users (
  UserId int IDENTITY,
  Name nvarchar(50) NOT NULL, 
  Pass nvarchar(50), 
  FullName nvarchar(100),
  LastLoginTime date, 
  CONSTRAINT PK_Users PRIMARY KEY(UserId), 
  CONSTRAINT PK_Pass CHECK (DATALENGTH(Pass) >= 5),
  CONSTRAINT UK_Name UNIQUE(Name)
)

GO

