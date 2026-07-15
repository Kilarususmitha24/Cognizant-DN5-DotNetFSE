USE CommunityEventDB;

SELECT city,
COUNT(*) AS TotalUsers
FROM Users
GROUP BY city;


SELECT city,
COUNT(*) AS TotalEvents
FROM Events
GROUP BY city;


SELECT event_id,
AVG(rating) AS AverageRating
FROM Feedback
GROUP BY event_id;


SELECT event_id,
COUNT(*) AS TotalRegistrations
FROM Registrations
GROUP BY event_id;
