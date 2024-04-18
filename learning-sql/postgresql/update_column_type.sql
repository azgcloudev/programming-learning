ALTER TABLE customer
ALTER COLUMN sex TYPE sex_type USING sex::sex_type;