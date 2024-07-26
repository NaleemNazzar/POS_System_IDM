CREATE PROCEDURE sp_GetProfitOrLossReport
AS
BEGIN
    SELECT
        m.mdate,
        m.mType,
        d.productID,
        d.qty,
        d.price,
        d.amount,
        d.cost,
        (d.price - d.cost) AS profit_or_loss
    FROM
        tblMain m
    JOIN
        tblDetails d ON m.MainID = d.dMainID
    WHERE
        m.mType IN ('Sale', 'Purchase')
END
