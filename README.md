```SQL
SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductId = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.CategoryId;
```

![image](https://user-images.githubusercontent.com/56552046/215501676-ee31c1cb-b2ae-497e-b4d4-1854da565642.png)
