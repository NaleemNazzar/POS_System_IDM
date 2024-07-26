CREATE PROCEDURE sp_GetSalesReport
AS
BEGIN
    SELECT
        m.MainID,
        m.mdate,
        m.mType,
        d.productID,
        d.qty,
        d.price,
        d.amount,
        d.cost
    FROM
        tblMain m
    JOIN
        tblDetails d ON m.MainID = d.dMainID
    WHERE
        m.mType = 'Sale'
END
