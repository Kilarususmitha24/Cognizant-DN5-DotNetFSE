USE CommunityEventDB;

SELECT *
FROM Users
ORDER BY full_name;

SELECT *
FROM Users
ORDER BY full_name DESC;

SELECT *
FROM Events
ORDER BY start_date;

SELECT *
FROM Feedback
ORDER BY rating DESC;

SELECT *
FROM Sessions
ORDER BY start_time;
