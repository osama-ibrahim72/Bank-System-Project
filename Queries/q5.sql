


select Customers.Name 
from Customers 
where not exists (select Loan.SSN from Loan )

