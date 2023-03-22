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