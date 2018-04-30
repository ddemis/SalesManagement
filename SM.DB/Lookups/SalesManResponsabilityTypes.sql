WITH data AS(SELECT 1 AS [SalesManResponsabilityTypeId] , 'Primary' as [SalesManResponsabilityTypeName])
MERGE [SalesManResponsabilityTypes] t USING data s on s.[SalesManResponsabilityTypeId] = t.[SalesManResponsabilityTypeId]
WHEN NOT MATCHED BY TARGET THEN INSERT ([SalesManResponsabilityTypeId], [SalesManResponsabilityTypeName]) VALUES (s.[SalesManResponsabilityTypeId], s.[SalesManResponsabilityTypeName])
wHEN MATCHED THEN UPDATE SET [SalesManResponsabilityTypeName] = s.[SalesManResponsabilityTypeName];

WITH data AS(SELECT 2 AS [SalesManResponsabilityTypeId] , 'Secondary' as [SalesManResponsabilityTypeName])
MERGE [SalesManResponsabilityTypes] t USING data s on s.[SalesManResponsabilityTypeId] = t.[SalesManResponsabilityTypeId]
WHEN NOT MATCHED BY TARGET THEN INSERT ([SalesManResponsabilityTypeId], [SalesManResponsabilityTypeName]) VALUES (s.[SalesManResponsabilityTypeId], s.[SalesManResponsabilityTypeName])
wHEN MATCHED THEN UPDATE SET [SalesManResponsabilityTypeName] = s.[SalesManResponsabilityTypeName];