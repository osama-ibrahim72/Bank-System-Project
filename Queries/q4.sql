

select Name 
from Employee 
where exists (select max(loan.SSN) from loan)

