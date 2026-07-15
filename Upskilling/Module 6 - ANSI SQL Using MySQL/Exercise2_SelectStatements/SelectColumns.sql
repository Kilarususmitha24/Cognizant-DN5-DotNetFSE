USE CommunityEventDB;

SELECT full_name,email
FROM Users;

SELECT title,city
FROM Events;

SELECT title,speaker_name
FROM Sessions;

SELECT rating,comments
FROM Feedback;

SELECT resource_type,resource_url
FROM Resources;
