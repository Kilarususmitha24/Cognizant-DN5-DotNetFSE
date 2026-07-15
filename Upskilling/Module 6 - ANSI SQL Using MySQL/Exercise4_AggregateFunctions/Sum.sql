USE CommunityEventDB;


SELECT SUM(rating) AS TotalRating
FROM Feedback;


SELECT SUM(registration_id) AS RegistrationIDSum
FROM Registrations;


SELECT SUM(user_id) AS UserIDSum
FROM Users;
