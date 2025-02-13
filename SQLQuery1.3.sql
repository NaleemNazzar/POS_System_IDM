CREATE PROCEDURE sp_GetStockBalance
AS
BEGIN
    SELECT
        p.proID,
        p.pName,
        p.pBarcode,
        p.pCost,
        p.pPrice,
        ISNULL(SUM(d.qty), 0) AS TotalQuantity,
        ISNULL(SUM(d.amount), 0) AS TotalAmount,
        ISNULL(SUM(d.cost), 0) AS TotalCost
    FROM
        Product p
        LEFT JOIN tblDetails d ON p.proID = d.productID
    GROUP BY
        p.proID, p.pName, p.pBarcode, p.pCost, p.pPrice
END
