USE db0
GO
SELECT
    IDProduct,
    ProductName,
	TRIM(value) AS Category
FROM
    Product
CROSS APPLY
    STRING_SPLIT(ProductCategory, ',') as Products;
