
select Name 
from Customers 
where exists (select max(loan.SSN) from loan)

