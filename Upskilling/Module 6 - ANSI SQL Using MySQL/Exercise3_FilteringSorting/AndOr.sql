USE CommunityEventDB;


SELECT *
FROM Users
WHERE city='Hyderabad';


SELECT *
FROM Users
WHERE city='Hyderabad'
OR city='Guntur';

SELECT *
FROM Events
WHERE status='upcoming'
AND city='Hyderabad';


SELECT *
FROM Feedback
WHERE rating>=4;


SELECT *
FROM Sessions
WHERE speaker_name='Dr. Kumar'
OR speaker_name='Anita';
