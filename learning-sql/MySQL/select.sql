--  query everything from the table
SELECT
    *
FROM
    employees;

-- Query specific columns from a table
SELECT
    first_name,
    last_name
FROM
    employees;

-- Search from all by giving a condition
SELECT * FROM employees WHERE employee_id = 21;
SELECT * FROM employees WHERE first_name = "Spongebob";
SELECT * FROM employees WHERE hourly_pay >= 16;
SELECT * FROM  employees WHERE hire_date <= "2023-01-03";
SELECT * FROM employees WHERE employee_id != 21;

--  find elements that are null
SELECT employee_id, first_name, last_name FROM employees WHERE hire_date IS NULL;