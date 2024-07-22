-- update null value
ALTER TABLE sales_item ALTER COLUMN day_of_week SET NOT NULL;

-- RENAME COLUMN NAME
ALTER TABLE sales_item RENAME COLUMN day_of_week TO weekday;

-- REMOVE A COLUMN
ALTER TABLE sales_item DROP COLUMN weekday;

-- UPDATE COLUMN TYPE
ALTER TABLE customer ALTER COLUMN zip TYPE INTEGER;