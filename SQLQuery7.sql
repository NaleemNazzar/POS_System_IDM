CREATE PROCEDURE sp_GetProfitReport
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
        d.cost,
        (d.price - d.cost) AS profit
    FROM
        tblMain m
    JOIN
        tblDetails d ON m.MainID = d.dMainID
    WHERE
        m.mType IN ('Sale', 'Purchase')
END
