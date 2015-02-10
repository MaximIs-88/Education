 --HAVING
 --HAVING — необязательный (опциональный) параметр оператора SELECT для указания условия
 -- на результат агрегатных функций (MAX, SUM, AVG, …).
 --Распространённая ошибка — указание в SELECT столбца, пропущенного в GROUP BY.
 
 SELECT DeptID, SUM(SaleAmount) FROM Sales
 WHERE SaleDate = '01-Jan-2000'
 GROUP BY DeptID
 HAVING SUM(SaleAmount) > 1000

 SELECT DepartmentName, COUNT(*) 
 FROM employee,department 
 WHERE employee.DepartmentID = department.DepartmentID 
 GROUP BY DepartmentName
 HAVING COUNT(*)>1;

 select TableTest.first, COUNT(TableTest.Id) as countValue
 from TableTest
 group by TableTest.first
 having COUNT(TableTest.Id) > 0
