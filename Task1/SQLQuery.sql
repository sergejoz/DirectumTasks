-- 1 запрос
-- 1) показать только тех, у кого есть продажи

SELECT [Surname], [Name], Sum(Quantity) AS [SumQuantity]
FROM [Sales] AS s
JOIN [Sellers] ON s.[IDSel]=[Sellers].[ID]
WHERE s.[Date] between '20131001' AND '20131007'
GROUP BY [Surname],[Name];

-- 2) показать всех селлеров и их продажи

WITH AllSales AS 
(
	SELECT [IDSel], Sum(Quantity) AS [SumQuantity] 
	FROM [Sales] AS s
	WHERE s.[Date] between '20131001' AND '20131007'
	GROUP BY s.[IDSel]
)
SELECT [Surname], [Name], [SumQuantity] 
FROM [AllSales] AS a
RIGHT JOIN [Sellers] AS s ON s.[ID] = a.[IDSel]
ORDER BY [Surname],[Name];

-- 2 запрос
WITH quary AS 
(
	SELECT s.IDSel, a.IDProd, (100.0 * sum(s.[Quantity])) / sum(sum(s.[Quantity])) over (partition by a.[IDProd]) AS  [Percent]
	FROM [Sales] AS s
	JOIN [Arrivals] AS a ON a.[IDProd] = s.[IDProd]
	WHERE s.[Date] between '20131001' and '20131007' and a.[Date] between '20130907' and '20131007'
	GROUP BY s.[IDSel], a.[IDProd]
)
SELECT s.[Surname], s.[Name], p.[Name] AS [ProductName], quary.[Percent]
FROM quary
RIGHT JOIN Sellers AS  s ON s.[ID] = quary.[IDSel]
LEFT JOIN Products AS  p ON p.[ID] = quary.[IDProd]
ORDER BY s.[Surname], s.[Name], p.[Name];