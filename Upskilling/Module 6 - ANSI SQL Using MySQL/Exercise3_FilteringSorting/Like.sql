USE CommunityEventDB;


SELECT *
FROM Users
WHERE full_name LIKE 'S%';


SELECT *
FROM Users
WHERE full_name LIKE '%l';


SELECT *
FROM Events
WHERE title LIKE '%AI%';


SELECT *
FROM Sessions
WHERE speaker_name LIKE 'D%';


SELECT *
FROM Users
WHERE email LIKE '%gmail%';
