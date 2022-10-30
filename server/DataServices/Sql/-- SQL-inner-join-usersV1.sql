-- SQLite
select  AppUsers.UserName,
CostCategories.Name,
CostAmounts.Cost
from AppUsers

inner join CostCategories
on AppUsers.Id= CostCategories.AppUserId


inner join CostAmounts
on CostCategories.Id =CostAmounts.CostCategoryId

order by UserName