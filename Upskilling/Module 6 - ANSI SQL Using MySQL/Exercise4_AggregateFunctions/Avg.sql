USE CommunityEventDB;


SELECT AVG(rating) AS AverageRating
FROM Feedback;


SELECT AVG(user_id) AS AverageUserID
FROM Users;


SELECT AVG(event_id) AS AverageEventID
FROM Events;
