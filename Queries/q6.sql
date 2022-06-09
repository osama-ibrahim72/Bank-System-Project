



select distinct Customers.Name, Customers.City , Customers.Phone ,Customers.SSN , Customers.State, Customers.State , c.Name 
from Customers,(select Employee.Name from Employee,Loan,Customers WHERE Employee.EID = Loan.EID and Customers.SSN = Loan.SSN ) as c
					
