USE CommunityEventDB;


SELECT *
FROM Users
WHERE user_id BETWEEN 2 AND 5;


SELECT *
FROM Feedback
WHERE rating BETWEEN 4 AND 5;


SELECT *
FROM Events
WHERE start_date
BETWEEN '2026-08-01'
AND '2026-09-30';


SELECT *
FROM Sessions
WHERE session_id BETWEEN 1 AND 3;
