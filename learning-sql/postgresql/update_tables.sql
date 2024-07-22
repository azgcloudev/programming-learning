-- update table name
ALTER TABLE transaction_type
RENAME TO transaction;

-- create index based on individual single column
CREATE INDEX transaction_id ON transaction (name);

-- create index based on multiple columns
CREATE INDEX transaction_id_2 ON transaction (name, payment_type);

-- delete all thee data in a table
TRUNCATE TABLE transaction;

-- delete a table
DROP TABLE transaction;