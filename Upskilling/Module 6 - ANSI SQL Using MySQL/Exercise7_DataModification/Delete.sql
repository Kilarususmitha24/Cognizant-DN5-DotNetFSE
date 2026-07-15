USE CommunityEventDB;



DELETE FROM Feedback

WHERE feedback_id=3;



DELETE FROM Registrations

WHERE registration_id=5;


DELETE FROM Users

WHERE user_id=8;


SELECT * FROM Feedback;

SELECT * FROM Registrations;

SELECT * FROM Users;
