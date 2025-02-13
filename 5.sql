-- Adding an index to 'Product' table for better performance on 'pName'
CREATE INDEX IX_Product_pName
ON Product (pName);

-- Dropping an index if it is no longer needed
DROP INDEX IX_Product_pName ON Product;
