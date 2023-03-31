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

-- 3. Find the movies not released in the years between 2000 and 2010
SELECT * FROM  movies WHERE Year NOT BETWEEN 2000 AND 2010;

-- 4. Find the first 5 Pixar movies and their release year
SELECT Title, Year FROM movies
WHERE id BETWEEN 1 AND 5;




-- ============= SQL Lesson 3: Queries with constraints (Pt. 2) =====================
-- Table: Movies
-- Id	Title	Director	Year	Length_minutes

-- 1. Find all the Toy Story movies
SELECT * FROM Movies
WHERE Title LIKE "Toy Story%";

-- 2. Find all the movies directed by John Lasseter
SELECT * FROM Movies
WHERE Director = "John Lasseter";

-- 3. Find all the movies (and director) not directed by John Lasseter
SELECT * FROM Movies WHERE Director != "John Lasseter";

-- 4. Find all the WALL-* movies
SELECT * FROM Movies WHERE Title LIKE "wall-%";




-- ============= SQL Lesson 4: Filtering and sorting Query results =====================
-- Table: Movies
-- Id	Title	Director	Year	Length_minutes

-- 1. List all directors of Pixar movies (alphabetically), without duplicates
SELECT DISTINCT Director FROM Movies ORDER BY Director ASC;

-- 2. List the last four Pixar movies released (ordered from most recent to least)
SELECT * FROM  Movies ORDER BY Year DESC LIMIT 4;

-- 3. List the first five Pixar movies sorted alphabetically
SELECT * FROM Movies ORDER BY Title ASC LIMIT 5;

-- 4. List the next five Pixar movies sorted alphabetically
SELECT * FROM Movies ORDER BY Title ASC LIMIT 5 OFFSET 5;




-- ============= SQL Review: Simple SELECT Queries =====================
