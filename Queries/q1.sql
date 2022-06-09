
Select Bank.Name , Branche.Street
from Bank ,Branche
where bank.Code = Branche.Code and not  exists (select Customers.BNUM from Customers )



