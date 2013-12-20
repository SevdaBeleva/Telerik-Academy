--task 4
select * from Departments

--task 5
select Name from Departments

--task 6
select Salary, FirstName, LastName from Employees

--task 7
select FirstName + ' ' + MiddleName + ' ' + LastName as [FullName] from Employees

--task 9
select Salary from Employees

--task 10
select * from Employees where JobTitle = 'Sales Representative'

--task 11
select FirstName, MiddleName, LastName from Employees where SUBSTRING(FirstName, 1,2) = 'SA'

--task 13
select LastName, Salary from Employees where (Salary Between 20000 and 30000)

--task 14
select LastName, Salary from Employees where (Salary = 25000)

select LastName, Salary from Employees where (Salary = 14000)

select LastName, Salary from Employees where (Salary = 12500)

select LastName, Salary from Employees where (Salary = 23600)

--task 15
select LastName, ManagerID from Employees where ManagerID is NULL

--task 16
select LastName, Salary from Employees where (Salary > 50000)order by Salary desc

--task 17
select LastName, Salary from Employees 
where (Salary in (select distinct top (5)Salary from Employees order by Salary desc))

--task 18
select e.FirstName + ' ' + e.LastName as Employee, a.AddressID as Address
 from Employees e join Addresses a on a.AddressID = e.AddressID
 
--task 19
select e.LastName, a.AddressID as Address
 from Employees e, Addresses a
 where e.AddressID = a.AddressID

--task 20
select e.FirstName + ' ' + e.LastName as Employee, m.ManagerId as Manager
from Employees e join Employees m  on e.ManagerID = m.EmployeeID

--task 21
select e.FirstName + ' ' + e.LastName as Employee, m.ManagerId as Manager, a.AddressID as Address
from Employees e join Employees m  on e.ManagerID = m.EmployeeID
join Addresses a on e.AddressID = a.AddressID

--task 22
select Name from Departments 
union
select Name from Towns 