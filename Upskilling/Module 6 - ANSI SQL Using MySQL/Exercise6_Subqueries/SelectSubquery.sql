USE CommunityEventDB;

SELECT
    event_id,
    title,

    (
        SELECT COUNT(*)
        FROM Registrations
        WHERE Registrations.event_id = Events.event_id
    ) AS TotalRegistrations

FROM Events;


SELECT
    event_id,
    title,

    (
        SELECT AVG(rating)
        FROM Feedback
        WHERE Feedback.event_id = Events.event_id
    ) AS AverageRating

FROM Events;
