--Managers with at Least 5 Direct Reports--
WITH cte AS (
    SELECT 
        COUNT(*) AS ManageridCount,
        e.managerId
    FROM Employee AS e
    WHERE e.managerId IS NOT NULL 
    GROUP BY e.managerId 
    HAVING COUNT(*) >= 5
)

-- select * from cte where
-- select name from employee where id = 101

select
    ed.name as [name]
from employee as ed
inner join cte as c on ed.id = c.managerid