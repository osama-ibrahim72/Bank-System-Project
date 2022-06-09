select Bank.Name , Branche.city
from Bank , Branche 
where Bank.Code = Branche.Code and not exists (select Employee.BNUM from  Employee )

