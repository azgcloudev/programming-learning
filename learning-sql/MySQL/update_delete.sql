-- update data in a table
UPDATE employees
SET
    hourly_pay = 10.25
WHERE
    employee_id = 6;

-- change more than one field at the time
UPDATE employees
SET
    hourly_pay = 10.50,
    hire_date = "2023-01-07"
WHERE
    employee_id = 6;

-- set a value to null
UPDATE employees
SET
    hire_date = null
WHERE
    employee_id = 21;

-- update all of the rows within a column (to ALL THE ROWS)
UPDATE employees
SET
    hourly_pay = 10.25;

--  delete a row from a table
-- never to this statement, as it will delete ALL the rows
DELETE FROM employees;

-- never to this statement, as it will delete ALL the rows
DELETE FROM employees
WHERE
    employee_id = 6;