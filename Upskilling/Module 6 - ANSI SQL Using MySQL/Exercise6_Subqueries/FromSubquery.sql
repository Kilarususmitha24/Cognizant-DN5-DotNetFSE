USE CommunityEventDB;



SELECT *

FROM
(
    SELECT
        event_id,
        COUNT(*) AS TotalRegistrations
    FROM Registrations
    GROUP BY event_id
) AS RegistrationSummary;


SELECT *

FROM
(
    SELECT
        event_id,
        AVG(rating) AS AverageRating
    FROM Feedback
    GROUP BY event_id
) AS RatingSummary;
