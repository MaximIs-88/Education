select *
from TableTest
where id > 1 and id < 3

select *
from TableTest as t1
inner join Test1 as t2 on  t1.Id = t2.Id
--where t1.id > 1 and t1.id < 3

select *
from TableTest as t1
right outer join Test1 as t2 on  t1.Id = t2.Id
--where t1.id > 1 and t1.id < 3

select *
from TableTest as t1
full outer join Test1 as t2 on  t1.Id = t2.Id

select *
from TableTest as t1
cross join Test1 as t2


