USE CommunityEventDB;


SELECT city,
COUNT(*) AS TotalUsers
FROM Users
GROUP BY city
HAVING COUNT(*) > 1;


SELECT event_id,
COUNT(*) AS TotalRegistrations
FROM Registrations
GROUP BY event_id
HAVING COUNT(*) > 1;


SELECT event_id,
AVG(rating) AS AverageRating
FROM Feedback
GROUP BY event_id
HAVING AVG(rating) > 4;

SELECT city,
COUNT(*) AS TotalEvents
FROM Events
GROUP BY city
HAVING COUNT(*) >= 1;
