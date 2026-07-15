USE CommunityEventDB;


SELECT *
FROM Users
WHERE city IN
('Hyderabad','Chennai');


SELECT *
FROM Feedback
WHERE rating IN (4,5);


SELECT *
FROM Events
WHERE event_id IN (1,2);


SELECT *
FROM Registrations
WHERE user_id IN (1,3,5);
