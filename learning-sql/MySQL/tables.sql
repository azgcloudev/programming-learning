-- CREATE A NEW TABLE
CREATE TABLE
    employees (
        employee_id INT,
        first_name VARCHAR(50),
        last_name VARCHAR(50),
        hourly_pay DECIMAL(5, 2),
        hire_date DATE
    )

--  select the table
SELECT * FROM employees;

--  rename a table name
RENAME TABLE  employees TO workers;

-- drop a table
DROP TABLE employees;

-- alter a table, ADD A COLUMN
ALTER TABLE employees
ADD phone_number VARCHAR(50);

--  rename a column
ALTER TABLE employees RENAME COLUMN phone_number TO email;

-- MODIFY COLUMN TYPE
ALTER TABLE employees MODIFY COLUMN email VARCHAR(100);


--  MOVE COLUMNS
ALTER TABLE employees
MODIFY email VARCHAR(100)
AFTER last_name;

-- move a column to the beginning
ALTER TABLE employees
MODIFY email VARCHAR(100)
FIRST;

-- drop a column
ALTER TABLE employees
DROP COLUMN email;