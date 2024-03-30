-- insert data into a table
-- in values need to uise the column order of the table
--  date format is yyyy-mm-dd
INSERT INTO
    employees
VALUES
    (21, "Aldair", "Zamora", 14.99, "2023-01-10");


-- insert multiple rows at the time
INSERT INTO
    employees
VALUES
    (2, "Squidward", "Tentacles", 15.00, "2023-01-03"),
    (3, "Spongebob", "Squarepants", 12.50, "2023-01-04"),
    (4, "Patric","Start",12.50, "2023-01-05"),
    (5, "Sandy","Cheeks",17.25,"2023-01-06");


--  insert a row with missing data
INSERT INTO employees (employee_id, first_name, last_name)
VALUES (6, "Sheldon","Plankton");