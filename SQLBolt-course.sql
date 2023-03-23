-- table: --> movies
-- columns
-- Id	Title	Director	Year	Length_minutes

-- fint the title of each fil
SELECT Title FROM movies;

-- Find the director of each film
SELECT Director FROM movies;

-- Find the title and director of each film
SELECT Title, Director FROM movies;

-- Find the title and year of each film
SELECT Title, Year FROM movies


-- ============= SQL Lesson 2: Queries with constraints (Pt. 1) =====================
-- Table: Movies
-- Id	Title	Director	Year	Length_minutes
-- 1. Find the movie with a row id of 6
SELECT * FROM movies WHERE id == 6;

-- 2. Find the movies released in the years between 2000 and 2010
SELECT * FROM movies WHERE Year BETWEEN 2000 AND 2010;

-- Find the movies not released in the years between 2000 and 2010
SELECT * FROM Movies WHERE Year NOT BETWEEN 2000 AND 2010;

-- Find the first 5 Pixar movies and their release year
SELECT Title, Year FROM  Movies WHERE id BETWEEN 1 AND 5;


-- ============== SQL Lesson 3: Queries with constraints (Pt. 2) ==========================
-- Table: Movies
-- Id	Title	Director	Year	Length_minutes

-- 1. Find all the Toy Story movies
SELECT * FROM Movies WHERE Title LIKE "%toy story%";

-- 2. Find all the movies directed by John Lasseter
SELECT * FROM Movies WHERE Director LIKE "John Lasseter";

-- 3. Find all the movies (and director) not directed by John Lasseter
SELECT Title, Director FROM  Movies WHERE Director <> "John Lasseter";

-- 4. Find all the WALL-* movies
SELECT * FROM Movies WHERE Title LIKE "wall-%";



-- ================= SQL Lesson 4: Filtering and sorting Query results ========================
