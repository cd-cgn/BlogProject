--DROP TABLE Blog --TRUNCATE TABLE Blog

--Read
SELECT * FROM Blog

--Create
CREATE TABLE Blog(
id INT PRIMARY KEY IDENTITY (1, 1),
title varchar(MAX) NOT NULL,
body varchar(MAX) NOT NULL,
author varchar(MAX) NOT NULL)

--Insert
INSERT INTO Blog
(title, body, author)
VALUES
('My First Blog','Blog 1 Body',	'mario'),
('My Second Blog',	'Blog 2 Body',	'yoshi')