USE CommunityEventDB;

SELECT *
FROM Users
WHERE city='Hyderabad';

SELECT *
FROM Events
WHERE status='upcoming';

SELECT *
FROM Feedback
WHERE rating>=4;

SELECT *
FROM Sessions
WHERE speaker_name='Dr. Kumar';

SELECT *
FROM Registrations
WHERE user_id=1;
