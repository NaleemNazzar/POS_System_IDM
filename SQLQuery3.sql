CREATE PROCEDURE sp_GetSupplierList
AS
BEGIN
    SELECT
        supID,
        supName,
        supPhone,
        supEmail
    FROM
        Supplier
END
