В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

```SQL
SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductId = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.CategoryId;
```

![image](https://user-images.githubusercontent.com/56552046/215501676-ee31c1cb-b2ae-497e-b4d4-1854da565642.png)
