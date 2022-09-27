-- SQLite




 SELECT CostCategories.Id,
 CostCategories. AppUserId, 
 CostCategories.CreatedOn, 
 CostCategories.Description, 
 CostCategories.Name, 
 CostCategories.UpdatedOn,
 CostAmounts.Cost
FROM CostCategories  INNER JOIN CostAmounts ON
CostCategories.Id=CostAmounts.CostCategoryId

