CREATE PROCEDURE sp_GetProductList
AS
BEGIN
    SELECT
        p.proID,
        p.pName,
        c.catName,
        p.pBarcode,
        p.pCost,
        p.pPrice,
        p.pImage
    FROM
        Product p
        LEFT JOIN Category c ON p.pCatID = c.catID
END
